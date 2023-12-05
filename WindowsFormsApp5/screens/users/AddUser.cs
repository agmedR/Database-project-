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

namespace WindowsFormsApp5.screens.users
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpass.Text == "" || txtusername.Text == "")
            {
                MessageBox.Show("complete the data");

            }
            else if (db.users.Where(x => x.UserName == txtusername.Text).Count() > 0&&
                     db.users.Where(x => x.Password == txtpass.Text).Count() > 0)
            {
                MessageBox.Show("try a different password or username");
            }
            else
            {
                user obj = new user();
                obj.Password = txtpass.Text;
                obj.Name = txtname.Text;
                obj.UserName = txtusername.Text;
                db.users.Add(obj);
                db.SaveChanges();
                txtname.Text = ""; txtpass.Text = ""; txtusername.Text = "";
                MessageBox.Show("Added");
            }
        }

        private void AddUser_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(456, 357);
        }
    }
}
