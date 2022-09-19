using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencia de SQLServer
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Gestion_Clientes
    {
        //Variables Globales
        ConexionBD con = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        public void NuevoCliente(int DNI, string Nombre, int Telefono, int Edad, string Nacionalidad, string Provincia, string Localidad, int CP, string Sexo)
        {
            //Abrir la conexion con la Base de Datos
            cmd.Connection = con.AbrirConexion();
            //Declaramos el nombre de la consulta (stored procedure)"Nombre de lo que busca"
            cmd.CommandText = "NuevoCliente";
            //Sobre que busca--->Procedimientos de Almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //Declaracion de Parametros
            cmd.Parameters.AddWithValue("@DNI",DNI);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Edad", Edad);
            cmd.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);
            cmd.Parameters.AddWithValue("@Localidad", Localidad);
            cmd.Parameters.AddWithValue("@CP", CP);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            //Ejecutamos la Consulta 
            cmd.ExecuteNonQuery();
            //Cerramos la Base de Datos
            con.CerrarConexion();
            //Vaciar los parametros
            cmd.Parameters.Clear();
        }
        public void ModificarCliente(int DNI, string Nombre, int Telefono, int Edad, string Nacionalidad, string Provincia, string Localidad, int CP, string Sexo)
        {
            //Abrir la conexion con la Base de Datos
            cmd.Connection = con.AbrirConexion();
            //Declaramos el nombre de la consulta (stored procedure)"Nombre de lo que busca"
            cmd.CommandText = "ModificarCliente";
            //Sobre que busca--->Procedimientos de Almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //Declaracion de Parametros
            cmd.Parameters.AddWithValue("@DNI", DNI);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Edad", Edad);
            cmd.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);
            cmd.Parameters.AddWithValue("@Localidad", Localidad);
            cmd.Parameters.AddWithValue("@CP", CP);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            //Ejecutamos la Consulta 
            cmd.ExecuteNonQuery();
            //Cerramos la Base de Datos
            con.CerrarConexion();
            //Vaciar los parametros
            cmd.Parameters.Clear();
        }
        public void EliminarCliente(int DNI)
        {
            //Abrir la conexion con la Base de Datos
            cmd.Connection = con.AbrirConexion();
            //Declaramos el nombre de la consulta (stored procedure)"Nombre de lo que busca"
            cmd.CommandText = "ModificarCliente";
            //Sobre que busca--->Procedimientos de Almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //Declaracion de Parametros
            cmd.Parameters.AddWithValue("@DNI", DNI);
            //Ejecutamos la Consulta 
            cmd.ExecuteNonQuery();
            //Cerramos la Base de Datos
            con.CerrarConexion();
            //Vaciar los parametros
            cmd.Parameters.Clear();
        }




    }
}
