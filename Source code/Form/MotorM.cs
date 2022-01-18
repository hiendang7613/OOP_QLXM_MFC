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
    public partial class MotorM : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public MotorM()
        {
            InitializeComponent();
        }

        private void DisplayTable(object sender, EventArgs e)
        {
            DisplayTable();
            LoadCombobox();

            Grid1.Columns["ID"].Width = 40;
            Grid1.Columns["Name"].Width = 110;
            Grid1.Columns["Manufacturer"].Width = 130;
            Grid1.Columns["Cost"].Width = 130;
        }



        private void DisplayTable()
        {
            List<Motorbike> motorbike = MotorbikeDAO.getInstance().getAll();
            Grid1.DataSource = motorbike;
        }
      
        private void InsertRecord()
        {
            try
            {
                Manufacturer manufacturer = new Manufacturer(0, cbMotorManuName.Text);
                manufacturer = ManufacturerDAO.getInstance().get(manufacturer)[0];

                Motorbike motorbike = new Motorbike(int.Parse(txtMotorID.Text), txtMotorName.Text, manufacturer, int.Parse(txtMotorCost.Text));
                MotorbikeDAO.getInstance().Insert(motorbike);
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
                Manufacturer manufacturer = new Manufacturer(0, cbMotorManuName.Text);
                manufacturer = ManufacturerDAO.getInstance().get(manufacturer)[0];

                Motorbike motorbike = new Motorbike(int.Parse(txtMotorID.Text), txtMotorName.Text, manufacturer, int.Parse(txtMotorCost.Text));
                MotorbikeDAO.getInstance().Update(motorbike);
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
                Motorbike motorbike = new Motorbike(int.Parse(txtMotorID.Text), txtMotorName.Text, null, int.Parse(txtMotorCost.Text));
                MotorbikeDAO.getInstance().Delete(motorbike);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void LoadCombobox()
        {
            List<Manufacturer> manufacturers = ManufacturerDAO.getInstance().getAll();
            cbMotorManuName.DataSource = manufacturers;
            cbMotorManuName.DisplayMember = "Name";
            cbMotorManuName.ValueMember = "Name";

        }


        private void btnMotorInsert_Click(object sender, EventArgs e)
        {
            InsertRecord();
            DisplayTable();
        }

        private void btnMotorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMotorUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            DisplayTable();
        }

        private void btnMotorDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayTable();
        }

        private void btnMotorReset_Click(object sender, EventArgs e)
        {
            txtMotorCost.Text = "";
            txtMotorName.Text = "";
            txtMotorID.Text = "";
            cbMotorManuName.Text = "";
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grid1.CurrentRow;
            txtMotorID.Text = row.Cells["ID"].Value.ToString();
            txtMotorName.Text = row.Cells["Name"].Value.ToString();
            txtMotorCost.Text = row.Cells["Manufacturer"].Value.ToString();
            cbMotorManuName.Text = row.Cells["Cost"].Value.ToString();
        }
    }
}
