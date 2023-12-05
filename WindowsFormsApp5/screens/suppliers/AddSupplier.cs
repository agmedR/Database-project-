using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.database;

namespace WindowsFormsApp5.screens.suppliers
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void but_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtphone.Text == "" || txtconame.Text == "" || txtcoad.Text == "")
            {
                MessageBox.Show("complete the data");

            }
            else if (db.Suppliers.Where(x => x.Code == txtscode.Text).Count() > 0)
            {
                MessageBox.Show("there is a supplier with this code");
            }
            else if (db.Companies.Where(x => x.Code == txtccode.Text).Count() > 0)
            {
                MessageBox.Show("there is a company with this code");
            }
            else
            {
                Supplier obj = new Supplier();
                Company company = new Company();
                obj.Phone = txtphone.Text;
                obj.Name = txtname.Text;
                obj.Code=txtscode.Text;
                company.Name = txtconame.Text;
                company.Address = txtcoad.Text;
                company.Code = txtccode.Text;
                db.Suppliers.Add(obj);
                db.SaveChanges();
                db.Companies.Add(company);
                db.SaveChanges();
                txtcoad.Text = ""; txtconame.Text = "";txtname.Text = "";txtphone.Text = "";
                txtccode.Text = ""; txtscode.Text = "";
                MessageBox.Show("Added");
            }
        }

        private void AddSupplier_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(908, 347);
        }
    }
}
