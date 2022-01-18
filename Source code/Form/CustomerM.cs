using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using QLXM.DAO;
using QLXM.DTO;

namespace QLXM
{
    public partial class CustomerM : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public CustomerM()
        {
            InitializeComponent();
        }


        private void DisplayTable()
        {
            List<Customer> customers = CustomerDAO.getInstance().getAll();
            Grid1.DataSource = customers;
        }

        private void InsertRecord()
        {
            try
            {
                Customer customer = new Customer(int.Parse(txtCusID.Text), txtCusName.Text, txtCusPhone.Text);
                CustomerDAO.getInstance().Insert(customer);
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
                Customer customer = new Customer(int.Parse(txtCusID.Text), txtCusName.Text, txtCusPhone.Text);
                CustomerDAO.getInstance().Update(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        private void DeleteRecord()
        {
            try
            {
                Customer customer = new Customer(int.Parse(txtCusID.Text), txtCusName.Text, txtCusPhone.Text);
                CustomerDAO.getInstance().Delete(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void LoadCusTable(object sender, EventArgs e)
        {
            DisplayTable();
            //#region "Thay đổi độ rộng cột"
            Grid1.Columns["Id"].Width = 40;
            Grid1.Columns["Fullname"].Width = 130;
            Grid1.Columns["Phone"].Width = 120;
        }

        private void btnCusExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCusInsert_Click(object sender, EventArgs e)
        {
            InsertRecord();
            DisplayTable();
        }

        private void btnCusReset_Click(object sender, EventArgs e)
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtCusPhone.Text = "";
        }

        private void btnCusUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            DisplayTable();
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayTable();
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grid1.CurrentRow;
            txtCusID.Text = row.Cells["ID"].Value.ToString();
            txtCusName.Text = row.Cells["Fullname"].Value.ToString();
            txtCusPhone.Text = row.Cells["Phone"].Value.ToString();
        }
    }
}
