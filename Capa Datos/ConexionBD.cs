using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class ConexionBD
    {
        public SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-R6IAP44;Initial Catalog=VentasBD;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            
                Conexion.Open();
                return Conexion;
            
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            
                Conexion.Close();
                return Conexion;
            
        }
    }
}

        


