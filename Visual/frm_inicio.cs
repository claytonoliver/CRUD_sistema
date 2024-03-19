using CRUD_sistema.Control;
using erp_sistema.Visual;
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
    public partial class frm_inicio : Form
    {



        public frm_inicio()
        {
            InitializeComponent();
        }


        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_TrocarSenha altersenha = new frm_TrocarSenha();
            ControlFormulario.alterarFormulario(altersenha, pnl_inicio);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            ControlFormulario.alterarFormulario(clientes, pnl_inicio);

        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_adicionarCliente formAddCliente = new frm_adicionarCliente();
            formAddCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
