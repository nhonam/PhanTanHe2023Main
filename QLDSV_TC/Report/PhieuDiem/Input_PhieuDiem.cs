using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
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
    public partial class Input_PhieuDiem : Form
    {
        public Input_PhieuDiem()
        {
            InitializeComponent();
        }

        private bool ValidatorSV()
        {
            if (txbMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sinh viên không để trống", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return false;
            }
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
                //  XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 2 && Program.mGroup == "KHOA")
            {
                XtraMessageBox.Show("Sinh viên thuộc khoa khác, Bạn không có quyền truy cập. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (resultMa == 2)
            {

                return false;
            }
            else
            {
                XtraMessageBox.Show("Mã Sinh Viên không tồn tại. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidatorSV() == false)
            {
                string msv = txbMaSV.Text;
                int type = 0;
                if (Program.mGroup.Equals("KHOA"))
                {
                    type = 1;
                }
                if (Program.mGroup.Equals("PGV"))
                {
                    type = 0;
                }
                XtraReport_PhieuDiem rpt = new XtraReport_PhieuDiem(msv, type);
                rpt.lbMaSV.Text = msv;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();



            }
            else
            {
                return;
            }
        }
    }
}
