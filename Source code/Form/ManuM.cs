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
    public partial class ManuM : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public ManuM()
        {
            InitializeComponent();
        }

        private void DisplayTable()
        {
            List<Manufacturer> manufacturers = ManufacturerDAO.getInstance().getAll();
            Grid1.DataSource = manufacturers;
        }

        private void InsertRecord()
        {
            try
            {
                Manufacturer manufacturer = new Manufacturer(int.Parse(txtManuID.Text), txtManuName.Text);
                ManufacturerDAO.getInstance().Insert(manufacturer);
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
                Manufacturer manufacturer = new Manufacturer(int.Parse(txtManuID.Text), txtManuName.Text);
                ManufacturerDAO.getInstance().Update(manufacturer);
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
                Manufacturer manufacturer = new Manufacturer(int.Parse(txtManuID.Text), txtManuName.Text);
                ManufacturerDAO.getInstance().Delete(manufacturer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void LoadManuTable(object sender, EventArgs e)
        {
            DisplayTable();
            // "Thay đổi độ rộng cột"
            Grid1.Columns["Id"].Width = 100;
            Grid1.Columns["Name"].Width = 200;
        }

        private void btnManuInsert_Click(object sender, EventArgs e)
        {
            InsertRecord();
            DisplayTable();
        }

        private void btnManuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManuDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayTable();
        }

        private void btnManuUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            DisplayTable();
        }

        private void btnManuReset_Click(object sender, EventArgs e)
        {
            txtManuID.Text = "";
            txtManuName.Text = "";
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grid1.CurrentRow;
            txtManuID.Text = row.Cells["ID"].Value.ToString();
            txtManuName.Text = row.Cells["Name"].Value.ToString();
        }
    }
}
