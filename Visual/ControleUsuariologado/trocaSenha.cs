using erp_sistema.modelo;
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
    public partial class trocaSenha : Form
    {

        public trocaSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controle newcontrole = new controle();
            
            newcontrole.Tsenha(txb_login.Text, txb_newsenha.Text, txb_cnewsenha.Text);

        }
    }
}
