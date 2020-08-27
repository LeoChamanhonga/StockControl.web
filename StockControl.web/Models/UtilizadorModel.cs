using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StockControl.web.Models
{
    public class UtilizadorModel
    {
       public static bool ValidarUtilizador(string login, string senha)
       {
            using (var conexao = new SqlConnection())
            {
               
            }
          
       }
    }
}