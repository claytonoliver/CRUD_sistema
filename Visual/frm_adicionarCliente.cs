using CRUD_sistema.Control;
using CRUD_sistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp_sistema.Visual
{
    
    public partial class frm_adicionarCliente : Form
    {
        ControlUsuario controleUsuario = new ControlUsuario();
        public frm_adicionarCliente()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_cep.Clear();
            tb_Rua.Clear();
            tb_numero.Clear();
            tb_cidade.Clear();   
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            controleUsuario.incluirUsuario(tb_nome.Text, tb_cep.Text, tb_Rua.Text, tb_numero.Text, tb_cidade.Text);
            
        }
    }
}
