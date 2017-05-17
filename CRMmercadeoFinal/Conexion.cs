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
        private static ConexionBD instance = new ConexionBD();
        private static SqlConnection conection = new System.Data.SqlClient.SqlConnection();
   
       public ConexionBD()
       {
           conection.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
           conection.Open();
       }

       public static ConexionBD getInstance()
       {
             return instance; 
       }

       public static SqlConnection getConection()
       {
           return conection;
       } 
    }
}
