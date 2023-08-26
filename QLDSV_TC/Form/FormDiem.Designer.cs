
namespace QLDSV_TC
{
    partial class FormDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENMHLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_SV1 = new QLDSV_TC.DS_SV1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV_TC.DS_SV1TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV_TC.DS_SV1TableAdapters.MONHOCTableAdapter();
            this.sP_BDMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_BDMHTableAdapter = new QLDSV_TC.DS_SV1TableAdapters.SP_BDMHTableAdapter();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.sP_BDMHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_TK = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BDMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BDMHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(373, 91);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(62, 17);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "Môn học";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1677, 42);
            this.panelControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM SINH VIÊN";
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNhom);
            this.panel1.Controls.Add(this.cbHocKi);
            this.panel1.Controls.Add(this.cbNienKhoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.cbMonHoc);
            this.panel1.Controls.Add(this.btnBatDau);
            this.panel1.Controls.Add(tENMHLabel);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1677, 185);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(455, 50);
            this.cbNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(193, 24);
            this.cbNhom.TabIndex = 15;
            // 
            // cbHocKi
            // 
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Location = new System.Drawing.Point(136, 91);
            this.cbHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(193, 24);
            this.cbHocKi.TabIndex = 14;
            this.cbHocKi.SelectedIndexChanged += new System.EventHandler(this.cbHocKi_SelectedIndexChanged);
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Location = new System.Drawing.Point(136, 52);
            this.cbNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(193, 24);
            this.cbNienKhoa.TabIndex = 13;
            this.cbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienKhoa_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(377, 130);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 30);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(263, 130);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 30);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Ghi";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(455, 84);
            this.cbMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(193, 24);
            this.cbMonHoc.TabIndex = 10;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(136, 129);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(109, 30);
            this.btnBatDau.TabIndex = 9;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(783, 16);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(271, 24);
            this.cbKhoa.TabIndex = 5;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "KHOA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Niên khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập thông tin:";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS_SV1;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_BDMHBindingSource
            // 
            this.sP_BDMHBindingSource.DataMember = "SP_BDMH";
            this.sP_BDMHBindingSource.DataSource = this.dS_SV1;
            // 
            // sP_BDMHTableAdapter
            // 
            this.sP_BDMHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dS_SV1;
            // 
            // sP_BDMHGridControl
            // 
            this.sP_BDMHGridControl.DataSource = this.sP_BDMHBindingSource;
            this.sP_BDMHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_BDMHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.sP_BDMHGridControl.Location = new System.Drawing.Point(0, 227);
            this.sP_BDMHGridControl.MainView = this.gridView1;
            this.sP_BDMHGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.sP_BDMHGridControl.Name = "sP_BDMHGridControl";
            this.sP_BDMHGridControl.Size = new System.Drawing.Size(1677, 500);
            this.sP_BDMHGridControl.TabIndex = 9;
            this.sP_BDMHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALC,
            this.colMASV,
            this.colHOTEN,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_TK});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.sP_BDMHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALC
            // 
            this.colMALC.Caption = "Mã Lớp Tín Chỉ";
            this.colMALC.FieldName = "MALC";
            this.colMALC.MinWidth = 27;
            this.colMALC.Name = "colMALC";
            this.colMALC.Visible = true;
            this.colMALC.VisibleIndex = 0;
            this.colMALC.Width = 100;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 27;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            this.colMASV.Width = 100;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 27;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            this.colHOTEN.Width = 100;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.Caption = "Điểm CC";
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.MinWidth = 27;
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 3;
            this.colDIEM_CC.Width = 100;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.Caption = "Điểm GK";
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.MinWidth = 27;
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 4;
            this.colDIEM_GK.Width = 100;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.Caption = "Điểm CK";
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.MinWidth = 27;
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 5;
            this.colDIEM_CK.Width = 100;
            // 
            // colDIEM_TK
            // 
            this.colDIEM_TK.Caption = "Điểm Tổng Kết";
            this.colDIEM_TK.FieldName = "DIEM_TK";
            this.colDIEM_TK.MinWidth = 27;
            this.colDIEM_TK.Name = "colDIEM_TK";
            this.colDIEM_TK.Visible = true;
            this.colDIEM_TK.VisibleIndex = 6;
            this.colDIEM_TK.Width = 100;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 727);
            this.Controls.Add(this.sP_BDMHGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BDMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BDMHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DS_SV1 dS_SV1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DS_SV1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sP_BDMHBindingSource;
        private DS_SV1TableAdapters.SP_BDMHTableAdapter sP_BDMHTableAdapter;
        private DS_SV1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DevExpress.XtraGrid.GridControl sP_BDMHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALC;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_TK;
    }
}