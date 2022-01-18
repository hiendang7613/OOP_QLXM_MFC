namespace QLXM
{
    partial class MotorS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmd_tim_ten_diachi = new DevComponents.DotNetBar.ButtonX();
            this.cbManuName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ratingStar1 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.cmd_tim_ten_diachi);
            this.groupPanel2.Controls.Add(this.cbManuName);
            this.groupPanel2.Controls.Add(this.txtID);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtName);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupPanel2.Location = new System.Drawing.Point(10, 15);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(690, 130);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Search Motorbike";
            // 
            // cmd_tim_ten_diachi
            // 
            this.cmd_tim_ten_diachi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_tim_ten_diachi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_tim_ten_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cmd_tim_ten_diachi.Location = new System.Drawing.Point(245, 70);
            this.cmd_tim_ten_diachi.Name = "cmd_tim_ten_diachi";
            this.cmd_tim_ten_diachi.Size = new System.Drawing.Size(200, 23);
            this.cmd_tim_ten_diachi.TabIndex = 8;
            this.cmd_tim_ten_diachi.Text = "Search";
            this.cmd_tim_ten_diachi.Click += new System.EventHandler(this.Search);
            // 
            // cbManuName
            // 
            this.cbManuName.DisplayMember = "Text";
            this.cbManuName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbManuName.FormattingEnabled = true;
            this.cbManuName.ItemHeight = 23;
            this.cbManuName.Location = new System.Drawing.Point(530, 25);
            this.cbManuName.Name = "cbManuName";
            this.cbManuName.Size = new System.Drawing.Size(150, 29);
            this.cbManuName.TabIndex = 7;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Location = new System.Drawing.Point(30, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 29);
            this.txtID.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX4.Location = new System.Drawing.Point(10, 25);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(105, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "ID";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Location = new System.Drawing.Point(240, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 29);
            this.txtName.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX3.Location = new System.Drawing.Point(200, 25);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Name";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(410, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(122, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Manufacturer Name";
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Grid1.Location = new System.Drawing.Point(16, 190);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(690, 178);
            this.Grid1.TabIndex = 1;
            // 
            // ratingStar1
            // 
            this.ratingStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratingStar1.Location = new System.Drawing.Point(16, 151);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.Size = new System.Drawing.Size(225, 23);
            this.ratingStar1.TabIndex = 2;
            this.ratingStar1.Text = "Kết Quả Tìm Kiếm";
            this.ratingStar1.TextColor = System.Drawing.Color.Empty;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(596, 151);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(105, 23);
            this.buttonX3.TabIndex = 0;
            this.buttonX3.Text = "Exit";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // MotorS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 376);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.ratingStar1);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "MotorS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tkncc";
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbManuName;
        private DevComponents.DotNetBar.ButtonX cmd_tim_ten_diachi;
    }
}