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

namespace WindowsFormsApp5.screens.product
{
    public partial class Products : Form
    {
        WareHouse2Entities db = new WareHouse2Entities();
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wareHouse2DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter3.Fill(this.wareHouse2DataSet.Products);
            // TODO: This line of code loads data into the 'wareHouseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.wareHouseDataSet.Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchProducts searchProducts = new SearchProducts();
            searchProducts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
        }

        private void Products_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(534, 410);
        }
    }
}
