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

namespace WindowsFormsApp5.screens.product
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpname.Text == "" || txtpprice.Text == "" || txtpquan.Text == "" ||
                txtpcode.Text == "" || txtcompcode.Text == ""||dateTimePicker1.Value==null||dateTimePicker2.Value==null)
            {
                MessageBox.Show("complete the data");

            }
            else if (db.Products.Where(x => x.Code == txtpcode.Text).Count() > 0)
            {
                MessageBox.Show("there is a product with this code");
            }
            else if (db.Companies.Where(x => x.Code == txtcompcode.Text).Count() <= 0)
            {
                MessageBox.Show("No company with this code");
            }
            else
            {
                Product pro = new Product();    
                pro.Name = txtpname.Text;
                pro.Code = txtpcode.Text;
                pro.Price = decimal.Parse(txtpprice.Text);
                pro.Quantity=int.Parse(txtpquan.Text);
                pro.Active_substance=txtpasub.Text;
                pro.Company_Code=txtcompcode.Text;
                pro.Production_Date = dateTimePicker1.Value.Date;
                pro.Expiration_Date = dateTimePicker2.Value.Date;
                db.Products.Add(pro);
                db.SaveChanges();
                txtpname.Text = ""; txtpcode.Text = ""; txtpprice.Text = ""; txtpquan.Text = "";
                txtpasub.Text = ""; txtcompcode.Text = "";
                MessageBox.Show("Added");
            }
            }

        private void AddProducts_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(730, 400);
        }
    }
}
