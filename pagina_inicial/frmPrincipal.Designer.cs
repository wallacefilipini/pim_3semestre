namespace pagina_inicial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Condominio = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeBlocosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeApartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMoradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLazeresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Condominio,
            this.cadastroDeBlocosToolStripMenuItem,
            this.cadastroDeApartamentosToolStripMenuItem,
            this.cadastroDeMoradoresToolStripMenuItem,
            this.cadastroDeLazeresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.cadastrosToolStripMenuItem.Text = "Ação";
            // 
            // Condominio
            // 
            this.Condominio.Name = "Condominio";
            this.Condominio.Size = new System.Drawing.Size(215, 22);
            this.Condominio.Text = "Cadastro de Condominio";
            this.Condominio.Click += new System.EventHandler(this.Condominio_Click);
            // 
            // cadastroDeBlocosToolStripMenuItem
            // 
            this.cadastroDeBlocosToolStripMenuItem.Name = "cadastroDeBlocosToolStripMenuItem";
            this.cadastroDeBlocosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeBlocosToolStripMenuItem.Text = "Cadastro de Blocos";
            this.cadastroDeBlocosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeBlocosToolStripMenuItem_Click);
            // 
            // cadastroDeApartamentosToolStripMenuItem
            // 
            this.cadastroDeApartamentosToolStripMenuItem.Name = "cadastroDeApartamentosToolStripMenuItem";
            this.cadastroDeApartamentosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeApartamentosToolStripMenuItem.Text = "Cadastro de Apartamentos";
            this.cadastroDeApartamentosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeApartamentosToolStripMenuItem_Click);
            // 
            // cadastroDeMoradoresToolStripMenuItem
            // 
            this.cadastroDeMoradoresToolStripMenuItem.Name = "cadastroDeMoradoresToolStripMenuItem";
            this.cadastroDeMoradoresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeMoradoresToolStripMenuItem.Text = "Cadastro de Moradores";
            this.cadastroDeMoradoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMoradoresToolStripMenuItem_Click);
            // 
            // cadastroDeLazeresToolStripMenuItem
            // 
            this.cadastroDeLazeresToolStripMenuItem.Name = "cadastroDeLazeresToolStripMenuItem";
            this.cadastroDeLazeresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeLazeresToolStripMenuItem.Text = "Cadastro de Lazeres";
            this.cadastroDeLazeresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLazeresToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pagina_inicial.Properties.Resources.Fundo_Imobiliário_Conclusão1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja Bem-Vindo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeBlocosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeApartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMoradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLazeresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Condominio;
    }
}

