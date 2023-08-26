using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDSV_TC
{
    public partial class FormMH : Form
    {

        int vitri = 0;
        private string flagOption;
        private string oldMaMonHoc = "";
        private string oldTenMonHoc = "";
        public FormMH()
        {
            InitializeComponent();
        }

       
 

    
        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void mONHOCGridControl_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.flagOption = "ADD";
            this.bdsMonHoc.AddNew();
            this.formMonhoc.Enabled = false;
            this.formInputMH.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa2.Enabled = false;
            btnGhi.Enabled  = true;

        }

        private void FormMH_Load(object sender, EventArgs e)
        {
            this.formInputMH.Enabled = false;
            dS_SV1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);
            

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);

            this.speSoTietLT.Properties.MinValue = 0;
            this.speSoTietLT.Properties.MaxValue = 100;
            this.speSoTietTH.Properties.MinValue = 0;
            this.speSoTietTH.Properties.MaxValue = 100;
            if (Program.mGroup == "SV")
            {

                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa2.Enabled = false;
            }
            else
            {
                btnGhi.Enabled = false;
                btnThem.Enabled = btnSua.Enabled  = btnXoa2.Enabled = true;
            }


        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validatorMonHoc() == true)
            {
                try
                {
                    this.bdsMonHoc.EndEdit();
                    this.bdsMonHoc.ResetCurrentItem();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.dS_SV1.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp học: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                this.formMonhoc.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa2.Enabled = true;
                btnGhi.Enabled = btnXoa2.Enabled = false;
                this.formInputMH.Enabled = false;

            }
            else
            {
                return;
            }
        }
        private bool validatorMonHoc()
        {

            if (txbMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txbMaMonHoc.Focus();
                return false;
            }
            if (txbTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                txbTenMonHoc.Focus();
                return false;
            }
            if (speSoTietLT.Text.Trim() == "")
            {
                MessageBox.Show("Số tiết lý thuyết không được thiếu!", "", MessageBoxButtons.OK);
                this.speSoTietLT.Focus();
                return false;
            }
            if (speSoTietTH.Text.Trim() == "")
            {
                MessageBox.Show("Số tiết thực hành không được thiếu!", "", MessageBoxButtons.OK);
                this.speSoTietTH.Focus();
                return false;
            }
            if ((speSoTietLT.Value + speSoTietTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số tiết lý thuyết và thực hành phải là bội của 15!", "", MessageBoxButtons.OK);
                speSoTietLT.Focus();
                return false;
            }
            if (flagOption == "ADD")
            {

                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txbMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK);
                    return false;
                }

                // TODO : Check tên môn học có tồn tại chưa
                string query2 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + txbTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultTen = Program.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    XtraMessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK);

                    return false;
                }
            }

            if (flagOption == "UPDATE")
            {
                if (!this.txbMaMonHoc.Text.Trim().ToString().Equals(oldMaMonHoc))// Nếu mã môn học thay đổi so với ban đầu
                {
                    //TODO: Check mã môn học có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txbMaMonHoc.Text + "',@Type = N'MAMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultMa = Program.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        XtraMessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK);

                        return false;
                    }
                }
                if (!this.txbTenMonHoc.Text.Trim().ToString().Equals(oldTenMonHoc))// Nếu tên môn học thay đổi so với ban đầu
                {
                    // TODO : Check tên môn học có tồn tại chưa
                    string query2 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + txbTenMonHoc.Text + "',@Type = N'TENMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultTen = Program.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        XtraMessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK);

                        return false;
                    }
                }
            }
            
            return true;


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnThem.Enabled = btnSua.Enabled = btnXoa2.Enabled = false;
            this.btnGhi.Enabled = true;
            this.formMonhoc.Enabled = false;
            this.formInputMH.Enabled = true; 

            this.flagOption = "UPDATE";
            this.vitri = this.bdsMonHoc.Position;
            this.oldMaMonHoc = this.txbMaMonHoc.Text.Trim();
            this.oldTenMonHoc = this.txbTenMonHoc.Text.Trim();
        }


        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsMonHoc.CancelEdit();
            this.btnThem.Enabled = this.btnXoa2.Enabled = this.btnSua.Enabled=this.formMonhoc.Enabled = true;
            this.btnGhi.Enabled =this.formInputMH.Enabled = false;
        }

        

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = "";
            if (this.bdsLOPTINCHI.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong lớp học", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mamh = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.dS_SV1.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học: " + ex.Message, "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MALOP", mamh);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0) btnXoa2.Enabled = false;
        }
    }
}
