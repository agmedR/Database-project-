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
    public partial class SearchProducts : Form
    {
        public SearchProducts()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
  



        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpname.Text=="")
                dataview.DataSource= db.Products.Where(x =>x.Code == txtpid.Text).ToList();
            else
                dataview.DataSource = db.Products.Where(x => x.Name.Contains(txtpname.Text) || x.Code == txtpid.Text).ToList();
            
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wareHouse2DataSet2.Products' table. You can move, or remove it, as needed.
          //  this.productsTableAdapter2.Fill(this.wareHouse2DataSet2.Products);
            // TODO: This line of code loads data into the 'wareHouseDataSet1.Products' table. You can move, or remove it, as needed.
          //  this.productsTableAdapter1.Fill(this.wareHouseDataSet1.Products);

        }

        private void SearchProducts_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(585, 391);
        }
    }
}
