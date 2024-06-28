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
    public partial class FormAgregarAuto : Form
    {

        public string Patente { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Año { get; private set; }
        public decimal Precio { get; private set; }

        public FormAgregarAuto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación básica de datos
            if (string.IsNullOrWhiteSpace(txtPatente.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtAño.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Patente = txtPatente.Text.Trim();
            Marca = txtMarca.Text.Trim();
            Modelo = txtModelo.Text.Trim();
            Año = txtAño.Text.Trim();
            Precio = decimal.Parse(txtPrecio.Text.Trim());



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
