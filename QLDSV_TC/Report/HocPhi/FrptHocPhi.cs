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
    public partial class FrptHocPhi : Form
    {
        public FrptHocPhi()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống", "", MessageBoxButtons.OK);
                txbNienKhoa.Focus();
                return;
            }
            if (nmHocKy.Value == 0)
            {
                MessageBox.Show("Học Kỳ không được để trống", "", MessageBoxButtons.OK);
                nmHocKy.Focus();
                return;
            }
            string nienkhoa = txbNienKhoa.Text;
            int hocky = (int)nmHocKy.Value;
            string malop = cbLop.Text;
            string cmd = "EXEC dbo.SP_Get_Khoa_by_MaLop '" + malop + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            
            
            reader.Read();
            string tenkhoa = reader.GetString(0);
            reader.Close();
            Xrpt_Hoc_Phi rpt = new Xrpt_Hoc_Phi(malop, nienkhoa, hocky);
            rpt.lbMaLop.Text = malop;
            rpt.lbKhoa.Text = tenkhoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
