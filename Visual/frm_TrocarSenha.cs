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

namespace erp_sistema.visual
{
    public partial class frm_TrocarSenha : Form
    {

        public frm_TrocarSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlUsuario controleUsuario = new ControlUsuario();

            controleUsuario.TrocarSenha(txb_login.Text, txb_newsenha.Text, txb_cnewsenha.Text);

        }
    }
}
