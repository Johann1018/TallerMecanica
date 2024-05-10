using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace parcial3
{
    public partial class Form1 : Form
    {

        TallerMecanica tallermecanica;


        public Form1()
        {
            InitializeComponent();
            dgVehiculos.SelectionChanged += dgVehiculos_SelectionChanged;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            try
            {
                // Capturar los datos del formulario
                string placa = txtPlaca.Text;
                string numeroTarjeta = txtTarjeta.Text;
                string modelo = txtModelo.Text;
                string color = txtColor.Text;
                string numeroMotor = txtMotor.Text;

                // Crear una instancia de Vehiculo con los datos capturados
                Vehiculo vehiculo = new Vehiculo
                {
                    Placa = placa,
                    NumeroTarjetaPropiedad = numeroTarjeta,
                    Modelo = modelo,
                    Color = color,
                    NumeroMotor = numeroMotor,
                    FechaUltimoIngreso = DateTime.Now
                };

                // Registrar el vehículo en el taller de mecánica
                TallerMecanica.RegistrarVehiculo(vehiculo);

                // Actualizar el DataGridView
                dgVehiculos.DataSource = null;
                dgVehiculos.DataSource = TallerMecanica.Vehiculos;

                // Mostrar un mensaje de éxito
                MessageBox.Show("Vehículo registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar vehículo: {ex.Message}");
            }
        }

        private void dgVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una fila
            if (dgVehiculos.SelectedRows.Count > 0)
            {
                // Obtener el vehículo seleccionado
                Vehiculo vehiculoSeleccionado = (Vehiculo)dgVehiculos.SelectedRows[0].DataBoundItem;

                // Habilitar el botón si se seleccionó un vehículo
                btnRegistrarOrdenServicio.Enabled = true;
            }
            else
            {
                // Deshabilitar el botón si no se seleccionó ningún vehículo
                btnRegistrarOrdenServicio.Enabled = false;
            }
        }

        private void btnRegistrarOrdenServicio_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se seleccionó una fila en el DataGridView
                if (dgVehiculos.SelectedRows.Count > 0)
                {
                    // Obtener el vehículo seleccionado
                    Vehiculo vehiculoSeleccionado = (Vehiculo)dgVehiculos.SelectedRows[0].DataBoundItem;

                    // Obtener los valores de los TextBox
                    string nombreServicio = txtNombreServicio.Text;
                    string nombreCliente = txtNombreCliente.Text;
                    decimal montoCancelado = decimal.Parse(txtMontoCancelado.Text);
                    DateTime fechaServicio = DateTime.ParseExact(txtFechaServicio.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                    // Crear una instancia de OrdenServicio
                    OrdenServicio ordenServicio = new OrdenServicio(nombreServicio, nombreCliente, montoCancelado, fechaServicio);

                    // Agregar la orden de servicio al vehículo seleccionado
                    vehiculoSeleccionado.OrdenesServicio.Add(ordenServicio);

                    // Actualizar el DataGridView con las órdenes de servicio del vehículo
                    dgOrdenesServicio.DataSource = null;
                    dgOrdenesServicio.DataSource = vehiculoSeleccionado.OrdenesServicio;

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Orden de servicio registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un vehículo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar orden de servicio: {ex.Message}");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltrarVehiculosMayorNumeroOrdenes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los vehículos ordenados de forma ascendente por el número de placa
                var vehiculosOrdenadosPorPlaca = TallerMecanica.Vehiculos
                    .OrderBy(v => v.Placa)
                    .ToList();

                // Actualizar el DataGridView con los resultados del filtro
                ActualizarDataGridView(vehiculosOrdenadosPorPlaca);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar vehículos: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

         
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgFiltros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDataGridView(List<Vehiculo> vehiculos)
        {
            // Limpiar el DataGridView
            //  dgFiltros.DataSource = null;

            // Mostrar los vehículos en el DataGridView
            dgFiltros.DataSource = vehiculos;
        }


        private void FiltrarVehiculosMayorNumeroOrdenes()
        {
            try
            {
                // Obtener los vehículos con el mayor número de órdenes de servicio
                var vehiculosConMayorOrdenes = TallerMecanica.Vehiculos
                    .OrderByDescending(v => v.OrdenesServicio.Count)
                    // .Take(1)
                    .ToList();

                // Actualizar el DataGridView con los resultados del filtro
                ActualizarDataGridView(vehiculosConMayorOrdenes);

                // Mostrar un mensaje si no se encontraron vehículos
                if (vehiculosConMayorOrdenes.Count == 0)
                {
                    MessageBox.Show("No se encontraron vehículos con órdenes de servicio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar vehículos: {ex.Message}");
            }
        }

    }
}
