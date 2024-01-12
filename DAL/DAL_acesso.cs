using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_sistema.DAL
{
    public class DAL_acesso
    {
        SqlConnection con = new SqlConnection();
        public DAL_acesso() 
        {
            con.ConnectionString = @"Data Source=NTCLAYTON\SQLEXPRESS;Initial Catalog=DB_SISTEMA;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection Conectar()
            
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
