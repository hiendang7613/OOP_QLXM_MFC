using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM
{
    public partial class main :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }

        // Kiểm tra sự tồn tại của form trước khi gọi 
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        // End Kiểm tra sự tồn tại của form.

 
        private void btnCustomerM_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("CustomerM") == false)
            {
                CustomerM form = new CustomerM();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnManuM_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ManuM") == false)
            {
                ManuM form = new ManuM();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnMotorM_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("MotorM") == false)
            {
                MotorM form = new MotorM();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnOrderM_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("OrderM") == false)
            {
                OrderM form = new OrderM();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnCustomerS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("CustomerS") == false)
            {
                CustomerS form = new CustomerS();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnManuS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ManuS") == false)
            {
                ManuS form = new ManuS();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }


        private void btnOrderS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("OrderS") == false)
            {
                OrderS form = new OrderS();
                form.MdiParent = this;
                lblBackground.Visible = false;
                form.Show();
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("about") == false)
            {
                about frmabout = new about();
                frmabout.MdiParent = this;
                lblBackground.Visible = false;
                frmabout.Show();
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMotorS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("MotorS") == false)
            {
                MotorS frmabout = new MotorS();
                frmabout.MdiParent = this;
                lblBackground.Visible = false;
                frmabout.Show();
            }
        }

    }
}
