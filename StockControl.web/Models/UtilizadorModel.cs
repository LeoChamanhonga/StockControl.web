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
                conexao.ConnectionString = "";
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    //Qery especifica p SQl server
                    comando.CommandText = string.Format(
                        "select count(*) from utilizador where login='{0}' and senha='{1}'", login, senha);
                }
            }
          
       }
    }
}