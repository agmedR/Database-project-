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
using WindowsFormsApp5.screens.exports;
using WindowsFormsApp5.screens.imports;
using WindowsFormsApp5.screens.login;
using WindowsFormsApp5.screens.pharmacies;
using WindowsFormsApp5.screens.product;
using WindowsFormsApp5.screens.suppliers;
using WindowsFormsApp5.screens.users;
using WindowsFormsApp5.screens.warning;

namespace WindowsFormsApp5
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            MessageBox.Show($"welcome {users.name}");
            label1.Text = $"welcome {users.name}";
        }
        WareHouse2Entities db = new WareHouse2Entities();
    


        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();    
            addSupplier.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPharmacy addPh = new AddPharmacy();
            addPh.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Imports imports = new Imports();
            imports.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exports exports = new Exports();    
            exports.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Products products = new Products(); 
            products.Show();    

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Warning warning = new Warning();
            warning.Show();
        }

        private void MainPage_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(677, 429);

        }
    }
}
