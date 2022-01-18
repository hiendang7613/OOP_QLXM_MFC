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
    public partial class MotorS : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public MotorS()
        {
            InitializeComponent();
            List<Motorbike> motorbikes = MotorbikeDAO.getInstance().getAll();
            Grid1.DataSource = motorbikes;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Name"].Width = 200;
            Grid1.Columns["Manufacturer"].Width = 200;
            Grid1.Columns["Cost"].Width = 200;
        }
        private void Search(object sender, EventArgs e) // Tìm kiếm dữ liệu theo mã
        {
            int ID = 0;
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                ID = int.Parse(txtID.Text);
            }
            string Name = txtName.Text;
            string ManuName = cbManuName.Text;
            Manufacturer manufacturer = new Manufacturer(0, ManuName);
            manufacturer = ManufacturerDAO.getInstance().get(manufacturer)[0];
            Motorbike motorbike = new Motorbike(ID, Name,manufacturer,0);
            List<Motorbike> motorbikes = MotorbikeDAO.getInstance().get(motorbike);

            Grid1.DataSource = motorbikes;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Name"].Width = 200;
            Grid1.Columns["Manufacturer"].Width = 200;
            Grid1.Columns["Cost"].Width = 200;
        }



        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
