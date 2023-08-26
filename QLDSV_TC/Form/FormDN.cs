using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormDN : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isSinhVien = false;
      
        public FormDN()
        {
            InitializeComponent();
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
        }
        private void LayDS_kHOA(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dskhoa.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
        }


        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại tên Sever của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }

        }


        private void FormDN_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDS_kHOA("SELECT * FROM LINK0.QLDSV_TC.dbo.DS_KHOA");
            LayDSPM("SELECT * FROM LINK0.QLDSV_TC.dbo.V_DS_PHANMANH");
         

            txtLogin.Text = "ltt";
            txtPass.Text = "1234";
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            //LayDSPM("SELECT * FROM LINK0.QLDSV_TC.dbo.V_DS_PHANMANH");
            try
            {
                Program.severname = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            {


                if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }




                if (isSinhVien == true)
                    Program.mlogin = "sinhvien";
                else Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;

                if (Program.KetNoi() == 0) return;


                Program.mlogin = txtLogin.Text;
                Program.mChinhanh = cmbKhoa.SelectedIndex;

                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strLenh;
                if (isSinhVien == true)

                    strLenh = "EXEC dbo.SP_LayThongTin_DangNhap '" + Program.mlogin + "', 'SV'";
                else
                    strLenh = "EXEC dbo.SP_LayThongTin_DangNhap '" + Program.mlogin + "', 'GV'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break

                Program.username = Program.myReader.GetString(0);






                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.mHoten = Program.myReader.GetString(1);
                }
                catch
                {
                    MessageBox.Show("Login failed", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mHoten = Program.myReader.GetString(1);
                if (cmbKhoa.Text.ToString().Equals("Phòng Kế Toán") && isSinhVien)
                {
                    MessageBox.Show("sinh viên không được đăng nhập vào phòng kế toán");
                    return;
                }
                Program.myReader.Close();
            }




            Form f = new FormMain();
            f.ShowDialog();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            //Program.mainForm.Close();
        }
    }
}
