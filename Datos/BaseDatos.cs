using Datos.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BaseDatos:conexionDB
    {
        List<CarrosEntity> listaCarros;
        List<PersonasEntity> listaPersonas;

        public BaseDatos()
        {
            listaCarros = new List<CarrosEntity>();
            listaPersonas = new List<PersonasEntity>();
        }
            

        public string GuardarDatosCarros(string modelo, string placa, string dueño)
        {
            String resultado = "";

            if (string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(dueño))
            {
                return "Todos los campos son obligatorios.";
            }

            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);
            connection.Open();


                MySqlCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO carros (modelo, placa, dueño) values ('" + modelo + "','" + placa + "','" + dueño + "')";

                int numeroFilas  =  command.ExecuteNonQuery();

                if (numeroFilas > 0){
                resultado = "Guardado";
                    
                }
                else
                {
                resultado = "No se guardo";
                }

                connection.Close();

                return resultado;

        }

        public string GuardarDatosPersonas(string nombre, string documento, string telefono)
        {
            string resultado = "";

            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);
            connection.Open();


            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO personas (nombre, documento, telefono) values ('" + nombre + "','" + documento + "','" + telefono + "')";

            int numeroFilas = command.ExecuteNonQuery();

            if (numeroFilas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No guardado";
            }

            connection.Close();

            return resultado;
        }



        public List<CarrosEntity> ConsultarCarros()
        {
            listaCarros = new List<CarrosEntity> ();
            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);

            connection.Open();

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM carros";

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                CarrosEntity carroActual = new CarrosEntity ();
                carroActual.ID = reader.GetInt32(0);
                carroActual.Modelo = reader.GetString(1);
                carroActual.Placa = reader.GetString(2);
                carroActual.Dueño = reader.GetString(3);

                listaCarros.Add (carroActual);
            }
            return listaCarros;

        }

        public List<PersonasEntity> VerPersonas()
        {

            listaPersonas = new List<PersonasEntity>();
            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);
            connection.Open();


            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM personas";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PersonasEntity personas = new PersonasEntity();

                personas.ID = reader.GetInt32(0);
                personas.Nombre = reader.GetString(1);
                personas.Documento = reader.GetString(2);
                personas.Telefono = reader.GetString(3);

                listaPersonas.Add(personas);
            }

            return listaPersonas;
        }
    }

    /*
    CREATE DATABASE parqueadero;
    USE parqueadero;
     
    CREATE TABLE carros (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Modelo VARCHAR(100) NOT NULL,
    Placa VARCHAR(20) NOT NULL UNIQUE,
    dueño VARCHAR(100) NOT NULL) ENGINE=InnoDB;
     */



}
