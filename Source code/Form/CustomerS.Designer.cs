namespace QLXM
{
    partial class CustomerS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmd_tim_ten_diachi = new DevComponents.DotNetBar.ButtonX();
            this.ratingStar1 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Grid1.Location = new System.Drawing.Point(16, 190);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(690, 178);
            this.Grid1.TabIndex = 0;
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
            this.txtID.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX2.Location = new System.Drawing.Point(10, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "ID";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtID);
            this.groupPanel2.Controls.Add(this.txtPhone);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtFullname);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.cmd_tim_ten_diachi);
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
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "Search Customer";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Location = new System.Drawing.Point(520, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 29);
            this.txtPhone.TabIndex = 2;
            // 
            // txtFullname
            // 
            // 
            // 
            // 
            this.txtFullname.Border.Class = "TextBoxBorder";
            this.txtFullname.Location = new System.Drawing.Point(290, 25);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(150, 29);
            this.txtFullname.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX3.Location = new System.Drawing.Point(480, 25);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Phone";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(230, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Fullname";
            // 
            // cmd_tim_ten_diachi
            // 
            this.cmd_tim_ten_diachi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_tim_ten_diachi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_tim_ten_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cmd_tim_ten_diachi.Location = new System.Drawing.Point(245, 70);
            this.cmd_tim_ten_diachi.Name = "cmd_tim_ten_diachi";
            this.cmd_tim_ten_diachi.Size = new System.Drawing.Size(200, 23);
            this.cmd_tim_ten_diachi.TabIndex = 0;
            this.cmd_tim_ten_diachi.Text = "Search";
            this.cmd_tim_ten_diachi.Click += new System.EventHandler(this.Search);
            // 
            // ratingStar1
            // 
            this.ratingStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratingStar1.Location = new System.Drawing.Point(16, 151);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.Size = new System.Drawing.Size(218, 23);
            this.ratingStar1.TabIndex = 3;
            this.ratingStar1.Text = "Kết Quả Tìm Kiếm";
            this.ratingStar1.TextColor = System.Drawing.Color.Empty;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(596, 151);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(105, 23);
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Exit";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // CustomerS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.ratingStar1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.Grid1);
            this.Name = "CustomerS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tkkhach";
            this.Load += new System.EventHandler(this.CustomerS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX cmd_tim_ten_diachi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}