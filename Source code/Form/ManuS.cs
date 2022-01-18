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
    public partial class ManuS : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public ManuS()
        {
            InitializeComponent();
            List<Manufacturer> manufacturers = ManufacturerDAO.getInstance().getAll();
            Grid1.DataSource = manufacturers;
        }

        private void Search(object sender, EventArgs e) // Tìm kiếm dữ liệu theo mã
        {
            int ID = 0;
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                ID = int.Parse(txtID.Text);
            }
            string Name = txtName.Text;
            Manufacturer manufacturer = new Manufacturer(ID, Name);
            List<Manufacturer> manufacturers = ManufacturerDAO.getInstance().get(manufacturer);

            Grid1.DataSource = manufacturers;
            Grid1.Columns["ID"].Width = 100;
            Grid1.Columns["Name"].Width = 200;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
