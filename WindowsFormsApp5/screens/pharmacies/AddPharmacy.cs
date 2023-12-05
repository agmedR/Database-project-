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

namespace WindowsFormsApp5.screens.pharmacies
{
    public partial class AddPharmacy : Form
    {
        public AddPharmacy()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
     
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtphadr.Text == "" || txtphname.Text == ""||txtpcode.Text=="")
            {
                MessageBox.Show("complete the data");

            }
            else if (db.Pharmacies.Where(x => x.Code == txtpcode.Text).Count() > 0)
            {
                MessageBox.Show("there is a pharmacy with this code");
            }
            else
            {
                Pharmacy pharmacy = new Pharmacy();
                pharmacy.Name = txtphname.Text;
                pharmacy.Address = txtphadr.Text;
                pharmacy.Code=txtpcode.Text;
                db.Pharmacies.Add(pharmacy);
                txtphadr.Text = "";txtphname.Text = ""; txtpcode.Text = "";
                db.SaveChanges();
                MessageBox.Show("Added");
            }
        }

        private void AddPharmacy_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(453, 312);
        }
    }
}
