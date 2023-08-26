
namespace QLDSV_TC
{
    partial class ChonGV
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
            this.dS_SV1 = new QLDSV_TC.DS_SV1();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSV_TC.DS_SV1TableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCHAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dS_SV1;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(1396, 220);
            this.gIANGVIENGridControl.TabIndex = 1;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAKHOA,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colHOCHAM,
            this.colCHUYENMON});
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 1;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 4;
            // 
            // colHOCHAM
            // 
            this.colHOCHAM.FieldName = "HOCHAM";
            this.colHOCHAM.Name = "colHOCHAM";
            this.colHOCHAM.Visible = true;
            this.colHOCHAM.VisibleIndex = 5;
            // 
            // colCHUYENMON
            // 
            this.colCHUYENMON.FieldName = "CHUYENMON";
            this.colCHUYENMON.Name = "colCHUYENMON";
            this.colCHUYENMON.Visible = true;
            this.colCHUYENMON.VisibleIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "CHỌN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChonGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Name = "ChonGV";
            this.Text = "ChonGV";
            this.Load += new System.EventHandler(this.ChonGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_SV1 dS_SV1;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DS_SV1TableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCHAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYENMON;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}