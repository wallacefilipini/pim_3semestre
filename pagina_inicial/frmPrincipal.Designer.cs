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
            this.cadastroDeBlocosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeApartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMoradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLazeresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeBlocosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarApartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMoradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLarezesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
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
            this.cadastroDeBlocosToolStripMenuItem,
            this.cadastroDeApartamentosToolStripMenuItem,
            this.cadastroDeMoradoresToolStripMenuItem,
            this.cadastroDeLazeresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
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
            // 
            // cadastroDeMoradoresToolStripMenuItem
            // 
            this.cadastroDeMoradoresToolStripMenuItem.Name = "cadastroDeMoradoresToolStripMenuItem";
            this.cadastroDeMoradoresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeMoradoresToolStripMenuItem.Text = "Cadastro de Moradores";
            // 
            // cadastroDeLazeresToolStripMenuItem
            // 
            this.cadastroDeLazeresToolStripMenuItem.Name = "cadastroDeLazeresToolStripMenuItem";
            this.cadastroDeLazeresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeLazeresToolStripMenuItem.Text = "Cadastro de Lazeres";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeBlocosToolStripMenuItem,
            this.consultarApartamentosToolStripMenuItem,
            this.consultarMoradoresToolStripMenuItem,
            this.consultarLarezesToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeBlocosToolStripMenuItem
            // 
            this.consultaDeBlocosToolStripMenuItem.Name = "consultaDeBlocosToolStripMenuItem";
            this.consultaDeBlocosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultaDeBlocosToolStripMenuItem.Text = "Consultar Blocos";
            // 
            // consultarApartamentosToolStripMenuItem
            // 
            this.consultarApartamentosToolStripMenuItem.Name = "consultarApartamentosToolStripMenuItem";
            this.consultarApartamentosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultarApartamentosToolStripMenuItem.Text = "Consultar Apartamentos";
            // 
            // consultarMoradoresToolStripMenuItem
            // 
            this.consultarMoradoresToolStripMenuItem.Name = "consultarMoradoresToolStripMenuItem";
            this.consultarMoradoresToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultarMoradoresToolStripMenuItem.Text = "Consultar Moradores";
            // 
            // consultarLarezesToolStripMenuItem
            // 
            this.consultarLarezesToolStripMenuItem.Name = "consultarLarezesToolStripMenuItem";
            this.consultarLarezesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultarLarezesToolStripMenuItem.Text = "Consultar Larezes";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pagina_inicial.Properties.Resources.Fundo_Imobiliário_Conclusão1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeBlocosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarApartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMoradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLarezesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

