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
    public partial class FormAgregarPersona : Form
    {

        public string DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public FormAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación básica de datos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DNI = txtDNI.Text.Trim();
            Nombre = txtNombre.Text.Trim();
            Apellido = txtApellido.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
