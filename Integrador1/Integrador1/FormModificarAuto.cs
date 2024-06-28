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
    public partial class FormModificarAuto : Form
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }

        public FormModificarAuto(Auto auto)
        {
            InitializeComponent();

            txtPatente.Text = auto.Patente;
            txtMarca.Text = auto.Marca;
            txtModelo.Text = auto.Modelo;
            txtAño.Text = auto.Año;
            txtPrecio.Text = auto.Precio.ToString();
        }

        private bool ValidarDatos()
        {
            return !string.IsNullOrWhiteSpace(txtPatente.Text) &&
                   !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                   !string.IsNullOrWhiteSpace(txtModelo.Text) &&
                   !string.IsNullOrWhiteSpace(txtAño.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Patente = txtPatente.Text;
                Marca = txtMarca.Text;
                Modelo = txtModelo.Text;
                Año = txtAño.Text;

                // Convertir el valor del TextBox de Precio a decimal
                if (decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    Precio = precio;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
