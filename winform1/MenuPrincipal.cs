using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.ShowDialog();
            lblCurrentUser.Text = LogIn.usuarioGlobal;
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCliente ventana = new nuevoCliente();
            ventana.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show(lblCurrentUser.Text);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            progressBar.Increment(20);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                progressBar.PerformStep();
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar.Increment(-100);
        }

        private void nuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada y distribuida de manera independiente por:\n\nGaston Paschetta\n\nLenguaje: C#\n\nTecnologias: .NET Framework 4.8\n+ WinForms & VSCommunity");
        }
    }
}
