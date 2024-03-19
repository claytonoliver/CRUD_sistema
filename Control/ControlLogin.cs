using CRUD_sistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_sistema.Control
{
    public class ControlLogin : ModelLogin
    {
        public bool Acessar(string login, string senha)
        {
            ControlDataBase Controler = new ControlDataBase();
            ValidaLogin = Controler.verificarLogin(login, senha);
            if (Controler.mensagem.Equals(""))
            {
                this.Mensagem = Controler.mensagem;
            }
            return ValidaLogin;
        }
    }
}
