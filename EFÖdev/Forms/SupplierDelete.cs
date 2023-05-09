using EFÖdev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFÖdev.Forms
{
    public partial class SupplierDelete : Form
    {
        public SupplierDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EFÖdevContext db = new EFÖdevContext();
            int ıd = Convert.ToInt32(txtDelete.Text);
            Supplier supplier = db.Suppliers.Find(ıd);
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
            MessageBox.Show("Success Delete");
            LoadData();

        }
        void LoadData()
        {
            dataGridView1.DataSource = null;
            EFÖdevContext db = new EFÖdevContext();
            dataGridView1.DataSource = db.Suppliers.ToList();
            dataGridView1.Columns[4].Visible= false;
        }

        private void SupplierDelete_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
