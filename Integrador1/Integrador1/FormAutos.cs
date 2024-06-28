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
    public partial class FormAutos : Form
    {
        private List<Auto> autos;
        public Auto AutoSeleccionado { get; private set; }

        public FormAutos(List<Auto> autos)
        {
            InitializeComponent();
            this.autos = autos;
            ConfigurarDataGridViewAutosGenerales(autos);
        }

        public void ConfigurarDataGridViewAutosGenerales(List<Auto> autos)
        {
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = autos;
            dgvAutos.AutoResizeColumns();
        }

        private void dgvAutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count > 0)
            {
                AutoSeleccionado = (Auto)dgvAutos.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
