namespace QLXM
{
    partial class ManuS
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.Controls.Add(this.txtName);
            this.groupPanel2.Controls.Add(this.txtID);
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
            this.groupPanel2.Text = "Search Manufacturer";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.buttonX2.Location = new System.Drawing.Point(245, 70);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(200, 23);
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Tìm Kiếm";
            this.buttonX2.Click += new System.EventHandler(this.Search);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Location = new System.Drawing.Point(440, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Location = new System.Drawing.Point(30, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(240, 29);
            this.txtID.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX3.Location = new System.Drawing.Point(390, 25);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Name";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(10, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ID";
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
            this.buttonX3.Location = new System.Drawing.Point(601, 151);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(105, 23);
            this.buttonX3.TabIndex = 0;
            this.buttonX3.Text = "Exit";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // ManuS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 389);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.ratingStar1);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "ManuS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tkncc";
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}