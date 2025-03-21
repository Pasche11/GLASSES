using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;

namespace winform1
{
    public partial class nuevoCliente : Form
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void chkbResponsableInscripto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbResponsableInscripto.Checked == true)
                txtCuit.Enabled = true;
            else
                txtCuit.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Length > 0 && txtCuit.Text.Length > 0 && txtPostal.Text.Length > 0 && lstLocalidad.Text.Length > 0)
            {
                Cliente cliente = new Cliente();
                cliente.RI = chkbResponsableInscripto.Checked;
                cliente.RazonSocial = txtRazonSocial.Text;
                cliente.Direccion = lstLocalidad.Text;
                cliente.CPostal = int.Parse(txtPostal.Text);
                cliente.Cuit = txtCuit.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Telefono = txtTelefono.Text;
            }
            else
            {
                MessageBox.Show("Los campos con (*) son obligatorios");
            }
        }
    }
}
