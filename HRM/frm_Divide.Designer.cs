
namespace HRM
{
    partial class frm_Divide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Divide));
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_paymentEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_PaymentDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_paymentadd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.Caption = "gridColumn1";
            this.tileViewColumn1.FieldName = "Name";
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 693);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 693);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1248, 634);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1,
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn1});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.IndentBetweenGroups = 58;
            this.tileView1.OptionsTiles.IndentBetweenItems = 18;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(24);
            this.tileView1.OptionsTiles.RowCount = 5;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 15D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement1.Appearance.Selected.BackColor = System.Drawing.Color.Lime;
            tileViewItemElement1.Appearance.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            tileViewItemElement1.Appearance.Selected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            tileViewItemElement1.Appearance.Selected.Options.UseBackColor = true;
            tileViewItemElement1.Appearance.Selected.Options.UseBorderColor = true;
            tileViewItemElement1.Column = this.tileViewColumn1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.StretchHorizontal = true;
            tileViewItemElement1.StretchVertical = true;
            tileViewItemElement1.Text = "tileViewColumn1";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_paymentEdit);
            this.panel3.Controls.Add(this.btn_PaymentDelete);
            this.panel3.Controls.Add(this.btn_paymentadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 59);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "الصفحة الخاصة بأضافة الفوج ";
            // 
            // btn_paymentEdit
            // 
            this.btn_paymentEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_paymentEdit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_paymentEdit.Appearance.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentEdit.Appearance.Options.UseBackColor = true;
            this.btn_paymentEdit.Appearance.Options.UseFont = true;
            this.btn_paymentEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentEdit.ImageOptions.Image")));
            this.btn_paymentEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_paymentEdit.Location = new System.Drawing.Point(4, 5);
            this.btn_paymentEdit.Name = "btn_paymentEdit";
            this.btn_paymentEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_paymentEdit.Size = new System.Drawing.Size(46, 51);
            this.btn_paymentEdit.TabIndex = 12;
            this.btn_paymentEdit.Text = " ";
            this.btn_paymentEdit.Click += new System.EventHandler(this.btn_paymentEdit_Click);
            // 
            // btn_PaymentDelete
            // 
            this.btn_PaymentDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_PaymentDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btn_PaymentDelete.Appearance.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PaymentDelete.Appearance.Options.UseBackColor = true;
            this.btn_PaymentDelete.Appearance.Options.UseFont = true;
            this.btn_PaymentDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PaymentDelete.ImageOptions.Image")));
            this.btn_PaymentDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_PaymentDelete.Location = new System.Drawing.Point(56, 5);
            this.btn_PaymentDelete.Name = "btn_PaymentDelete";
            this.btn_PaymentDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_PaymentDelete.Size = new System.Drawing.Size(46, 51);
            this.btn_PaymentDelete.TabIndex = 11;
            this.btn_PaymentDelete.Text = " ";
            this.btn_PaymentDelete.Click += new System.EventHandler(this.btn_PaymentDelete_Click);
            // 
            // btn_paymentadd
            // 
            this.btn_paymentadd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_paymentadd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_paymentadd.Appearance.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentadd.Appearance.Options.UseBackColor = true;
            this.btn_paymentadd.Appearance.Options.UseFont = true;
            this.btn_paymentadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentadd.ImageOptions.Image")));
            this.btn_paymentadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_paymentadd.Location = new System.Drawing.Point(108, 5);
            this.btn_paymentadd.Name = "btn_paymentadd";
            this.btn_paymentadd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_paymentadd.Size = new System.Drawing.Size(46, 51);
            this.btn_paymentadd.TabIndex = 10;
            this.btn_paymentadd.Text = " ";
            this.btn_paymentadd.Click += new System.EventHandler(this.btn_paymentadd_Click);
            // 
            // frm_Divide
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Divide";
            this.Size = new System.Drawing.Size(1248, 693);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_paymentEdit;
        public DevExpress.XtraEditors.SimpleButton btn_PaymentDelete;
        public DevExpress.XtraEditors.SimpleButton btn_paymentadd;
    }
}
