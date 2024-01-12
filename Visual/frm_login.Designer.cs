namespace erp_sistema
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            Pnl_principal = new Panel();
            tb_senha = new TextBox();
            tb_login = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pnl_principal
            // 
            Pnl_principal.Controls.Add(tb_senha);
            Pnl_principal.Controls.Add(tb_login);
            Pnl_principal.Controls.Add(label2);
            Pnl_principal.Controls.Add(label1);
            Pnl_principal.Controls.Add(pictureBox1);
            Pnl_principal.Controls.Add(button1);
            Pnl_principal.Location = new Point(-1, 0);
            Pnl_principal.Name = "Pnl_principal";
            Pnl_principal.Size = new Size(801, 451);
            Pnl_principal.TabIndex = 0;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(553, 194);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(158, 23);
            tb_senha.TabIndex = 11;
            // 
            // tb_login
            // 
            tb_login.Location = new Point(553, 154);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(158, 23);
            tb_login.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 202);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 157);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(553, 266);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_principal);
            Name = "frm_login";
            Text = "Form1";
            Pnl_principal.ResumeLayout(false);
            Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb_senha;
        private TextBox tb_login;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        public Panel Pnl_principal;
    }
}