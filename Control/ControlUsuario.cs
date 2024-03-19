using CRUD_sistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_sistema.Control;

public class ControlUsuario : ModelUsuario
{
    ControlDataBase comandos = new ControlDataBase();

    public void incluirUsuario(string Nome, string Cep, string Rua, string Numero, string Cidade)
    {
        comandos.adicionarUsuario(this.Nome, this.Cep, this.Rua, this.Numero, this.Cidade);
        MessageBox.Show("Usuário Incluido");
    }

    public void ExcluirUsuario(int ID)
    {
        comandos.excluirUsuario(ID);
    }

    public void TrocarSenha(string login, string senha, string novasenha)
    {
        ControlDataBase controler = new ControlDataBase();
        if (senha == novasenha)
        {
            controler.trocaSenha(login, novasenha);
            MessageBox.Show("Senha alterada");
        }
        else
        {
            MessageBox.Show("Senha não é compativel");
        }
    }
}
