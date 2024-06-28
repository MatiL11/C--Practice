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
    public partial class FormAsignarAuto : Form
    {
        private List<Auto> autosDisponibles;
        private Persona persona;

        public Auto AutoSeleccionado { get; private set; }

        public FormAsignarAuto(List<Auto> autos, Persona persona)
        {
            InitializeComponent();
            this.autosDisponibles = autos;
            this.persona = persona;
            ConfigurarDataGridViewAutos();
        }

        private void ConfigurarDataGridViewAutos()
        {
            dgvAutosDisponibles.DataSource = null;
            dgvAutosDisponibles.DataSource = autosDisponibles;
            dgvAutosDisponibles.AutoResizeColumns();
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            if (dgvAutosDisponibles.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dgvAutosDisponibles.SelectedRows[0].Index;
                if (selectedRowIndex >= 0 && selectedRowIndex < autosDisponibles.Count)
                {
                    AutoSeleccionado = autosDisponibles[selectedRowIndex];
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un auto en la grilla de autos disponibles.");
            }
        }
    }
}
