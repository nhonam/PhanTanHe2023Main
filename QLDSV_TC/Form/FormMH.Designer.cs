
namespace QLDSV_TC
{
    partial class FormMH
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMH));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SV1 = new QLDSV_TC.DS_SV1();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa1 = new DevExpress.XtraBars.BarButtonItem();
            this.MONHOCTableAdapter = new QLDSV_TC.DS_SV1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager();
            this.bdsLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.DS_SV1TableAdapters.LOPTINCHITableAdapter();
            this.formMonhoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formInputMH = new DevExpress.XtraEditors.PanelControl();
            this.speSoTietTH = new DevExpress.XtraEditors.SpinEdit();
            this.speSoTietLT = new DevExpress.XtraEditors.SpinEdit();
            this.txbTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txbMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formInputMH)).BeginInit();
            this.formInputMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(314, 30);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(93, 17);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học :";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(309, 67);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(99, 17);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học :";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(292, 107);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(115, 17);
            sOTIET_LTLabel.TabIndex = 4;
            sOTIET_LTLabel.Text = "Số tiết lý thuyết :";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(285, 149);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(124, 17);
            sOTIET_THLabel.TabIndex = 6;
            sOTIET_THLabel.Text = "Số tiết thực hành :";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS_SV1;
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnXoa2,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat,
            this.btnXoa1});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Caption = "Xoa";
            this.btnXoa2.Id = 3;
            this.btnXoa2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa2.ImageOptions.Image")));
            this.btnXoa2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa2.ImageOptions.LargeImage")));
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa2_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 502);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnXoa1
            // 
            this.btnXoa1.Caption = "Xóa ";
            this.btnXoa1.Id = 8;
            this.btnXoa1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa1.ImageOptions.Image")));
            this.btnXoa1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa1.ImageOptions.LargeImage")));
            this.btnXoa1.Name = "btnXoa1";
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsLOPTINCHI
            // 
            this.bdsLOPTINCHI.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLOPTINCHI.DataSource = this.bdsMonHoc;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // formMonhoc
            // 
            this.formMonhoc.DataSource = this.bdsMonHoc;
            this.formMonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.formMonhoc.Location = new System.Drawing.Point(2, 2);
            this.formMonhoc.MainView = this.gridView1;
            this.formMonhoc.MenuManager = this.barManager1;
            this.formMonhoc.Name = "formMonhoc";
            this.formMonhoc.Size = new System.Drawing.Size(1080, 267);
            this.formMonhoc.TabIndex = 0;
            this.formMonhoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.formMonhoc.Click += new System.EventHandler(this.mONHOCGridControl_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.GridControl = this.formMonhoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 25;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.OptionsColumn.AllowEdit = false;
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            this.colSOTIET_LT.Width = 94;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 25;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.OptionsColumn.AllowEdit = false;
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            this.colSOTIET_TH.Width = 94;
            // 
            // formInputMH
            // 
            this.formInputMH.Controls.Add(sOTIET_THLabel);
            this.formInputMH.Controls.Add(this.speSoTietTH);
            this.formInputMH.Controls.Add(sOTIET_LTLabel);
            this.formInputMH.Controls.Add(this.speSoTietLT);
            this.formInputMH.Controls.Add(tENMHLabel);
            this.formInputMH.Controls.Add(this.txbTenMonHoc);
            this.formInputMH.Controls.Add(mAMHLabel);
            this.formInputMH.Controls.Add(this.txbMaMonHoc);
            this.formInputMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formInputMH.Location = new System.Drawing.Point(2, 269);
            this.formInputMH.Name = "formInputMH";
            this.formInputMH.Size = new System.Drawing.Size(1080, 180);
            this.formInputMH.TabIndex = 1;
            // 
            // speSoTietTH
            // 
            this.speSoTietTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_TH", true));
            this.speSoTietTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoTietTH.Location = new System.Drawing.Point(413, 146);
            this.speSoTietTH.MenuManager = this.barManager1;
            this.speSoTietTH.Name = "speSoTietTH";
            this.speSoTietTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoTietTH.Size = new System.Drawing.Size(220, 24);
            this.speSoTietTH.TabIndex = 7;
            // 
            // speSoTietLT
            // 
            this.speSoTietLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_LT", true));
            this.speSoTietLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoTietLT.Location = new System.Drawing.Point(413, 104);
            this.speSoTietLT.MenuManager = this.barManager1;
            this.speSoTietLT.Name = "speSoTietLT";
            this.speSoTietLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoTietLT.Size = new System.Drawing.Size(220, 24);
            this.speSoTietLT.TabIndex = 5;
            // 
            // txbTenMonHoc
            // 
            this.txbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txbTenMonHoc.Location = new System.Drawing.Point(413, 64);
            this.txbTenMonHoc.MenuManager = this.barManager1;
            this.txbTenMonHoc.Name = "txbTenMonHoc";
            this.txbTenMonHoc.Size = new System.Drawing.Size(220, 22);
            this.txbTenMonHoc.TabIndex = 3;
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txbMaMonHoc.Location = new System.Drawing.Point(413, 27);
            this.txbMaMonHoc.MenuManager = this.barManager1;
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Size = new System.Drawing.Size(220, 22);
            this.txbMaMonHoc.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.formInputMH);
            this.panelControl1.Controls.Add(this.formMonhoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 451);
            this.panelControl1.TabIndex = 6;
            // 
            // FormMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 522);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMH";
            this.Text = "FormMH";
            this.Load += new System.EventHandler(this.FormMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formInputMH)).EndInit();
            this.formInputMH.ResumeLayout(false);
            this.formInputMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoTietLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa2;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS_SV1 dS_SV1;
        private DS_SV1TableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsLOPTINCHI;
        private DS_SV1TableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl formInputMH;
        private DevExpress.XtraEditors.SpinEdit speSoTietTH;
        private DevExpress.XtraEditors.SpinEdit speSoTietLT;
        private DevExpress.XtraEditors.TextEdit txbTenMonHoc;
        private DevExpress.XtraEditors.TextEdit txbMaMonHoc;
        private DevExpress.XtraGrid.GridControl formMonhoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraBars.BarButtonItem btnXoa1;
    }
}