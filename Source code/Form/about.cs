using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLXM
{
    public partial class about : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public about()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}