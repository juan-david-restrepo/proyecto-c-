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
    public partial class FmPersonascs : Form
    {
        PersonaController controller;  // <- Aquí sí queda bien

        public FmPersonascs()
        {
            controller = new PersonaController();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string documento = tbDocumento.Text;
            string telefono = tbTelefono.Text;

            string resultado = controller.GuardarDatosPersonas(nombre, documento, telefono);

            MessageBox.Show(resultado);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var listaPersonas = controller.VerPersonas();

            string resultado = "";

            foreach (var personas in listaPersonas)
            {
                resultado += "Nombre: " + personas.Nombre
                           + ", Documento: " + personas.Documento
                           + ", Teléfono: " + personas.Telefono
                           + Environment.NewLine;
            }
            MessageBox.Show(resultado);
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            // Aquí ya puedes abrir el formulario de carros
            FmCarros formCarros = new FmCarros();
            formCarros.Show();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

