using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormLH : Form
    {
        int vitri = 0;
        Stack undoList = new Stack();
        string macn = "";
        private string _flagOptionLop;
        private string _oldMaLop = "";
        private string _oldTenLop = "";
        public FormLH()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void FormLH_Load(object sender, EventArgs e)
        {
            dS_SV1.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);


            }
            macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
        }

        // ham xu ly khi nhap lieu - sau - xoa data
        private bool validatorLopHoc()
        {
            if (txbMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txbMaLop.Focus();
                return false;
            }
            if (txbTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txbTenLop.Focus();
                return false;
            }
            if (txbKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "", MessageBoxButtons.OK);
                txbKhoaHoc.Focus();
                return false;
            }
            if (txbMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return false;
            }
            if (_flagOptionLop == "ADD")
            {
                //TODO: Check mã lớp có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC  @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txbMaLop.Text + "',@Type = N'MALOP' \n"
                            + "SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã lớp đã tồn tại ở Khoa hiên tại !", "", MessageBoxButtons.OK);

                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã lớp đã tồn tại ở Khoa khác !", "", MessageBoxButtons.OK);

                    return false;
                }

                // TODO : Check tên lớp có tồn tại chưa
                string query2 = "DECLARE @return_value int \n"
                               + "EXEC @return_value = SP_CHECKNAME \n"
                               + "@Name = N'" + txbTenLop.Text + "', @Type = N'TENLOP' \n"
                               + "SELECT 'Return Value' = @return_value ";
                int resultTen = Program.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    XtraMessageBox.Show("Tên lớp đã có rồi !", "", MessageBoxButtons.OK);

                    return false;
                }
                if (resultTen == 2)
                {
                    XtraMessageBox.Show("Tên lớp đã tồn tại ở Khoa khác !", "", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (_flagOptionLop == "UPDATE")
            {
                if (!this.txbMaLop.Text.Trim().ToString().Equals(_oldMaLop))// Nếu mã lớp thay đổi so với ban đầu
                {
                    //TODO: Check mã lớp có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC  @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txbMaLop.Text + "',@Type = N'MALOP' \n"
                                + "SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        XtraMessageBox.Show("Mã lớp đã tồn tại ở Khoa hiên tại !", "", MessageBoxButtons.OK);
                        return false;
                    }
                    if (resultMa == 2)
                    {
                        XtraMessageBox.Show("Mã lớp đã tồn tại ở Khoa khác !", "", MessageBoxButtons.OK);
                        return false;
                    }
                }
                if (!this.txbTenLop.Text.Trim().ToString().Equals(_oldTenLop))
                {
                    // TODO : Check tên lớp có tồn tại chưa
                    string query2 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txbTenLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                    int resultTen = Program.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        XtraMessageBox.Show("Tên lớp đã có rồi !", "", MessageBoxButtons.OK);
                        return false;
                    }
                    if (resultTen == 2)
                    {
                        XtraMessageBox.Show("Tên lớp đã tồn tại ở Khoa khác !", "", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            return true;
        }


        // btn Them

        // btn Thoat

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        // mau cua grid
     
    private void lOPGridControl_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        GridView view = sender as GridView;
        if (e.RowHandle == view.FocusedRowHandle)
        {
            e.Appearance.BackColor = Color.YellowGreen;
        }
    }

        private void lOPGridControl_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            _flagOptionLop = "ADD";

            panelControl2.Enabled = true;
            bdsLOP.AddNew();
            this.txbMaKhoa.Text = macn;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validatorLopHoc() == true)
            {
                try
                {
                    MessageBox.Show("Cập nhật thành công!", "", MessageBoxButtons.OK);
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                   
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS_SV1.LOP);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp học: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                lOPGridControl.Enabled = true;
                btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelControl2.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            _flagOptionLop = "UPDATE";
            _oldMaLop = this.txbMaLop.Text.Trim();
            _oldTenLop = this.txbTenLop.Text.Trim();
            txbMaLop.Enabled = false;
            panelControl2.Enabled = true;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled  = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            if (btnAdd.Enabled == false) bdsLOP.Position = vitri;
            lOPGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            FormLH_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                bdsLOP.Position = vitri;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp học này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    bdsLOP.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS_SV1.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp học: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }
            if (bdsLOP.Count == 0) btnDelete.Enabled = false;
        }


    }
}
