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
    public partial class FrptDSSVDKLTC : Form
    {
        public FrptDSSVDKLTC()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string nienkhoa = cbNienKhoa.Text;
            int hocky = Int32.Parse(cbHocKi.Text);
            int nhom = Int32.Parse(cbNhom.Text);
            string monhoc = cbMonHoc.SelectedValue.ToString();
            string khoa = cbKhoa.Text;
            Xtrp_DSSVDKLTC rpt = new Xtrp_DSSVDKLTC(nienkhoa, hocky, nhom, monhoc);
            rpt.lbMonHoc.Text = monhoc;
            rpt.lbHocKy.Text = hocky.ToString();
            rpt.lbNhom.Text = nhom.ToString();
            rpt.lbNienKhoa.Text = nienkhoa;
            rpt.lbKhoa.Text = khoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void FrptDSSVDKLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            cbMonHoc.DataSource = mONHOCBindingSource;
            cbMonHoc.DisplayMember = "TENMH";
            cbMonHoc.ValueMember = "TENMH";


            loadcbNienkhoa();
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
        void loadNhom(string nienkhoa, string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '" + nienkhoa + "', " + hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbNhom.DataSource = bdsNhom;
            cbNhom.DisplayMember = "NHOM";
            cbNhom.ValueMember = "NHOM";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA not LIKE 'Phòng Kế Toán%'";
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.severname = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mChinhanh)
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
                loadcbNienkhoa();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhom(cbNienKhoa.Text, cbHocKi.Text);
        }
    }
}
