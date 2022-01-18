namespace QLXM
{
    partial class CustomerM
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCusExit = new DevComponents.DotNetBar.ButtonX();
            this.cmd_nhaplai = new DevComponents.DotNetBar.ButtonX();
            this.cmd_update = new DevComponents.DotNetBar.ButtonX();
            this.cmd_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btnCusAdd = new DevComponents.DotNetBar.ButtonX();
            this.txtCusPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCusName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCusID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCusExit);
            this.groupPanel1.Controls.Add(this.cmd_nhaplai);
            this.groupPanel1.Controls.Add(this.cmd_update);
            this.groupPanel1.Controls.Add(this.cmd_xoa);
            this.groupPanel1.Controls.Add(this.btnCusAdd);
            this.groupPanel1.Controls.Add(this.txtCusPhone);
            this.groupPanel1.Controls.Add(this.txtCusName);
            this.groupPanel1.Controls.Add(this.txtCusID);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel1.Location = new System.Drawing.Point(10, 15);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(700, 135);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Manage Customer";
            // 
            // btnCusExit
            // 
            this.btnCusExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCusExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCusExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCusExit.Location = new System.Drawing.Point(580, 65);
            this.btnCusExit.Name = "btnCusExit";
            this.btnCusExit.Size = new System.Drawing.Size(100, 25);
            this.btnCusExit.TabIndex = 2;
            this.btnCusExit.Text = "Exit";
            this.btnCusExit.Click += new System.EventHandler(this.btnCusExit_Click);
            // 
            // cmd_nhaplai
            // 
            this.cmd_nhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_nhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_nhaplai.Location = new System.Drawing.Point(438, 65);
            this.cmd_nhaplai.Name = "cmd_nhaplai";
            this.cmd_nhaplai.Size = new System.Drawing.Size(100, 25);
            this.cmd_nhaplai.TabIndex = 2;
            this.cmd_nhaplai.Text = "Reset";
            this.cmd_nhaplai.Click += new System.EventHandler(this.btnCusReset_Click);
            // 
            // cmd_update
            // 
            this.cmd_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_update.Location = new System.Drawing.Point(295, 65);
            this.cmd_update.Name = "cmd_update";
            this.cmd_update.Size = new System.Drawing.Size(100, 25);
            this.cmd_update.TabIndex = 2;
            this.cmd_update.Text = "Edit";
            this.cmd_update.Click += new System.EventHandler(this.btnCusUpdate_Click);
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_xoa.Location = new System.Drawing.Point(152, 65);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(100, 25);
            this.cmd_xoa.TabIndex = 2;
            this.cmd_xoa.Text = "Remove";
            this.cmd_xoa.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // btnCusAdd
            // 
            this.btnCusAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCusAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCusAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCusAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCusAdd.Location = new System.Drawing.Point(10, 65);
            this.btnCusAdd.Name = "btnCusAdd";
            this.btnCusAdd.Size = new System.Drawing.Size(100, 25);
            this.btnCusAdd.TabIndex = 2;
            this.btnCusAdd.Text = "Add";
            this.btnCusAdd.Click += new System.EventHandler(this.btnCusInsert_Click);
            // 
            // txtCusPhone
            // 
            // 
            // 
            // 
            this.txtCusPhone.Border.Class = "TextBoxBorder";
            this.txtCusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusPhone.Location = new System.Drawing.Point(540, 25);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(150, 22);
            this.txtCusPhone.TabIndex = 1;
            // 
            // txtCusName
            // 
            // 
            // 
            // 
            this.txtCusName.Border.Class = "TextBoxBorder";
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusName.Location = new System.Drawing.Point(290, 25);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCusName.Size = new System.Drawing.Size(150, 22);
            this.txtCusName.TabIndex = 1;
            // 
            // txtCusID
            // 
            // 
            // 
            // 
            this.txtCusID.Border.Class = "TextBoxBorder";
            this.txtCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusID.Location = new System.Drawing.Point(30, 25);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(150, 22);
            this.txtCusID.TabIndex = 1;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(495, 25);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(85, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Phone";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(230, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Fullname";
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.Location = new System.Drawing.Point(10, 25);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(100, 25);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "ID";
            // 
            // Grid1
            // 
            this.Grid1.BackgroundColor = System.Drawing.Color.PowderBlue;
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
            this.Grid1.Location = new System.Drawing.Point(10, 156);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(700, 210);
            this.Grid1.TabIndex = 1;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // CustomerM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 375);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "CustomerM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "qlkh";
            this.Load += new System.EventHandler(this.LoadCusTable);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCusPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCusName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX cmd_update;
        private DevComponents.DotNetBar.ButtonX cmd_xoa;
        private DevComponents.DotNetBar.ButtonX btnCusAdd;
        private DevComponents.DotNetBar.ButtonX btnCusExit;
        private DevComponents.DotNetBar.ButtonX cmd_nhaplai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCusID;
        private DevComponents.DotNetBar.LabelX labelX6;

    }
}