namespace SistemaGerenciadorLivraria
{
    partial class FrmMenu
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnFone = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.frmFuncionario1 = new SistemaGerenciadorLivraria.FrmFuncionario();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnMenu.Controls.Add(this.btnCaixa);
            this.pnMenu.Controls.Add(this.btnPedido);
            this.pnMenu.Controls.Add(this.btnAutores);
            this.pnMenu.Controls.Add(this.btnEditora);
            this.pnMenu.Controls.Add(this.btnCategoria);
            this.pnMenu.Controls.Add(this.btnLivro);
            this.pnMenu.Controls.Add(this.btnFone);
            this.pnMenu.Controls.Add(this.btnCliente);
            this.pnMenu.Controls.Add(this.btnFunc);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 691);
            this.pnMenu.TabIndex = 0;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(220, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livraria Mumuzin";
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_carrinho_de_compras_48;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 500);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(220, 50);
            this.btnCaixa.TabIndex = 9;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_nota_48;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 450);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(220, 50);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_grupos_de_usuários_48;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(0, 400);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(220, 50);
            this.btnAutores.TabIndex = 7;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            // 
            // btnEditora
            // 
            this.btnEditora.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.Color.White;
            this.btnEditora.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_caneta_esferográfica_48;
            this.btnEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.Location = new System.Drawing.Point(0, 350);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Size = new System.Drawing.Size(220, 50);
            this.btnEditora.TabIndex = 6;
            this.btnEditora.Text = "Editora";
            this.btnEditora.UseVisualStyleBackColor = false;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_categoria_48;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 300);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(220, 50);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            // 
            // btnLivro
            // 
            this.btnLivro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.Color.White;
            this.btnLivro.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_livro_aberto_48;
            this.btnLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivro.Location = new System.Drawing.Point(0, 250);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(220, 50);
            this.btnLivro.TabIndex = 4;
            this.btnLivro.Text = "Livros";
            this.btnLivro.UseVisualStyleBackColor = false;
            // 
            // btnFone
            // 
            this.btnFone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFone.FlatAppearance.BorderSize = 0;
            this.btnFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFone.ForeColor = System.Drawing.Color.White;
            this.btnFone.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_google_pixel_6_48;
            this.btnFone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.Location = new System.Drawing.Point(0, 200);
            this.btnFone.Name = "btnFone";
            this.btnFone.Size = new System.Drawing.Size(220, 50);
            this.btnFone.TabIndex = 3;
            this.btnFone.Text = "Telefone";
            this.btnFone.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_usuário_48;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 150);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(220, 50);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.Image = global::SistemaGerenciadorLivraria.Properties.Resources.icons8_usuário_90;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 100);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(220, 50);
            this.btnFunc.TabIndex = 1;
            this.btnFunc.Text = "Funcionario";
            this.btnFunc.UseVisualStyleBackColor = false;
            // 
            // frmFuncionario1
            // 
            this.frmFuncionario1.Location = new System.Drawing.Point(218, 0);
            this.frmFuncionario1.Name = "frmFuncionario1";
            this.frmFuncionario1.Size = new System.Drawing.Size(971, 691);
            this.frmFuncionario1.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1189, 691);
            this.Controls.Add(this.frmFuncionario1);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnFone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private FrmFuncionario frmFuncionario1;
    }
}