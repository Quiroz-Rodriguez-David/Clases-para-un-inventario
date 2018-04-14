using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_de_vehiculos
{
    public partial class Form1 : Form
    {
        Inventario inventario;
        Vehiculo vehiculo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            string Placas = TxtPlacas.Text;
            string Modelo = TxtModelo.Text;
            string Marca = TxtMarca.Text;
            string Telefono=TxtTelefono.Text;
            string Anio = TxtAnio.Text;
            vehiculo = new Vehiculo(Placas, Modelo, Marca, Telefono, Anio);
            inventario.Agregar(vehiculo);
            TxtPlacas.Clear();
            TxtMarca.Clear();
            TxtModelo.Clear();
            TxtTelefono.Clear();
            TxtAnio.Clear();
            TxtPlacas.Focus();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            vehiculo = inventario.Buscar(TxtPlacas.Text);
            if (vehiculo != null)
            {
                TxtReportes.Text = vehiculo.ToString();
                TxtPlacas.Clear();
            }
            else
                MessageBox.Show("No existe un vehiculo con ese numero de placas verifica bien el numero de la placa");
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            inventario.Eliminar(TxtPlacas.Text);
                MessageBox.Show("El vehiculo fue eliminado correctamente");
        }

        private void CmdLISTA_Click(object sender, EventArgs e)
        {
            TxtReportes.Text=inventario.Lista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventario = new Inventario();
        }

        private void CmdInsrtar_Click(object sender, EventArgs e)
        {
            int posicion;
            string Placas = TxtPlacas.Text;
            string Modelo = TxtModelo.Text;
            string Marca = TxtMarca.Text;
            string Telefono = TxtTelefono.Text;
            string Anio= TxtAnio.Text;
            posicion =Convert.ToInt32(TxtInsertar.Text);
            vehiculo = new Vehiculo(Placas, Modelo, Marca, Telefono, Anio);
            inventario.insertar(posicion,vehiculo);
            MessageBox.Show("Se inserto con exito el vehiculo");
            TxtPlacas.Clear();
            TxtMarca.Clear();
            TxtModelo.Clear();
            TxtTelefono.Clear();
            TxtInsertar.Clear();
            TxtAnio.Clear();
            TxtPlacas.Focus();

        }
    }
}
