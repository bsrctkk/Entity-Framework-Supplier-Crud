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
    public partial class SupplierAdd : Form
    {
        public SupplierAdd()
        {
            InitializeComponent();
        }

        private void SupplierAdd_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }
        void LoadData()
        {
            dataGridSupplierAdd.DataSource = null;
            EFÖdevContext db = new EFÖdevContext();
            dataGridSupplierAdd.DataSource = db.Suppliers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EFÖdevContext db = new EFÖdevContext();
            Supplier suppliers = new Supplier();
            suppliers.CompanyName = txtCompanyName.Text;
            suppliers.ContactName = txtContactName.Text;
            suppliers.ContactTitle = txtContactTitle.Text;
            suppliers.Address = txtAdress.Text;

            db.Suppliers.Add(suppliers);
            db.SaveChanges();
            MessageBox.Show("Success");
            LoadData();
            Clear();
        }
        void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
        }
    }
}
