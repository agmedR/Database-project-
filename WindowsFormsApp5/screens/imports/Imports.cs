using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp5.database;

namespace WindowsFormsApp5.screens.imports
{
    public partial class Imports : Form
    {
        public Imports()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
   
        private void but_Click(object sender, EventArgs e)
        {
            if (txtpid.Text == "" || txtquan.Text == "" || txtsid.Text == "" || dtp.Value==null)
            {
                MessageBox.Show("complete the data");

            }
            else if (db.Products.Where(x => x.Code == txtpid.Text).Count() <= 0)
            {
                MessageBox.Show("No Product with this code");
            }
            else if (db.Suppliers.Where(x => x.Code == txtsid.Text).Count() <= 0)
            {
                MessageBox.Show("No Supplier with this code");
            }
            else
            {
                Import imp = new Import();
                imp.Supplier_Code = txtsid.Text;
                imp.Product_Code = txtpid.Text;
                imp.Quantity = int.Parse(txtquan.Text);
                imp.date = dtp.Value.Date;
                db.Imports.Add(imp);
                db.SaveChanges();
                var item = db.Products.SingleOrDefault(x => x.Code == txtpid.Text);
                item.Quantity = item.Quantity + int.Parse(txtquan.Text);
                db.SaveChanges();
                txtpid.Text = ""; txtquan.Text = ""; txtsid.Text = "";
                MessageBox.Show("Done");
            }
        }

        private void Imports_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(336, 348);
        }
    }
}
