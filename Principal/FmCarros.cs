using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FmCarros : Form
    {
        CarroController controller;
        public FmCarros()
        {
            controller = new CarroController();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string modelo = tbModelo.Text;
            string placa = tbPlaca.Text;
            string dueño = tbDueño.Text;

            string resultado = controller.GuardarDatosCarros(modelo, placa, dueño);

            MessageBox.Show(resultado);


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var listaCarros = controller.ConsultarCarros();

            string resultado = "";

            foreach (var carros in listaCarros)
            {
                resultado += "Modelo: " + carros.Modelo + "." + " " + " Placa" + " " + carros.Placa + "." + " " + "Dueño: " + " " + carros.Dueño + "." + Environment.NewLine;
            }
            MessageBox.Show(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnPersonas_Click(object sender, EventArgs e)
        {
            FmPersonascs ventana = new FmPersonascs(); // Crear la ventana de Personas
            ventana.Show(); // Mostrarla
        }

    }
}
