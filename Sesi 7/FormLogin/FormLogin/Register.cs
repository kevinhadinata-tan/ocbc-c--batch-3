using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info(id, names, username, password) VALUES (NULL, '" + nameTb.Text + "', '" +
                usernameTb.Text + "', '" + passwordTb.Text + "')");

            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
