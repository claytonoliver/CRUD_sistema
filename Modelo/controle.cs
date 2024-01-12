using erp_sistema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_sistema.modelo
{

    public class controle
    {

        DAL_comandos comandos = new DAL_comandos();

        public bool tem;
        public string mensagem = "";

        public bool acessar(string login, string senha)
        {
            DAL_comandos logind = new DAL_comandos();
            tem = logind.verificarLogin(login, senha);
            if (logind.mensagem.Equals(""))
            {
                this.mensagem = logind.mensagem;
            }
            return tem;
        }

        public void Tsenha(string login, string senha, string novasenha)
        {

            if (senha == novasenha)
            {
                comandos.trocaSenha(login, novasenha);
                MessageBox.Show("Senha alterada");
            }
            else
            {
                MessageBox.Show("Senha não é compativel");
            }
        }

        public void incluirUsuario(string Nome, string Cep, string Rua, string Numero, string Cidade)
        {
            comandos.adicionarUsuario(Nome, Cep, Rua, Numero, Cidade);
            MessageBox.Show("Usuário Incluido");
        }

        public void ExcluirRegistro(int ID)
        {
            comandos.excluirUsuario(ID);
        }

    }
}
