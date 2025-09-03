using Datos;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class CarroController
    {
        BaseDatos datos;
        public CarroController() {

           datos =  new BaseDatos();
        }

        public string GuardarDatosCarros(string modelo, string placa, string dueño)
        {
            string resultado = "";
            resultado = datos.GuardarDatosCarros(modelo, placa, dueño);

            return resultado; 
        }

        public List<CarrosEntity> ConsultarCarros()
        {
            List<CarrosEntity> listaCarros = datos.ConsultarCarros();

            return listaCarros;
        }

    }
}
