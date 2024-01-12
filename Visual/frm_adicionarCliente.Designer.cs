namespace erp_sistema.Visual
{
    partial class frm_adicionarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            panel1 = new Panel();
            btn_cancelar = new Button();
            btn_limpar = new Button();
            btn_salvar = new Button();
            tb_cidade = new TextBox();
            tb_numero = new TextBox();
            tb_cep = new TextBox();
            tb_Rua = new TextBox();
            tb_nome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            CEP = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(305, 18);
            label6.Name = "label6";
            label6.Size = new Size(190, 28);
            label6.TabIndex = 5;
            label6.Text = "Cadastro de Clientes";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_limpar);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(tb_cidade);
            panel1.Controls.Add(tb_numero);
            panel1.Controls.Add(tb_cep);
            panel1.Controls.Add(tb_Rua);
            panel1.Controls.Add(tb_nome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CEP);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(158, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 286);
            panel1.TabIndex = 6;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(380, 256);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(203, 256);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 16;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(26, 256);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 15;
            btn_salvar.Text = "Adicionar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // tb_cidade
            // 
            tb_cidade.Location = new Point(381, 112);
            tb_cidade.Name = "tb_cidade";
            tb_cidade.Size = new Size(89, 23);
            tb_cidade.TabIndex = 14;
            // 
            // tb_numero
            // 
            tb_numero.Location = new Point(381, 152);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(33, 23);
            tb_numero.TabIndex = 13;
            // 
            // tb_cep
            // 
            tb_cep.Location = new Point(269, 152);
            tb_cep.Name = "tb_cep";
            tb_cep.Size = new Size(79, 23);
            tb_cep.TabIndex = 12;
            // 
            // tb_Rua
            // 
            tb_Rua.Location = new Point(48, 152);
            tb_Rua.Name = "tb_Rua";
            tb_Rua.Size = new Size(181, 23);
            tb_Rua.TabIndex = 11;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(61, 112);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(264, 23);
            tb_nome.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 115);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 155);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 8;
            label4.Text = "Nº";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 155);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 7;
            label3.Text = "Rua";
            // 
            // CEP
            // 
            CEP.AutoSize = true;
            CEP.Location = new Point(235, 155);
            CEP.Name = "CEP";
            CEP.Size = new Size(28, 15);
            CEP.TabIndex = 6;
            CEP.Text = "CEP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 115);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // frm_adicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "frm_adicionarCliente";
            Text = "frm_adicionarCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private TextBox tb_nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label CEP;
        private Label label1;
        private TextBox tb_cidade;
        private TextBox tb_numero;
        private TextBox tb_cep;
        private TextBox tb_Rua;
        private Button btn_cancelar;
        private Button btn_limpar;
        private Button btn_salvar;
    }
}