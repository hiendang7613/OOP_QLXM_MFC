namespace QLXM
{
    partial class ManuM
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
            this.txtManuName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtManuID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCusExit);
            this.groupPanel1.Controls.Add(this.cmd_nhaplai);
            this.groupPanel1.Controls.Add(this.cmd_update);
            this.groupPanel1.Controls.Add(this.cmd_xoa);
            this.groupPanel1.Controls.Add(this.btnCusAdd);
            this.groupPanel1.Controls.Add(this.txtManuName);
            this.groupPanel1.Controls.Add(this.txtManuID);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
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
            this.groupPanel1.Text = "Manage Manufacturer";
            // 
            // btnCusExit
            // 
            this.btnCusExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCusExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCusExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCusExit.Location = new System.Drawing.Point(578, 65);
            this.btnCusExit.Name = "btnCusExit";
            this.btnCusExit.Size = new System.Drawing.Size(100, 25);
            this.btnCusExit.TabIndex = 3;
            this.btnCusExit.Text = "Exit";
            this.btnCusExit.Click += new System.EventHandler(this.btnManuExit_Click);
            // 
            // cmd_nhaplai
            // 
            this.cmd_nhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_nhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_nhaplai.Location = new System.Drawing.Point(436, 65);
            this.cmd_nhaplai.Name = "cmd_nhaplai";
            this.cmd_nhaplai.Size = new System.Drawing.Size(100, 25);
            this.cmd_nhaplai.TabIndex = 4;
            this.cmd_nhaplai.Text = "Reset";
            this.cmd_nhaplai.Click += new System.EventHandler(this.btnManuReset_Click);
            // 
            // cmd_update
            // 
            this.cmd_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_update.Location = new System.Drawing.Point(293, 65);
            this.cmd_update.Name = "cmd_update";
            this.cmd_update.Size = new System.Drawing.Size(100, 25);
            this.cmd_update.TabIndex = 5;
            this.cmd_update.Text = "Edit";
            this.cmd_update.Click += new System.EventHandler(this.btnManuUpdate_Click);
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmd_xoa.Location = new System.Drawing.Point(152, 65);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(100, 25);
            this.cmd_xoa.TabIndex = 6;
            this.cmd_xoa.Text = "Remove";
            this.cmd_xoa.Click += new System.EventHandler(this.btnManuDelete_Click);
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
            this.btnCusAdd.TabIndex = 7;
            this.btnCusAdd.Text = "Add";
            this.btnCusAdd.Click += new System.EventHandler(this.btnManuInsert_Click);
            // 
            // txtManuName
            // 
            // 
            // 
            // 
            this.txtManuName.Border.Class = "TextBoxBorder";
            this.txtManuName.Location = new System.Drawing.Point(440, 25);
            this.txtManuName.Name = "txtManuName";
            this.txtManuName.Size = new System.Drawing.Size(240, 29);
            this.txtManuName.TabIndex = 1;
            // 
            // txtManuID
            // 
            // 
            // 
            // 
            this.txtManuID.Border.Class = "TextBoxBorder";
            this.txtManuID.Location = new System.Drawing.Point(40, 25);
            this.txtManuID.Name = "txtManuID";
            this.txtManuID.Size = new System.Drawing.Size(240, 29);
            this.txtManuID.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX3.Location = new System.Drawing.Point(390, 25);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Name";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(10, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 23);
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
            this.Grid1.Location = new System.Drawing.Point(10, 156);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.Size = new System.Drawing.Size(700, 210);
            this.Grid1.TabIndex = 1;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // ManuM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "ManuM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qlncc";
            this.Load += new System.EventHandler(this.LoadManuTable);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtManuName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtManuID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.ButtonX btnCusExit;
        private DevComponents.DotNetBar.ButtonX cmd_nhaplai;
        private DevComponents.DotNetBar.ButtonX cmd_update;
        private DevComponents.DotNetBar.ButtonX cmd_xoa;
        private DevComponents.DotNetBar.ButtonX btnCusAdd;
    }
}