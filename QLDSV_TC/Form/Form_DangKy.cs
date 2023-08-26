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

namespace QLDSV_TC
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void Form_DangKy_Load(object sender, EventArgs e)
        {
            loadGVcombobox();


            if (Program.mGroup.Contains("KHOA"))
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoPKT.Enabled = false;
            }
            if (Program.mGroup.Contains("PGV"))
            {
                rdoPKT.Enabled = false;
            }
            if (Program.mGroup.Contains("PKT"))
            {
                rdoPKT.Checked = true;
                rdoKhoa.Enabled = rdoPGV.Enabled = false;
            }
        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LayDSGV";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbGiangVien.DataSource = bdsgv;
            cbGiangVien.DisplayMember = "MAGV";
            cbGiangVien.ValueMember = "MAGV";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txbTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
                txbTenLogin.Focus();
                return;
            }
            if (txbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbMatKhau.Focus();
                return;
            }
            if (txbXacNhanMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (txbXacNhanMK.Text != txbMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (rdoKhoa.Checked == false && rdoPGV.Checked == false && rdoPKT.Checked == false)
            {
                MessageBox.Show("Nhóm quyền không được thiếu!", "", MessageBoxButtons.OK);
                rdoKhoa.Focus();
                return;
            }
            string login = txbTenLogin.Text;
            string matkhau = txbMatKhau.Text;
            string user = cbGiangVien.SelectedValue.ToString();
            string role = "";
            if (rdoKhoa.Checked) role = "KHOA";
            if (rdoPGV.Checked) role = "PGV";
            if (rdoPKT.Checked) role = "PKT";

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + matkhau + "', " +
                           " @USERNAME = N'" + user + "', " +
                           " @ROLE = N'" + role + "' ";



            string strLenh = " DECLARE @return_value int " + subLenh +
                    " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Program.CheckDataHelper(strLenh);


            if (resultCheckLogin == 1)
            {
                XtraMessageBox.Show("Login bị trùng . Mời bạn nhập login khác !", "", MessageBoxButtons.OK);

            }
            else if (resultCheckLogin == 2)
            {
                XtraMessageBox.Show("Giảng viên đã có tài khoản rồi !", "", MessageBoxButtons.OK);


            }

            else if (resultCheckLogin == 0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }
    
    }
}
