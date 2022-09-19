using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias de SQL Server
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//Referenciar a la capa de datos
using Capa_Datos;
using Soportes;


namespace Capa_Datos
{                           //Herencia de datos
    public class Gestion_De_Usuario : ConexionBD
    {
        //Metodo de verificacion de usuario
        public bool Login(string Usuario, string Clave)
        { 
            using (var comando = new SqlCommand())
            {
                AbrirConexion();
                //Sqlcommand --> Se utiliza para las consultas de sql, como un CRUD.
                //Asignamos al comando la ruta de la BD
                comando.Connection = Conexion;

                //Creamos la consulta de SQLserver
                comando.CommandText = "select * from UsuariosBD Where Usuario=@Usuario and Clave=@Clave";
                //Asingamos los parametros
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Clave", Clave);
                //Indicamos el tipo de consultas
                comando.CommandType = CommandType.Text;
                //Busqueda de los datos -->Datos asociados a los campos claves
                SqlDataReader Buscar = comando.ExecuteReader();
                //Condicional de busqueda
                if (Buscar.HasRows)
                {
                    while (Buscar.Read())
                    {
                        Cache.DNI = Buscar.GetString(0);
                        Cache.Usuario = Buscar.GetString(1);
                        Cache.Clave = Buscar.GetString(2);
                        Cache.Nombre = Buscar.GetString(3);
                        Cache.Tipo = Buscar.GetString(4);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }    
    }
}