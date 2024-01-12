namespace erp_sistema.visual
{
    partial class frm_inicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnl_inicio = new Panel();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            operadoresToolStripMenuItem = new ToolStripMenuItem();
            novoOperadorToolStripMenuItem = new ToolStripMenuItem();
            trocarSenhaToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            adicionarClienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            Lb_UsuarioLogado = new Label();
            imageList1 = new ImageList(components);
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 98);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 199);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 174);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Produtos";
            // 
            // pnl_inicio
            // 
            pnl_inicio.Location = new Point(145, 26);
            pnl_inicio.Margin = new Padding(3, 2, 3, 2);
            pnl_inicio.Name = "pnl_inicio";
            pnl_inicio.Size = new Size(640, 344);
            pnl_inicio.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, clientesToolStripMenuItem, produtosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(785, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operadoresToolStripMenuItem, trocarSenhaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // operadoresToolStripMenuItem
            // 
            operadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoOperadorToolStripMenuItem });
            operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            operadoresToolStripMenuItem.Size = new Size(140, 22);
            operadoresToolStripMenuItem.Text = "Operadores";
            // 
            // novoOperadorToolStripMenuItem
            // 
            novoOperadorToolStripMenuItem.Name = "novoOperadorToolStripMenuItem";
            novoOperadorToolStripMenuItem.Size = new Size(154, 22);
            novoOperadorToolStripMenuItem.Text = "Novo operador";
            // 
            // trocarSenhaToolStripMenuItem
            // 
            trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            trocarSenhaToolStripMenuItem.Size = new Size(140, 22);
            trocarSenhaToolStripMenuItem.Text = "Trocar senha";
            trocarSenhaToolStripMenuItem.Click += trocarSenhaToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // adicionarClienteToolStripMenuItem
            // 
            adicionarClienteToolStripMenuItem.Name = "adicionarClienteToolStripMenuItem";
            adicionarClienteToolStripMenuItem.Size = new Size(165, 22);
            adicionarClienteToolStripMenuItem.Text = "Adicionar Cliente";
            adicionarClienteToolStripMenuItem.Click += adicionarClienteToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // Lb_UsuarioLogado
            // 
            Lb_UsuarioLogado.AutoSize = true;
            Lb_UsuarioLogado.Location = new Point(145, 321);
            Lb_UsuarioLogado.Name = "Lb_UsuarioLogado";
            Lb_UsuarioLogado.Size = new Size(0, 15);
            Lb_UsuarioLogado.TabIndex = 8;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.BackgroundImage = CRUD_sistema.Properties.Resources.icons8_exit_50;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(32, 321);
            button1.Name = "button1";
            button1.Size = new Size(72, 58);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 382);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 10;
            label3.Text = "Sair";
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 412);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Lb_UsuarioLogado);
            Controls.Add(pnl_inicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_inicio";
            Text = "frm_inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Panel pnl_inicio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem operadoresToolStripMenuItem;
        private ToolStripMenuItem novoOperadorToolStripMenuItem;
        private ToolStripMenuItem trocarSenhaToolStripMenuItem;
        private Label Lb_UsuarioLogado;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem adicionarClienteToolStripMenuItem;
        private ImageList imageList1;
        private Button button1;
        private Label label3;
    }
}