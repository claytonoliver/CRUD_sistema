namespace erp_sistema.Visual
{
    partial class frm_clientes
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
            dataGridView1 = new DataGridView();
            btn_adicionarUser = new Button();
            btn_excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // btn_adicionarUser
            // 
            btn_adicionarUser.Location = new Point(104, 304);
            btn_adicionarUser.Name = "btn_adicionarUser";
            btn_adicionarUser.Size = new Size(75, 23);
            btn_adicionarUser.TabIndex = 1;
            btn_adicionarUser.Text = "Adicionar";
            btn_adicionarUser.UseVisualStyleBackColor = true;
            btn_adicionarUser.Click += btn_adicionarUser_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(432, 304);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 23);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_excluir);
            Controls.Add(btn_adicionarUser);
            Controls.Add(dataGridView1);
            Name = "frm_clientes";
            Text = "frm_clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_adicionarUser;
        private Button btn_excluir;
    }
}