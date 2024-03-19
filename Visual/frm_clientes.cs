using CRUD_sistema.Control;
using CRUD_sistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp_sistema.Visual
{
    public partial class frm_clientes : Form
    {
        ControlUsuario controleUsuario = new ControlUsuario();
        public frm_clientes()
        {
            InitializeComponent();
        }
        private void CarregarGridFuncionarios()
        {
            ControlDataBase comandos = new ControlDataBase();
            DataTable tabelaFuncionarios = comandos.GridFuncionarios();
            dataGridView1.DataSource = tabelaFuncionarios;
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                CarregarGridFuncionarios();
            }
        }

        private void btn_adicionarUser_Click(object sender, EventArgs e)
        {
            frm_adicionarCliente adicionarCliente = new frm_adicionarCliente();
            adicionarCliente.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indiceLinhaSelecionada = dataGridView1.CurrentRow.Index;

                DataGridViewRow linhaSelecionada = dataGridView1.Rows[indiceLinhaSelecionada];

                int idParaExcluir = Convert.ToInt32(linhaSelecionada.Cells["ID"].Value);

                MessageBox.Show($"ID para excluir: {idParaExcluir}");

                controleUsuario.ExcluirUsuario(idParaExcluir);

                dataGridView1.Rows.Remove(linhaSelecionada);
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.");
            }
        }
    }
}


