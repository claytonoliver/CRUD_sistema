namespace erp_sistema.visual
{
    partial class trocaSenha
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
            btn_salvar = new Button();
            txb_cnewsenha = new TextBox();
            txb_newsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_login = new TextBox();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(277, 208);
            btn_salvar.Margin = new Padding(3, 2, 3, 2);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(82, 22);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button1_Click;
            // 
            // txb_cnewsenha
            // 
            txb_cnewsenha.Location = new Point(343, 159);
            txb_cnewsenha.Margin = new Padding(3, 2, 3, 2);
            txb_cnewsenha.Name = "txb_cnewsenha";
            txb_cnewsenha.PasswordChar = '*';
            txb_cnewsenha.Size = new Size(110, 23);
            txb_cnewsenha.TabIndex = 1;
            // 
            // txb_newsenha
            // 
            txb_newsenha.Location = new Point(343, 125);
            txb_newsenha.Margin = new Padding(3, 2, 3, 2);
            txb_newsenha.Name = "txb_newsenha";
            txb_newsenha.PasswordChar = '*';
            txb_newsenha.Size = new Size(110, 23);
            txb_newsenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 125);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite a nova senha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 161);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Confirme a senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 93);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "Digite seu login";
            // 
            // txb_login
            // 
            txb_login.Location = new Point(343, 93);
            txb_login.Margin = new Padding(3, 2, 3, 2);
            txb_login.Name = "txb_login";
            txb_login.Size = new Size(110, 23);
            txb_login.TabIndex = 5;
            // 
            // trocaSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(txb_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_newsenha);
            Controls.Add(txb_cnewsenha);
            Controls.Add(btn_salvar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "trocaSenha";
            Text = "trocaSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txb_cnewsenha;
        public TextBox txb_newsenha;
        public TextBox txb_login;
    }
}