using EFÖdev.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFÖdev
{
    public partial class SupplierSearch : Form
    {
        public SupplierSearch()
        {
            InitializeComponent();
        }

        private void SupplierSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EFÖdevContext db = new EFÖdevContext();
            int Id = Convert.ToInt32(txtSearch.Text);
            Supplier Supplier = db.Suppliers.Find(Id);
            if (Supplier != null)
            {
                lblCompanyName.Text = Supplier.CompanyName;
                lblContactName.Text = Supplier.ContactName;
                lblContactTitle.Text = Supplier.ContactTitle;
                lblAdress.Text = Supplier.Address;
            }
            else
            {
                MessageBox.Show("Urun bulunamadi");
            }
        }
    }
}
