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

namespace WindowsFormsApp5.screens.exports
{
    public partial class Exports : Form
    {
        public Exports()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void but_Click(object sender, EventArgs e)
        {
            var r = db.Products.SingleOrDefault(x => x.Code == txtpid.Text);
            if (txtphid.Text == "" || txtquan.Text == "" || txtpid.Text == ""||dateTimePicker1.Value==null )
            {
                MessageBox.Show("complete the data");

            }
            else if (db.Products.Where(x => x.Code == txtpid.Text).Count() <= 0)
            {
                MessageBox.Show("No Product with this code");
            }
            else if (db.Pharmacies.Where(x => x.Code == txtphid.Text).Count() <= 0)
            {
                MessageBox.Show("No Pharmacy with this code");
            }
            else if (r.Quantity < int.Parse(txtquan.Text))
            {
                MessageBox.Show("The quantity u want is more than the quantity available");
            }
            else
            {
                Export exp = new Export();
                exp.Pharmacy_Code = txtphid.Text;
                exp.Product_Code = txtpid.Text;
                exp.Quantity = int.Parse(txtquan.Text);
                exp.date = dateTimePicker1.Value;
                db.Exports.Add(exp);
                var item = db.Products.SingleOrDefault(x => x.Code == txtpid.Text);
                item.Quantity = item.Quantity - int.Parse(txtquan.Text);
                db.SaveChanges();
                txtpid.Text = ""; txtquan.Text = ""; txtphid.Text = "";
                MessageBox.Show("Done");

            }
        }

        private void Exports_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(343, 350);
        }
    }
}
