using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SociosClubes
{
    public partial class Form1 : Form
    {
        public Club[] clubs = new Club[17]; // Array para los 17 clubes
        public int selectedClubIndex = -1; // Índice del club seleccionado en el ComboBox
        public Form1()
        {
            InitializeComponent();
            InitializeClubs();
            initializeColumns();
        }

        private void initializeColumns()
        {
            // Agregar columnas al DataGridView
            MembersDataGridView.ColumnCount = 2;
            MembersDataGridView.Columns[0].Name = "ID";
            MembersDataGridView.Columns[1].Name = "Edad";
        }

        private void InitializeClubs()
        {
            // Inicializa los nombres de los 17 clubes
            string[] clubNames = {
            "Club 1", "Club 2", "Club 3", "Club 4", "Club 5", "Club 6", "Club 7", "Club 8",
            "Club 9", "Club 10", "Club 11", "Club 12", "Club 13", "Club 14", "Club 15", "Club 16", "Club 17"
        };

            // Crea una instancia para cada club y lo agrega al array de clubes
            for (int i = 0; i < clubs.Length; i++)
            {
                clubs[i] = new Club(clubNames[i]);
            }

            // Asigna los nombres de los clubes al ComboBox
            ClubComboBox.Items.AddRange(clubNames);
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            int id, edad, tipoSocio;
            if (int.TryParse(txtId.Text, out id) &&
                int.TryParse(txtEdad.Text, out edad) &&
                int.TryParse(txtTipoSocio.Text, out tipoSocio))
            {
                // Mostrar mensaje de depuración con los valores capturados
                MessageBox.Show("ID: " + id + "\nEdad: " + edad + "\nTipo de Socio: " + tipoSocio);

                // Agregar socio al club
                clubs[selectedClubIndex].AgregarSocio(id, edad, tipoSocio);
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores válidos para el socio.");
            }
        }

        //Boton para mostrar los socios en el data grid view
        private void btnMostrarSocios_Click(object sender, EventArgs e)
        {
            if (selectedClubIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un club antes de mostrar los miembros.");
                return;
            }

            Club selectedClub = clubs[selectedClubIndex];

            // Mostrar índice del club seleccionado (depuración)
            string nombreClub = clubs[selectedClubIndex].Nombre;
            MessageBox.Show("Selecionaste el: " + nombreClub);

            // Limpiar el DataGridView antes de cargar nuevos datos
            MembersDataGridView.Rows.Clear();

            // Mostrar cantidad de miembros en el club seleccionado (depuración)
            MessageBox.Show("Cantidad de miembros en el club seleccionado: " + selectedClub.Socios.Count);

            // Verificar si el club tiene socios antes de mostrarlos
            if (selectedClub.Socios.Count > 0)
            {
                foreach (Miembros member in selectedClub.Socios)
                {
                    // Agregar una fila al DataGridView con la información del socio
                    MembersDataGridView.Rows.Add(member.Id, member.Edad);
                }
            }
            else
            {
                MessageBox.Show("El club seleccionado no tiene socios.");
            }

        }

        private void ClubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualiza el índice del club seleccionado cuando cambia la selección en el ComboBox
            selectedClubIndex = ClubComboBox.SelectedIndex;
        }
    }
}
