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
    public partial class OrderM : DevComponents.DotNetBar.Office2007RibbonForm
    {
        List<Order> orders;
        public OrderM()
        {
            InitializeComponent();
        }

        private void DisplayGrid1()
        {
            orders = OrderDAO.getInstance().getAll();
            Grid1.DataSource = orders;
        }

        private void InsertRecordOrder()
        {
            try
            {
                DateTime time;
                if (string.IsNullOrEmpty(txtOrderTime.Text))
                {
                    time = DateTime.Now;
                }
                else
                {
                    time = txtOrderTime.Value;
                }
                Customer customer = new Customer(int.Parse(txtOrderCusID.Text), "", "");

                Order order = new Order(int.Parse(txtOrderID.Text), time, null, customer);
                OrderDAO.getInstance().Insert(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void InsertRecordOrderDetail()
        {
            try
            {
                int orderID = int.Parse(Grid1.CurrentRow.Cells["ID"].Value.ToString());
                int motorID = int.Parse(txtOrderMotorID.Text.ToString());

                OrderDAO.getInstance().InsertMotor(orderID, motorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

       private void DeleteRecordOrder()
        {
            try
            {
                Order order = new Order(int.Parse(txtOrderID.Text), default, null, null);
                OrderDAO.getInstance().Delete(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void DeleteRecordOrderDetail()
        {
            try
            {
                int orderID = int.Parse(Grid1.CurrentRow.Cells["ID"].Value.ToString());
                int motorID = int.Parse(Grid2.CurrentRow.Cells["ID"].Value.ToString());

                OrderDAO.getInstance().DeleteMotor(orderID, motorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void UpdateRecord()
        {
            try
            {
                DateTime time;
                if (string.IsNullOrEmpty(txtOrderTime.Text))
                {
                    time = DateTime.Now;
                }
                else
                {
                    time = txtOrderTime.Value;
                }
                Customer customer = new Customer(int.Parse(txtOrderCusID.Text), "", "");

                int id = int.Parse(Grid1.SelectedRows[0].Cells["ID"].Value.ToString());
                Order order = OrderDAO.getInstance().get(id);

                Motorbike motorbike = new Motorbike(int.Parse(txtOrderMotorID.Text), "", null, 0);
                order.Motorbikes.Add(motorbike);
                OrderDAO.getInstance().Update(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void LoadtxtOrderCusID()
        {
            List<Customer> customers = CustomerDAO.getInstance().getAll();
            txtOrderCusID.DataSource = customers;
            txtOrderCusID.DisplayMember = "id";
            txtOrderCusID.ValueMember = "id";

        }
        private void LoadtxtOrderMotorID()
        {
            List<Motorbike> motorbikes = MotorbikeDAO.getInstance().getAll();
            txtOrderMotorID.DataSource = motorbikes;
            txtOrderMotorID.DisplayMember = "ID";
            txtOrderMotorID.ValueMember = "ID";
        }

        private void btnOrderExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayTable(object sender, EventArgs e)
        {
            DisplayGrid1();
            LoadtxtOrderCusID();
            LoadtxtOrderMotorID();

           // "Thay đổi độ rộng cột"
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Time"].Width = 100;
            Grid1.Columns["Customer"].Width = 100;
            //Grid1.Columns["MaNX"].Width = 80;

            Grid1.Columns[2].HeaderText = "Customer ID";

        }

        private void btnOrderInsert_Click(object sender, EventArgs e)
        {
            InsertRecordOrder();
            DisplayGrid1();
        }
        private void btnODInsert_Click(object sender, EventArgs e)
        {
            InsertRecordOrderDetail();
            DisplayGrid2();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            DeleteRecordOrder();
            DisplayGrid1();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            DisplayGrid1();
        }

        private void btnODDelete_Click(object sender, EventArgs e)
        {
            DeleteRecordOrderDetail();
            DisplayGrid2();
        }

        private void DisplayGrid2()
        {
            DataGridViewRow row = Grid1.CurrentRow;
            txtOrderID.Text = row.Cells["ID"].Value.ToString();
            txtOrderTime.Text = row.Cells["Time"].Value.ToString();
            txtOrderCusID.Text = row.Cells["Customer"].Value.ToString();
            int k = Grid1.CurrentRow.Index;
            orders = OrderDAO.getInstance().getAll();
            List<Motorbike> motorbikes = orders[k].Motorbikes;
            Grid2.DataSource = motorbikes;
            Grid2.Columns["ID"].Width = 50;
            Grid2.Columns["Name"].Width = 50;
            Grid2.Columns["Manufacturer"].Width = 50;
            Grid2.Columns["Cost"].Width = 50;
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayGrid2();


        }
    }

}
