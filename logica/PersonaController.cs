using Datos;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class PersonaController
    {
        BaseDatos basedatos;

        public PersonaController()
        {
            basedatos = new BaseDatos();
        }

        public string GuardarDatosPersonas(string nombre, string documento, string telefono)
        {
            string resultado = "";

            resultado = basedatos.GuardarDatosPersonas(nombre, documento, telefono);

            return resultado;
        }

        public List<PersonasEntity> VerPersonas()
        {
            List<PersonasEntity> listaPersonas = basedatos.VerPersonas();

            return listaPersonas;
        }
    }
}
