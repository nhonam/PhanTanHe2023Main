using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDSV_TC
{
    public partial class FormDangKi : Form
    {
        private BindingSource bdsSinhVien = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsDSLTC_HUY = new BindingSource();
        int kt = 0;
        
        public FormDangKi()
        {
            InitializeComponent();
        }


        private void btnSearchSinhVien_Click(object sender, EventArgs e)
        {
            txbMaSV.Text = Program.username.Trim();
            if (txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            if (txbMaSV.Text.Trim() != Program.username.Trim())
            {
                MessageBox.Show("Bạn không phải là tài khoản sinh viên này!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            txbMaSVDK.Text = txbMaSV.Text;
            string cmd = "EXEC dbo.SP_getInfoSVDKI '" + txbMaSV.Text + "'";
            string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
            DataTable tableSV = Program.ExecSqlDataTable(cmd);
            DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);

            this.bdsSinhVien.DataSource = tableSV;
            this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
            this.SINHVIENgridControl.DataSource = this.bdsSinhVien;
            this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {
            loadcbNienkhoa();
            btnHuyDangKy.Enabled = true;
        }
        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbNienKhoa.DataSource = bdsNienKhoa;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
        }

        // bat su kien click chuot vao grid dsltc
        private void LOPTINCHIgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                txbMaLopTinChi.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }
        }
        // bat su kien nhan nut search lop tin chi
        private void btnSearchLopTinChi_Click(object sender, EventArgs e)
        {
            string cmd = "EXEC [dbo].[SP_InDanhSachLopTinChi] '" + cbNienKhoa.Text + "', '" + cbHocKi.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.LOPTINCHIgridControl.DataSource = this.bdsLopTinchi;
        }
        // bat su kien click chuot vao sinh vien grid
        private void SINHVIENgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                kt = bdsDSLTC_HUY.Count;

                txbMaSVDK.Text = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            }

        }

        private void btnHuyDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaSVDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSVDK.Focus();
                return;
            }
            if (bdsDSLTC_HUY.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp tín chỉ để hủy");
                DSLTC_HUYgridControl.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maltc = "";
                if (((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"] != null)
                {
                    maltc = ((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"].ToString();
                }

                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txbMaSVDK.Text + "' , '" + maltc + "', " + 2;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                    string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
                    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
                    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
                    this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        // click vao dsltc_huy
        private void DSLTC_HUYgridControl_Click(object sender, EventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {

                txbMaLopTinChi.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }
        }

        private void btnDANGKI_Click(object sender, EventArgs e)
        {
            btnHuyDangKy.Enabled = false;
            
            try
            {
                if (txbMaSVDK.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                    txbMaSVDK.Focus();
                    return;
                }
                if (txbMaLopTinChi.Text.Trim() == "")
                {
                    MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                    txbMaLopTinChi.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string MALTC = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
                string NIENKHOA = cbNienKhoa.Text;
                string HOCKY = cbHocKi.Text;
                string TENMH = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["TENMH"].ToString();
                string HOTENGV = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["HOTEN"].ToString();
                string NHOM = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["NHOM"].ToString();

                BindingSource bdsTemp = (BindingSource)this.DSLTC_HUYgridControl.DataSource;
                for (int i = 0; i < bdsTemp.Count; i++)
                {
                    if (((DataRowView)bdsTemp[i])["MALTC"].ToString() == txbMaLopTinChi.Text)
                    {

                        MessageBox.Show("Sinh viên đã đăng ký lớp này!", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        gridView3.AddNewRow();
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colMALTC1, MALTC);
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colNIENKHOA, NIENKHOA);
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colHOCKY, HOCKY);
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colTENMH, TENMH);
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colHOTENGV, HOTENGV);
                        gridView3.SetRowCellValue(gridView3.FocusedRowHandle, colNHOM1, NHOM);
                        return;
                    }
                }
            }

        }
        

        private void Lưu_Click(object sender, EventArgs e)
        {
            btnHuyDangKy.Enabled = true;
            BindingSource bdsTemp = (BindingSource)this.DSLTC_HUYgridControl.DataSource;
            if (bdsTemp == null)
            {
                MessageBox.Show("Chưa có thông tin!", "", MessageBoxButtons.OK);
                return;
            }

            //string maltc = txbMaLopTinChi.Text;
            string msv = txbMaSVDK.Text;
            int type = 1;
            bdsDSLTC_HUY.EndEdit();
            bdsDSLTC_HUY.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();

            try
            {
                for (int i = kt; i < bdsTemp.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("SP_XULY_LTC", conn);
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                    cmd.Parameters.Add(new SqlParameter("@MALTC", ((DataRowView)bdsTemp[i])["MALTC"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@type", type));
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                //MessageBox.Show("Thêm thành công!");
                MessageBox.Show("Đăng kí thành công!");
                load();
            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    MessageBox.Show("Lỗi ghi vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);
                    load();
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
        void load()
        {
            string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
            DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
            this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
            this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;

            string cmd2 = "EXEC [dbo].[SP_InDanhSachLopTinChi] '" + cbNienKhoa.Text + "', '" + cbHocKi.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd2);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.LOPTINCHIgridControl.DataSource = this.bdsLopTinchi;
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                loadcbHocKi(cbNienKhoa.Text);
                //cbHocKi.SelectedIndex = 0;
        }

        



        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.YellowGreen;
            }
        }

        
    }
}
