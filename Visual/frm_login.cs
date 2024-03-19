using erp_sistema.visual;
using CRUD_sistema.Model;
using CRUD_sistema.Control;

namespace erp_sistema
{
    public partial class frm_login : Form
    {
        ControlLogin controleLogin = new ControlLogin();
        ControlDataBase controleDataBase = new ControlDataBase();
        public frm_login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            controleLogin.Acessar(tb_login.Text, tb_senha.Text);

            if (controleDataBase.LoginValido)
            {
                frm_inicio inicio = new frm_inicio();
                ControlFormulario.alterarFormulario(inicio, Pnl_principal);

            }
            else
            {
                MessageBox.Show("login não encontrado", "erro!", MessageBoxButtons.OK);
            }



        }
    }


}