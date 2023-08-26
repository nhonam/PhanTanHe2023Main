using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            PhanQuyen();
            this.MAGV.Text = "Mã : " + Program.username;
            this.HOTEN.Text = "- Họ tên :  " + Program.mHoten;
            this.NHOM.Text = "- Nhóm :  " + Program.mGroup;
            

        }
        public void HienThiMenu()
        {
            rpNHAPXUAT.Visible = rpBAOCAO.Visible = rpHETHONG.Visible = true;
        }
        void PhanQuyen()
        {
            if (Program.mGroup.Equals("SINHVIEN"))
            {
                btnDANGKI.Enabled = true;
                btnDIEM.Enabled = btnTaoTk.Enabled = btnHOCPHI.Enabled = btnLOPHOC.Enabled = btnLOPTINCHI.Enabled = btnMONHOC.Enabled = btnSINHVIEN.Enabled = btnTaoTk.Enabled = false;
                rpBAOCAO.Visible = false;

            }
            if (Program.mGroup.Equals("PKT"))
            {
                btnHOCPHI.Enabled = true;
                btnDIEM.Enabled = btnLOPHOC.Enabled = btnLOPTINCHI.Enabled = btnMONHOC.Enabled = btnSINHVIEN.Enabled = btnDANGKI.Enabled = false;
                rpBAOCAO.Visible = true;
                btnPHIEUDIEM.Enabled = btnBDMH.Enabled = barButtonItem1.Enabled = btnDSLTC.Enabled = btnDSSVDK.Enabled = false;
            }
            
            if (Program.mGroup.Contains("PGV") || Program.mGroup.Equals("KHOA"))
            {
                rpNHAPXUAT.Visible = true;
                btnDANGKI.Enabled = btnHOCPHI.Enabled = false;
                
                ho.Enabled = false;
            }
        }
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            Program.bds_dspm = null;
            Form frmDangNhap = new FormDN();

            this.Close();
        }

        private void btnSINHVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSV));
            if (frm != null) frm.Activate();
            else
            {
                FormSV f = new FormSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMONHOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMH));
            if (frm != null) frm.Activate();
            else
            {
                FormMH f = new FormMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLOPHOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLH));
            if (frm != null) frm.Activate();
            else
            {
                FormLH f = new FormLH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLOPTINCHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLTC));
            if (frm != null) frm.Activate();
            else
            {
                FormLTC f = new FormLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDIEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormDiem f = new FormDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDANGKI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormDangKi f = new FormDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        

        private void btnBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XtraReport_BDMH));
            if (frm != null) frm.Activate();
            else
            {
                Input_Report_BDMH f = new Input_Report_BDMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPHIEUDIEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XtraReport_PhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                Input_PhieuDiem f = new Input_PhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHOCPHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormHP));
            if (frm != null) frm.Activate();
            else
            {
                FormHP f = new FormHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                FrptHocPhi f = new FrptHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptDSLTC));
            if (frm != null) frm.Activate();
            else
            {
                FrptDSLTC f = new FrptDSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptDSSVDKLTC));
            if (frm != null) frm.Activate();
            else
            {
                FrptDSSVDKLTC f = new FrptDSSVDKLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BTNTTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_DangKy));
            if (frm != null) frm.Activate();
            else
            {
                Form_DangKy f = new Form_DangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptDiemTongket));
            if (frm != null) frm.Activate();
            else
            {
                FrptDiemTongket f = new FrptDiemTongket();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
