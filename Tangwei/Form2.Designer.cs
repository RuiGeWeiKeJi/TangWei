namespace Tangwei
{
    partial class Qudan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.IBB013 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB041 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBB006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IAB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1156, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.IBB013,
            this.IBB001,
            this.IBB002,
            this.IBB003,
            this.IBB004,
            this.IBB041,
            this.IBB005,
            this.IBB006,
            this.IAB003});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 30;
            // 
            // check
            // 
            this.check.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.check.AppearanceCell.Options.UseFont = true;
            this.check.AppearanceCell.Options.UseTextOptions = true;
            this.check.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.check.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.check.AppearanceHeader.Options.UseFont = true;
            this.check.AppearanceHeader.Options.UseTextOptions = true;
            this.check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.check.Caption = "选择";
            this.check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.check.FieldName = "check";
            this.check.Name = "check";
            this.check.Visible = true;
            this.check.VisibleIndex = 0;
            this.check.Width = 51;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "选择";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // IBB013
            // 
            this.IBB013.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB013.AppearanceCell.Options.UseFont = true;
            this.IBB013.AppearanceCell.Options.UseTextOptions = true;
            this.IBB013.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB013.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB013.AppearanceHeader.Options.UseFont = true;
            this.IBB013.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB013.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB013.Caption = "需求日期";
            this.IBB013.DisplayFormat.FormatString = "d";
            this.IBB013.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.IBB013.FieldName = "IBB013";
            this.IBB013.Name = "IBB013";
            this.IBB013.Visible = true;
            this.IBB013.VisibleIndex = 1;
            this.IBB013.Width = 124;
            // 
            // IBB001
            // 
            this.IBB001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB001.AppearanceCell.Options.UseFont = true;
            this.IBB001.AppearanceCell.Options.UseTextOptions = true;
            this.IBB001.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB001.AppearanceHeader.Options.UseFont = true;
            this.IBB001.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB001.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB001.Caption = "前置单号";
            this.IBB001.FieldName = "IBB001";
            this.IBB001.Name = "IBB001";
            this.IBB001.Visible = true;
            this.IBB001.VisibleIndex = 2;
            this.IBB001.Width = 124;
            // 
            // IBB002
            // 
            this.IBB002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB002.AppearanceCell.Options.UseFont = true;
            this.IBB002.AppearanceCell.Options.UseTextOptions = true;
            this.IBB002.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB002.AppearanceHeader.Options.UseFont = true;
            this.IBB002.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB002.Caption = "序号";
            this.IBB002.FieldName = "IBB002";
            this.IBB002.Name = "IBB002";
            this.IBB002.Visible = true;
            this.IBB002.VisibleIndex = 3;
            this.IBB002.Width = 124;
            // 
            // IBB003
            // 
            this.IBB003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB003.AppearanceCell.Options.UseFont = true;
            this.IBB003.AppearanceCell.Options.UseTextOptions = true;
            this.IBB003.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB003.AppearanceHeader.Options.UseFont = true;
            this.IBB003.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB003.Caption = "品号";
            this.IBB003.FieldName = "IBB003";
            this.IBB003.Name = "IBB003";
            this.IBB003.Visible = true;
            this.IBB003.VisibleIndex = 4;
            this.IBB003.Width = 124;
            // 
            // IBB004
            // 
            this.IBB004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB004.AppearanceCell.Options.UseFont = true;
            this.IBB004.AppearanceCell.Options.UseTextOptions = true;
            this.IBB004.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB004.AppearanceHeader.Options.UseFont = true;
            this.IBB004.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB004.Caption = "品名";
            this.IBB004.FieldName = "IBB004";
            this.IBB004.Name = "IBB004";
            this.IBB004.Visible = true;
            this.IBB004.VisibleIndex = 5;
            this.IBB004.Width = 124;
            // 
            // IBB041
            // 
            this.IBB041.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB041.AppearanceCell.Options.UseFont = true;
            this.IBB041.AppearanceCell.Options.UseTextOptions = true;
            this.IBB041.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB041.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB041.AppearanceHeader.Options.UseFont = true;
            this.IBB041.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB041.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB041.Caption = "规格";
            this.IBB041.FieldName = "IBB041";
            this.IBB041.Name = "IBB041";
            this.IBB041.Visible = true;
            this.IBB041.VisibleIndex = 6;
            this.IBB041.Width = 124;
            // 
            // IBB005
            // 
            this.IBB005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB005.AppearanceCell.Options.UseFont = true;
            this.IBB005.AppearanceCell.Options.UseTextOptions = true;
            this.IBB005.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB005.AppearanceHeader.Options.UseFont = true;
            this.IBB005.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB005.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB005.Caption = "交易单位";
            this.IBB005.FieldName = "IBB005";
            this.IBB005.Name = "IBB005";
            this.IBB005.Visible = true;
            this.IBB005.VisibleIndex = 7;
            this.IBB005.Width = 124;
            // 
            // IBB006
            // 
            this.IBB006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB006.AppearanceCell.Options.UseFont = true;
            this.IBB006.AppearanceCell.Options.UseTextOptions = true;
            this.IBB006.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.IBB006.AppearanceHeader.Options.UseFont = true;
            this.IBB006.AppearanceHeader.Options.UseTextOptions = true;
            this.IBB006.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IBB006.Caption = "交易数量";
            this.IBB006.FieldName = "IBB006";
            this.IBB006.Name = "IBB006";
            this.IBB006.Visible = true;
            this.IBB006.VisibleIndex = 8;
            this.IBB006.Width = 125;
            // 
            // IAB003
            // 
            this.IAB003.Caption = "时间";
            this.IAB003.FieldName = "IAB003";
            this.IAB003.Name = "IAB003";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(843, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "取消全选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(961, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(1079, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(725, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "全选";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Qudan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 494);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Qudan";
            this.Text = "取单";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IBB013;
        private DevExpress.XtraGrid.Columns.GridColumn IBB001;
        private DevExpress.XtraGrid.Columns.GridColumn IBB003;
        private DevExpress.XtraGrid.Columns.GridColumn IBB004;
        private DevExpress.XtraGrid.Columns.GridColumn IBB041;
        private DevExpress.XtraGrid.Columns.GridColumn IBB005;
        private DevExpress.XtraGrid.Columns.GridColumn IBB006;
        private DevExpress.XtraGrid.Columns.GridColumn IAB003;
        private DevExpress.XtraGrid.Columns.GridColumn IBB002;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress . XtraGrid . GridControl gridControl1;
    }
}