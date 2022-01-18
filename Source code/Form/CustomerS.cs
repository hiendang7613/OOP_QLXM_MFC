using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using QLXM.DTO;
using QLXM.DAO;

namespace QLXM
{
    public partial class CustomerS : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public CustomerS()
        {
            InitializeComponent();
            List<Customer> customers = CustomerDAO.getInstance().getAll();
            Grid1.DataSource = customers;
        }

        private void Search(object sender, EventArgs e) // Tìm kiếm dữ liệu theo mã
        {
            int ID=0;
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                ID = int.Parse(txtID.Text);
            }
            string Fullname = txtFullname.Text;
            string Phone = txtPhone.Text;
            Customer customer = new Customer(ID, Fullname, Phone);
            List<Customer> customers = CustomerDAO.getInstance().get(customer);

            Grid1.DataSource = customers;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Fullname"].Width = 200;
            Grid1.Columns["Phone"].Width = 100;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerS_Load(object sender, EventArgs e)
        {

        }


    }
}
