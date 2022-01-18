namespace QLXM
{
    partial class OrderM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtOrderTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnOrderExit = new DevComponents.DotNetBar.ButtonX();
            this.btnOrderCal = new DevComponents.DotNetBar.ButtonX();
            this.btnODDelete = new DevComponents.DotNetBar.ButtonX();
            this.txtOrderMotorID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnODInsert = new DevComponents.DotNetBar.ButtonX();
            this.btnOrderUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnOrderDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnOrderInsert = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtOrderCusID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtOrderCusName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOrderMotorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOrderID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Grid2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtOrderTime);
            this.groupPanel1.Controls.Add(this.btnOrderExit);
            this.groupPanel1.Controls.Add(this.btnOrderCal);
            this.groupPanel1.Controls.Add(this.btnODDelete);
            this.groupPanel1.Controls.Add(this.txtOrderMotorID);
            this.groupPanel1.Controls.Add(this.btnODInsert);
            this.groupPanel1.Controls.Add(this.btnOrderUpdate);
            this.groupPanel1.Controls.Add(this.btnOrderDelete);
            this.groupPanel1.Controls.Add(this.btnOrderInsert);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtOrderCusID);
            this.groupPanel1.Controls.Add(this.txtOrderCusName);
            this.groupPanel1.Controls.Add(this.txtOrderMotorName);
            this.groupPanel1.Controls.Add(this.txtOrderID);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupPanel1.Location = new System.Drawing.Point(10, 15);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(698, 198);
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
            this.groupPanel1.Text = "Manage Order";
            // 
            // txtOrderTime
            // 
            // 
            // 
            // 
            this.txtOrderTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtOrderTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtOrderTime.ButtonDropDown.Visible = true;
            this.txtOrderTime.Location = new System.Drawing.Point(134, 42);
            // 
            // 
            // 
            this.txtOrderTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtOrderTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtOrderTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtOrderTime.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.txtOrderTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.txtOrderTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtOrderTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtOrderTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtOrderTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtOrderTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtOrderTime.MonthCalendar.TodayButtonVisible = true;
            this.txtOrderTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtOrderTime.Name = "txtOrderTime";
            this.txtOrderTime.Size = new System.Drawing.Size(100, 29);
            this.txtOrderTime.TabIndex = 9;
            // 
            // btnOrderExit
            // 
            this.btnOrderExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOrderExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOrderExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrderExit.Location = new System.Drawing.Point(565, 131);
            this.btnOrderExit.Name = "btnOrderExit";
            this.btnOrderExit.Size = new System.Drawing.Size(100, 25);
            this.btnOrderExit.TabIndex = 7;
            this.btnOrderExit.Text = "Exit";
            // 
            // btnOrderCal
            // 
            this.btnOrderCal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOrderCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrderCal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOrderCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrderCal.Location = new System.Drawing.Point(437, 131);
            this.btnOrderCal.Name = "btnOrderCal";
            this.btnOrderCal.Size = new System.Drawing.Size(100, 25);
            this.btnOrderCal.TabIndex = 8;
            this.btnOrderCal.Text = "Caculate";
            // 
            // btnODDelete
            // 
            this.btnODDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnODDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnODDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnODDelete.Location = new System.Drawing.Point(564, 91);
            this.btnODDelete.Name = "btnODDelete";
            this.btnODDelete.Size = new System.Drawing.Size(100, 25);
            this.btnODDelete.TabIndex = 3;
            this.btnODDelete.Text = "Remove";
            this.btnODDelete.Click += new System.EventHandler(this.btnODDelete_Click);
            // 
            // txtOrderMotorID
            // 
            this.txtOrderMotorID.DisplayMember = "Text";
            this.txtOrderMotorID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtOrderMotorID.FormattingEnabled = true;
            this.txtOrderMotorID.ItemHeight = 23;
            this.txtOrderMotorID.Location = new System.Drawing.Point(533, 4);
            this.txtOrderMotorID.Name = "txtOrderMotorID";
            this.txtOrderMotorID.Size = new System.Drawing.Size(100, 29);
            this.txtOrderMotorID.TabIndex = 6;
            // 
            // btnODInsert
            // 
            this.btnODInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnODInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnODInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnODInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnODInsert.Location = new System.Drawing.Point(437, 91);
            this.btnODInsert.Name = "btnODInsert";
            this.btnODInsert.Size = new System.Drawing.Size(100, 25);
            this.btnODInsert.TabIndex = 4;
            this.btnODInsert.Text = "Add";
            this.btnODInsert.Click += new System.EventHandler(this.btnODInsert_Click);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOrderUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrderUpdate.Location = new System.Drawing.Point(252, 110);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnOrderUpdate.TabIndex = 3;
            this.btnOrderUpdate.Text = "Edit";
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOrderDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrderDelete.Location = new System.Drawing.Point(252, 65);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(100, 25);
            this.btnOrderDelete.TabIndex = 4;
            this.btnOrderDelete.Text = "Remove";
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderInsert
            // 
            this.btnOrderInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOrderInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrderInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOrderInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrderInsert.Location = new System.Drawing.Point(252, 22);
            this.btnOrderInsert.Name = "btnOrderInsert";
            this.btnOrderInsert.Size = new System.Drawing.Size(100, 25);
            this.btnOrderInsert.TabIndex = 5;
            this.btnOrderInsert.Text = "Add";
            this.btnOrderInsert.Click += new System.EventHandler(this.btnOrderInsert_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX9.Location = new System.Drawing.Point(451, 4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 2;
            this.labelX9.Text = "Motor ID";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX11.Location = new System.Drawing.Point(23, 127);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(105, 23);
            this.labelX11.TabIndex = 2;
            this.labelX11.Text = "Customer Name";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX8.Location = new System.Drawing.Point(23, 85);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 2;
            this.labelX8.Text = "Customer ID";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX5.Location = new System.Drawing.Point(451, 48);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Motor Name";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX2.Location = new System.Drawing.Point(23, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Time";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(23, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ID";
            // 
            // txtOrderCusID
            // 
            this.txtOrderCusID.DisplayMember = "Text";
            this.txtOrderCusID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtOrderCusID.FormattingEnabled = true;
            this.txtOrderCusID.ItemHeight = 23;
            this.txtOrderCusID.Location = new System.Drawing.Point(134, 85);
            this.txtOrderCusID.Name = "txtOrderCusID";
            this.txtOrderCusID.Size = new System.Drawing.Size(100, 29);
            this.txtOrderCusID.TabIndex = 1;
            // 
            // txtOrderCusName
            // 
            // 
            // 
            // 
            this.txtOrderCusName.Border.Class = "TextBoxBorder";
            this.txtOrderCusName.Location = new System.Drawing.Point(134, 127);
            this.txtOrderCusName.Name = "txtOrderCusName";
            this.txtOrderCusName.ReadOnly = true;
            this.txtOrderCusName.Size = new System.Drawing.Size(100, 29);
            this.txtOrderCusName.TabIndex = 0;
            // 
            // txtOrderMotorName
            // 
            // 
            // 
            // 
            this.txtOrderMotorName.Border.Class = "TextBoxBorder";
            this.txtOrderMotorName.Location = new System.Drawing.Point(533, 46);
            this.txtOrderMotorName.Name = "txtOrderMotorName";
            this.txtOrderMotorName.ReadOnly = true;
            this.txtOrderMotorName.Size = new System.Drawing.Size(100, 29);
            this.txtOrderMotorName.TabIndex = 0;
            // 
            // txtOrderID
            // 
            // 
            // 
            // 
            this.txtOrderID.Border.Class = "TextBoxBorder";
            this.txtOrderID.Location = new System.Drawing.Point(134, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 29);
            this.txtOrderID.TabIndex = 0;
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
            this.Grid1.Location = new System.Drawing.Point(10, 220);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(355, 180);
            this.Grid1.TabIndex = 1;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // Grid2
            // 
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Grid2.Location = new System.Drawing.Point(371, 220);
            this.Grid2.Name = "Grid2";
            this.Grid2.Size = new System.Drawing.Size(337, 180);
            this.Grid2.TabIndex = 2;
            // 
            // OrderM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 405);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "OrderM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qlhdbh";
            this.Load += new System.EventHandler(this.DisplayTable);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrderID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtOrderCusID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrderCusName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrderMotorName;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
        private DevComponents.DotNetBar.ButtonX btnOrderUpdate;
        private DevComponents.DotNetBar.ButtonX btnOrderDelete;
        private DevComponents.DotNetBar.ButtonX btnOrderInsert;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtOrderMotorID;
        private DevComponents.DotNetBar.ButtonX btnODDelete;
        private DevComponents.DotNetBar.ButtonX btnODInsert;
        private DevComponents.DotNetBar.ButtonX btnOrderExit;
        private DevComponents.DotNetBar.ButtonX btnOrderCal;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtOrderTime;
    }
}