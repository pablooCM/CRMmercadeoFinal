using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRMmercadeoFinal
{
    class ConexionBD
    {
        
        public static SqlConnection establecerConexion()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();
        }

        public static string conexion { get; set; }
    }
}
