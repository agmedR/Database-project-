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

namespace WindowsFormsApp5.screens.warning
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void Warning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wareHouse2DataSet1.Products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter.Fill(this.wareHouse2DataSet1.Products);
            dataGridView1.DataSource = db.Products.Where(x => x.Expiration_Date < DateTime.Now).ToList();

        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.Expiration_Date < dtp.Value.Date).ToList();
        }

        private void Warning_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(530, 356);
        }
    }
}
