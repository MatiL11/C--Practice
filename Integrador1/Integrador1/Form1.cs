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
    public partial class Form1 : Form
    {
        private List<Persona> personas;
        private List<Auto> autos; 

        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
            ConfigurarDataGridViewPersonas();
            autos = new List<Auto>();
        }

        private void CargarDatosIniciales()
        {
            personas = new List<Persona>
            {
                new Persona("12345678", "Juan", "Perez"),
                new Persona("87654321", "Maria", "Gomez"),
                new Persona("11223344", "Carlos", "Rodriguez")
            };
        }

        private void ConfigurarDataGridViewPersonas()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
            dgvPersonas.AutoResizeColumns();
        }

        private void ConfigurarDataGridViewAutosDePersona(Persona persona)
        {
            try
            {
                if (persona != null)
                {
                    dgvAutosDePersona.DataSource = null;
                    dgvAutosDePersona.DataSource = persona.Lista_de_autos();
                    dgvAutosDePersona.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar el DataGridView de autos de la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarTotalPrecioAutos(Persona persona)
        {
            try
            {
                if (persona != null)
                {
                    var totalPrecioAutos = persona.Lista_de_autos().Sum(auto => auto.Precio);
                    lblTotalPrecioAutos.Text = $"Total Precio de Autos: {totalPrecioAutos:C}";
                }
                else
                {
                    lblTotalPrecioAutos.Text = "Total Precio de Autos: $0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el total del precio de autos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewPersonas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                    {
                        var selectedPersona = personas[selectedRowIndex];

                        ConfigurarDataGridViewAutosDePersona(selectedPersona);

                        // Actualizar el total del precio de los autos de la persona seleccionada
                        ActualizarTotalPrecioAutos(selectedPersona);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar una persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMostrarAutos_Click(object sender, EventArgs e)
        {
            try
            {
                FormAutos formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();

                // Si no está abierto, crear una nueva instancia y mostrarla
                if (formAutos == null)
                {
                    formAutos = new FormAutos(autos);
                    formAutos.Show();
                }

                formAutos.ConfigurarDataGridViewAutosGenerales(personas.SelectMany(p => p.Lista_de_autos()).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar autos generales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViewPersonas();
        }

        private void btnAutosDePersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                    {
                        var selectedPersona = personas[selectedRowIndex];
                        ConfigurarDataGridViewAutosDePersona(selectedPersona);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una persona en la grilla de personas.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar autos de persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarDataGridViewAutosConDueño()
        {
            try
            {
                var datosAutosConDueño = new List<object>();

                foreach (var persona in personas)
                {
                    foreach (var auto in persona.Lista_de_autos())
                    {
                        var dueño = auto.Dueño();

                        if (dueño == null)
                        {
                            throw new InvalidOperationException($"El auto {auto.Patente} no tiene dueño asignado.");
                        }

                        // Crear un objeto anónimo con los datos requeridos
                        var autoConDueño = new
                        {
                            Marca = auto.Marca,
                            Año = auto.Año,
                            Modelo = auto.Modelo,
                            Patente = auto.Patente,
                            DNIDueño = dueño.DNI,
                            NombreCompletoDueño = $"{dueño.Apellido}, {dueño.Nombre}"
                        };

                        datosAutosConDueño.Add(autoConDueño);
                    }
                }

                dgvAutosConDueño.DataSource = null;
                dgvAutosConDueño.DataSource = datosAutosConDueño;
                dgvAutosConDueño.AutoResizeColumns();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error al configurar DataGridView de autos con dueño: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAutosConDueño_Click(object sender, EventArgs e)
        {
            ConfigurarDataGridViewAutosConDueño();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un formulario para agregar una nueva persona
                using (var formAgregarPersona = new FormAgregarPersona())
                {
                    var result = formAgregarPersona.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var dni = formAgregarPersona.DNI;
                        var nombre = formAgregarPersona.Nombre;
                        var apellido = formAgregarPersona.Apellido;

                        // Validar datos de entrada si es necesario
                        if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                        {
                            throw new ArgumentException("Los campos DNI, Nombre y Apellido son obligatorios.");
                        }

                        // Crear una nueva persona y agregarla a la lista
                        var nuevaPersona = new Persona(dni, nombre, apellido);
                        personas.Add(nuevaPersona);

                        ConfigurarDataGridViewPersonas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un formulario para agregar un nuevo auto
                using (var formAgregarAuto = new FormAgregarAuto())
                {
                    var result = formAgregarAuto.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var patente = formAgregarAuto.Patente;
                        var marca = formAgregarAuto.Marca;
                        var modelo = formAgregarAuto.Modelo;
                        var año = formAgregarAuto.Año;
                        var precio = formAgregarAuto.Precio;

                        // Obtener la persona seleccionada en el DataGridView de personas
                        if (dgvPersonas.SelectedRows.Count > 0)
                        {
                            var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                            if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                            {
                                var personaDueña = personas[selectedRowIndex];

                                // Crear un nuevo auto y agregarlo a la persona dueña
                                var nuevoAuto = new Auto(patente, marca, modelo, año, precio);
                                personaDueña.AgregarAuto(nuevoAuto);

                                ConfigurarDataGridViewAutosDePersona(personaDueña);

                                // Actualizar el DataGridView de autos en FormAutos
                                var formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();
                                if (formAutos != null)
                                {
                                    formAutos.ConfigurarDataGridViewAutosGenerales(personas.SelectMany(p => p.Lista_de_autos()).ToList());
                                }

                                // Actualizar el total del precio de los autos
                                ActualizarTotalPrecioAutos(personaDueña);
                            }
                            else
                            {
                                MessageBox.Show("El índice de la persona seleccionada no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione una persona en la grilla de personas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar auto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                    {
                        var personaABorrar = personas[selectedRowIndex];

                        // Intentar eliminar la persona de la lista de personas
                        personas.Remove(personaABorrar);

                        // Actualizar DataGridView de personas
                        ConfigurarDataGridViewPersonas();

                        // Eliminar los autos asociados a esta persona de la lista general de autos
                        autos.RemoveAll(a => a.Dueño() == personaABorrar);

                        // Actualizar DataGridView de autos en FormAutos
                        var formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();
                        if (formAutos != null)
                        {
                            formAutos.ConfigurarDataGridViewAutosGenerales(autos);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El índice de la persona seleccionada no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una persona en la grilla de personas para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAutosDePersona.SelectedRows.Count > 0)
                {
                    var selectedAuto = (Auto)dgvAutosDePersona.SelectedRows[0].DataBoundItem;
                    var selectedRowIndexPersona = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndexPersona >= 0 && selectedRowIndexPersona < personas.Count)
                    {
                        var personaDueña = personas[selectedRowIndexPersona];

                        // Intentar eliminar el auto de la persona dueña
                        personaDueña.EliminarAuto(selectedAuto);

                        // Actualizar el DataGridView de autos de la persona seleccionada
                        ConfigurarDataGridViewAutosDePersona(personaDueña);

                        // Actualizar el DataGridView de autos en FormAutos
                        var formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();
                        if (formAutos != null)
                        {
                            formAutos.ConfigurarDataGridViewAutosGenerales(personas.SelectMany(p => p.Lista_de_autos()).ToList());
                        }

                        // Actualizar el total del precio de los autos
                        ActualizarTotalPrecioAutos(personaDueña);
                    }
                    else
                    {
                        MessageBox.Show("El índice de la persona seleccionada no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un auto en la grilla de autos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                    {
                        var personaAModificar = personas[selectedRowIndex];

                        using (var formModificarPersona = new FormModificarPersona(personaAModificar))
                        {
                            var result = formModificarPersona.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                personaAModificar.DNI = formModificarPersona.DNI;
                                personaAModificar.Nombre = formModificarPersona.Nombre;
                                personaAModificar.Apellido = formModificarPersona.Apellido;

                                ConfigurarDataGridViewPersonas();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El índice de la persona seleccionada no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una persona en la grilla de personas para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0 && dgvAutosDePersona.SelectedRows.Count > 0)
                {
                    var selectedPersonaIndex = dgvPersonas.SelectedRows[0].Index;
                    var selectedAutoIndex = dgvAutosDePersona.SelectedRows[0].Index;

                    if (selectedPersonaIndex >= 0 && selectedPersonaIndex < personas.Count)
                    {
                        var persona = personas[selectedPersonaIndex];

                        if (selectedAutoIndex >= 0 && selectedAutoIndex < persona.Cantidad_de_Autos())
                        {
                            var autoAModificar = persona.Lista_de_autos()[selectedAutoIndex];

                            using (var formModificarAuto = new FormModificarAuto(autoAModificar))
                            {
                                var result = formModificarAuto.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    autoAModificar.Patente = formModificarAuto.Patente;
                                    autoAModificar.Marca = formModificarAuto.Marca;
                                    autoAModificar.Modelo = formModificarAuto.Modelo;
                                    autoAModificar.Año = formModificarAuto.Año;
                                    autoAModificar.Precio = formModificarAuto.Precio;

                                    ConfigurarDataGridViewAutosDePersona(persona);

                                    var formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();
                                    if (formAutos != null)
                                    {
                                        formAutos.ConfigurarDataGridViewAutosGenerales(autos);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El auto seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La persona seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una persona y un auto en las grillas respectivas para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAsignarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dgvPersonas.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < personas.Count)
                    {
                        var selectedPersona = personas[selectedRowIndex];

                        using (var formAsignarAuto = new FormAsignarAuto(personas.SelectMany(p => p.Lista_de_autos()).ToList(), selectedPersona))
                        {
                            var result = formAsignarAuto.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                var autoSeleccionado = formAsignarAuto.AutoSeleccionado;
                                if (autoSeleccionado != null)
                                {
                                    // Eliminar el auto del dueño anterior si lo tiene
                                    var anteriorDueño = autoSeleccionado.Dueño();
                                    if (anteriorDueño != null)
                                    {
                                        anteriorDueño.EliminarAuto(autoSeleccionado);
                                    }

                                    // Asignar el auto al nuevo dueño
                                    selectedPersona.AgregarAuto(autoSeleccionado);
                                    autoSeleccionado.AsignarPropietario(selectedPersona);

                                    // Actualizar los DataGridViews
                                    ConfigurarDataGridViewAutosDePersona(selectedPersona);
                                    var formAutos = Application.OpenForms.OfType<FormAutos>().FirstOrDefault();
                                    if (formAutos != null)
                                    {
                                        formAutos.ConfigurarDataGridViewAutosGenerales(personas.SelectMany(p => p.Lista_de_autos()).ToList());
                                    }

                                    // Actualizar el label con la suma de los precios de los autos
                                    ActualizarTotalPrecioAutos(selectedPersona);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una persona en la grilla de personas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

