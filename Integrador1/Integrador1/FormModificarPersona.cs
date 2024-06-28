using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador1
{
    public partial class FormModificarPersona : Form
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public FormModificarPersona(Persona persona)
        {
            InitializeComponent();

            txtDNI.Text = persona.DNI;
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
        }

        private bool ValidarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtDNI.Text) &&
                   !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   !string.IsNullOrWhiteSpace(txtApellido.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DNI = txtDNI.Text;
                Nombre = txtNombre.Text;
                Apellido = txtApellido.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
