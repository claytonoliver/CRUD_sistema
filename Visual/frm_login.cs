using erp_sistema.visual;
using erp_sistema.modelo;
using erp_sistema.DAL;
using erp_sistema.ControleFormulario;

namespace erp_sistema
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            controle new_controle = new controle();

            new_controle.acessar(tb_login.Text, tb_senha.Text);

            if (new_controle.tem)
            {
                frm_inicio inicio = new frm_inicio();
                ConfiguracaoFormulario.alterarFormulario(inicio, Pnl_principal);

            }
            else
            {
                MessageBox.Show("login não encontrado", "erro!", MessageBoxButtons.OK);
            }



        }
    }


}