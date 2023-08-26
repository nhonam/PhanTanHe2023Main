using DevExpress.XtraReports.UI;
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
    public partial class FrptDiemTongket : Form
    {
        public FrptDiemTongket()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "", MessageBoxButtons.OK);
                txtLop.Focus();
                return;
            }
            string maLop = txtLop.Text;
            string cmd = "EXEC dbo.SP_Get_Khoa_by_MaLop '" + maLop + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            string tenkhoa = reader.GetString(0);
            reader.Close();
            XtraReport_DiemTongKet rpt = new XtraReport_DiemTongKet(maLop);
            rpt.lbLop.Text = "LỚP: " + maLop + "– KHÓA HỌC: ";
            rpt.lbKhoa.Text = "KHOA: " + tenkhoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
