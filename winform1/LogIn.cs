using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;

namespace winform1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        internal static string usuarioGlobal;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool access = false;
            Usuario user1 = new Usuario();
            user1.user = txtLogin.Text;
            user1.pass = txtPass.Text;
            if (user1.user == "Gaston"||  user1.user == "Gonzalo")
            {
                if (user1.user == "Gaston")
                {
                    if (user1.pass == "2610")                    
                        access = true;                    
                }
                else if(user1.user == "Gonzalo")
                {
                    if(user1.pass == "0710")
                    {
                        access = true;
                    }
                }
            }
            if (access == true)
            {
                usuarioGlobal = user1.user;
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Se ha ingresado un usuario\n o contraseña incorrectos");
            }
        }
    }
}
