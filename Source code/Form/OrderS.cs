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
    public partial class OrderS : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public OrderS()
        {
            InitializeComponent();
            List<Order> orders = OrderDAO.getInstance().getAll();
            Grid1.DataSource = orders;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Time"].Width = 200;
            Grid1.Columns["Customer"].Width = 200;
        }

        private void Search(object sender, EventArgs e) // Tìm kiếm dữ liệu theo mã
        {
            int ID = 0;
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                ID = int.Parse(txtID.Text);
            }
            int CusID = 0;
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                CusID = int.Parse(txtCusID.Text);
            }
            DateTime Time = cbTime.Value;
            Customer customer = new Customer(CusID, "", "");
            Order order = new Order(ID, Time, null, customer);
            List<Order> orders = OrderDAO.getInstance().get(order);

            Grid1.DataSource = orders;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Time"].Width = 200;
            Grid1.Columns["Customer"].Width = 200;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
