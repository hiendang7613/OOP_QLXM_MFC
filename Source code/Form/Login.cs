using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLXM
{
    public partial class Login : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Login()
        {
            InitializeComponent();
        }
        
        public bool CheckLogin(string name, string pass)
        {
            return true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txt_user.Text, txt_pass.Text))
            {
                main frmmain = new main();
                frmmain.Show();
               
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
