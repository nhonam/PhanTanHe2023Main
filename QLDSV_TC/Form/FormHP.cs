using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormHP : Form
    {
        int coutHP = 0;
        BindingSource bdsHocPhi = new BindingSource();
        BindingSource bdsCTHocPhi = new BindingSource();
        public FormHP()
        {
            InitializeComponent();
        }
        private void Hp_load()
        {
            string cmd1 = "EXEC [dbo].[SP_GetInfoSV_HP] '" + txbMaSV.Text + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd1);
            if (reader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                reader.Close();
                return;
            }
            reader.Read();
            txbTenSinhVien.Text = reader.GetString(0);
            txbMaLop.Text = reader.GetString(1);
            reader.Close();
            Program.conn.Close();
            string cmd2 = "EXEC dbo.SP_Get_All_HP_SV '" + txbMaSV.Text + "'";
            DataTable tableHocPhi = Program.ExecSqlDataTable(cmd2);
            this.bdsHocPhi.DataSource = tableHocPhi;
            this.hOCPHIGridControl.DataSource = this.bdsHocPhi;
            coutHP = this.bdsHocPhi.Count;
        }
        private void hOCPHIGridControl_Click(object sender, EventArgs e)
        {
            if (bdsHocPhi.Count > 0)
            {
                string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
                string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
                string msv = txbMaSV.Text;
                string cmd = "EXEC dbo.SP_GetCTHP_SV '" + msv + "', '" + nienkhoa + "', '" + hocki + "'";
                DataTable tableCTHocPhi = Program.ExecSqlDataTable(cmd);
                this.bdsCTHocPhi.DataSource = tableCTHocPhi;
                this.cT_DONGHOCPHIGridControl.DataSource = this.bdsCTHocPhi;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
                txbMaSV.Focus();
                return;
            }
            Hp_load();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.AddNew();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txbMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã sinh viên");
                    txbMaSV.Focus();
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString() == "")
                {
                    MessageBox.Show("Niên khóa chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString() == "")
                {
                    MessageBox.Show("Học kỳ chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString() == "")
                {
                    MessageBox.Show("Học phí chưa nhập!");
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString()) <= 0)
                {
                    MessageBox.Show("Học kì không được nhỏ hơn 1");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            bdsHocPhi.EndEdit();
            bdsHocPhi.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {

                for (int i = coutHP; i < bdsHocPhi.Count; i++)
                {
                    string msv = txbMaSV.Text;
                    string nienkhoa = ((DataRowView)bdsHocPhi[i])["NIENKHOA"].ToString();
                    string hocki = ((DataRowView)bdsHocPhi[i])["HOCKY"].ToString();
                    string hocphi = ((DataRowView)bdsHocPhi[i])["HOCPHI"].ToString();
                    SqlCommand cmd = new SqlCommand("TAO_THONGTINHOCPHI", conn);
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                    cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                    cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                    cmd.Parameters.Add(new SqlParameter("@HocPhi", hocphi));
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                MessageBox.Show("Thêm học phí thành công!");
                Hp_load();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsHocPhi.CancelEdit();
            Hp_load();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bdsCTHocPhi.AddNew();
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (((DataRowView)bdsCTHocPhi[bdsCTHocPhi.Position])["SOTIENDONG"].ToString() == "")
                {
                    MessageBox.Show("Số tiền không được bỏ trống");
                    return;
                }
                if (float.Parse(((DataRowView)bdsCTHocPhi[bdsCTHocPhi.Position])["SOTIENDONG"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }

                if (float.Parse(((DataRowView)bdsCTHocPhi[bdsCTHocPhi.Position])["SOTIENDONG"].ToString()) > float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["SOTIENCANDONG"].ToString()))
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn số tiền cần đóng!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string msv = txbMaSV.Text;
            string sotiendong = ((DataRowView)bdsCTHocPhi[bdsCTHocPhi.Position])["SOTIENDONG"].ToString();
            bdsCTHocPhi.EndEdit();
            bdsCTHocPhi.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction

            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SV_DONGTIEN", conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@SoTienDong", sotiendong));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm chi tiết học phí thành công!");
                Hp_load();

            }
            catch (SqlException sqlex)
            {
                try
                {
                    XtraMessageBox.Show("Lỗi ghi chit tiết học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
