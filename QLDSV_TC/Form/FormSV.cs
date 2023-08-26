using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
//a

namespace QLDSV_TC
{
    public partial class FormSV : Form
    {

        //int vitri = 0;
        string macn = "";
        private string _flagOptionSinhVien;
      
        public FormSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            dS_SV1.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);


            panelControl2.Enabled = false;


            macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }

        }
         
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.severname = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

                    this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);



                    macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không được truy cập phòng kế toán ", "", MessageBoxButtons.OK);
                }

            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vitri = bdsSV.Position;
            _flagOptionSinhVien = "ADD";

            //dANGHIHOCCheckBox.Checked = true;
            dANGHIHOCCheckBox.Checked = false;
            //dANGHIHOCCheckBox.Enabled = false;
            mASVTextEdit.Enabled = true;

                
        
            panelControl2.Enabled = true;

            bdsSV.AddNew();
            mALOPTextEdit1.Text = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
            mALOPTextEdit1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = txbMaSV.Enabled = true;
            sINHVIENGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masv = "";
            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    bdsSV.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS_SV1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
                    bdsSV.Position = bdsLOP.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vitri = bdsSV.Position;
            _flagOptionSinhVien = "UPDATE";
            mALOPTextEdit1.Enabled = false;
            mASVTextEdit.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            txbMaSV.Enabled = false;
            sINHVIENGridControl.Enabled = false;
        }

        private bool validatorSinhVien()
        {
            if (mASVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                mALOPTextEdit1.Focus();
                return false;
            }
            if (hOTextEdit1.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                hOTextEdit1.Focus();
                return false;
            }
            if (tENTextEdit1.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                tENTextEdit1.Focus();
                return false;
            }

            if (dANGHIHOCCheckBox.Checked == true && _flagOptionSinhVien == "ADD")
            {
                MessageBox.Show("Đã nghỉ học phải là false!", "", MessageBoxButtons.OK);
                tENTextEdit1.Focus();
                return false;
            }
            if (dIACHITextEdit1.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                dIACHITextEdit1.Focus();
                return false;
            }
           
            if (_flagOptionSinhVien == "ADD")
            {
                string query1 = " DECLARE @return_value INT " +

                             " EXEC @return_value = [dbo].[SP_CHECKID] " +

                             " @Code = N'" + txbMaSV.Text.Trim() + "',  " +

                             " @Type = N'MASV' " +

                             " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (_flagOptionSinhVien == "UPDATE")
            {
             
                    string query2 = " DECLARE @return_value INT " +

                             " EXEC @return_value = [dbo].[SP_CHECKID]" +

                             " @Code = N'" + txbMaSV.Text.Trim() + "',  " +

                             " @Type = N'MASV' " +

                             " SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query2);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    //if (resultMa == 1)
                    //{
                    //    XtraMessageBox.Show("Không thể cập nhật Mã sv. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return false;
                    //}
                    //if (resultMa == 2)
                    //{
                    //    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return false;
                    //}
                

            }
            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validatorSinhVien() == true)
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS_SV1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                sINHVIENGridControl.Enabled = true;
                mALOPTextEdit1.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelControl2.Enabled = false;
            }
            else
            {
                return;
            }
        }

        //private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    bdsSV.CancelEdit();
        //    if (btnThem.Enabled == false) bdsLOP.Position = vitri;
        //    sINHVIENGridControl.Enabled = true;
        //    panelControl2.Enabled = false;
        //    mALOPTextEdit1.Enabled = true;
        //    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        //    btnGhi.Enabled = btnPhucHoi.Enabled = false;
        //    //FormSV_Load(sender, e);

        //    dS_SV1.EnforceConstraints = false;

        //    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

        //    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

        //    this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);

        //    if (vitri > 0)
        //    {
        //        bdsSV.Position = vitri;
        //    }
        //}

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
                this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = true;
                sINHVIENGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                panelControl2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
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
