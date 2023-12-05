using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.database;

namespace WindowsFormsApp5.screens.login
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        WareHouse2Entities db = new WareHouse2Entities();
        private void button2_Click(object sender, EventArgs e)
        {
            var r = db.users.Where(x => x.UserName == txtusername.Text && x.Password == txtpass.Text).ToList();
            if (r.Count > 0)
            {
                Thread th = new Thread(openf);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
                users.name = r[0].Name;
            }
            else { MessageBox.Show("ur password or username is invalid"); }
        }
        void openf()
        {
            Application.Run(new MainPage());
        }

        private void txtpass_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(408, 329);
        }
    }
    static class users
    {
        static public string name { get; set; }
    }
}
