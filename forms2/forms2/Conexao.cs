using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms2
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection("Data source=localhost; Initial Catalog=ghgym; User=sa; Password=12345678 ");
        public static string msg;


        public SqlConnection ConectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception erro)
            {
                msg = "Erro ao se conectar" + erro.Message;
            }

            return con;
        }

        public SqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
            }

            catch (Exception erro)
            {
                msg = "Erro ao se conectar" + erro.Message;
            }
            return con;
        }




    }
}
