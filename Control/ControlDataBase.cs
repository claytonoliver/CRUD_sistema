using erp_sistema.DAL;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_sistema.Control
{
    class ControlDataBase : ModelDataBase
    {
        public bool LoginValido = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ModelDataBase con = new ModelDataBase();
        SqlDataReader dr;

        public bool verificarLogin(string login, string senha)
        {
            cmd.CommandText = "select * from Funcionarios where Login = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    LoginValido = true;
                }
            }
            catch (SqlException)
            {

                mensagem = "Erro com o bano de dados";
            }

            return LoginValido;
        }

        public void trocaSenha(string login, string novasenha)
        {
            cmd.CommandText = "UPDATE Funcionarios SET Senha = @novasenha WHERE Login = @Login";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@novasenha", novasenha);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                mensagem = "Erro com o banco de dados: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public DataTable GridFuncionarios()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection conexao = con.Conectar())
                {
                    cmd.Connection = conexao;
                    cmd.CommandText = "SELECT ID, Nome, Rua, Numero, Cep, Cidade FROM Usuarios";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tabela);
                    }
                }
            }
            catch (SqlException ex)
            {
                mensagem = "Erro ao carregar dados: " + ex.Message;
            }

            return tabela;
        }

        public void adicionarUsuario(string Nome, string Cep, string Rua, string Numero, string Cidade)
        {
            cmd.CommandText = "INSERT INTO Usuarios (Nome, Rua, Numero, Cep, Cidade) VALUES (@Nome, @Rua, @Numero, @Cep, @Cidade)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Rua", Rua);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Cep", Cep);
            cmd.Parameters.AddWithValue("@Cidade", Cidade);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                mensagem = "Erro com o banco de dados: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void excluirUsuario(int ID)
        {
            cmd.CommandText = "DELETE FROM Usuarios WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                mensagem = "Erro com o banco de dados: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }
    }
}
