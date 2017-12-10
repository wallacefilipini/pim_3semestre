namespace pagina_inicial
{
    partial class frmreserva_lazer
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
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.grid_condominio = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdata_agendamento = new System.Windows.Forms.MaskedTextBox();
            this.txthora_inicial = new System.Windows.Forms.MaskedTextBox();
            this.txthora_final = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.txtIdLazer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdApartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_condominio)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 123;
            this.label10.Text = "Lista de Lazeres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Hora Inicial:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(141, 200);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 23);
            this.btnAlterar.TabIndex = 119;
            this.btnAlterar.Text = "VISUALIZAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // grid_condominio
            // 
            this.grid_condominio.AllowUserToAddRows = false;
            this.grid_condominio.AllowUserToDeleteRows = false;
            this.grid_condominio.AllowUserToResizeColumns = false;
            this.grid_condominio.AllowUserToResizeRows = false;
            this.grid_condominio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_condominio.Location = new System.Drawing.Point(9, 226);
            this.grid_condominio.MultiSelect = false;
            this.grid_condominio.Name = "grid_condominio";
            this.grid_condominio.ReadOnly = true;
            this.grid_condominio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_condominio.Size = new System.Drawing.Size(914, 352);
            this.grid_condominio.TabIndex = 117;
            this.grid_condominio.TabStop = false;
            this.grid_condominio.Visible = false;
            this.grid_condominio.Click += new System.EventHandler(this.grid_condominio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Data Reserva:";
            // 
            // txtdata_agendamento
            // 
            this.txtdata_agendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdata_agendamento.Location = new System.Drawing.Point(127, 43);
            this.txtdata_agendamento.Mask = "00/00/0000";
            this.txtdata_agendamento.Name = "txtdata_agendamento";
            this.txtdata_agendamento.Size = new System.Drawing.Size(100, 26);
            this.txtdata_agendamento.TabIndex = 125;
            this.txtdata_agendamento.ValidatingType = typeof(System.DateTime);
            // 
            // txthora_inicial
            // 
            this.txthora_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txthora_inicial.Location = new System.Drawing.Point(127, 79);
            this.txthora_inicial.Mask = "90:00";
            this.txthora_inicial.Name = "txthora_inicial";
            this.txthora_inicial.Size = new System.Drawing.Size(100, 26);
            this.txthora_inicial.TabIndex = 126;
            this.txthora_inicial.ValidatingType = typeof(System.DateTime);
            // 
            // txthora_final
            // 
            this.txthora_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txthora_final.Location = new System.Drawing.Point(337, 79);
            this.txthora_final.Mask = "90:00";
            this.txthora_final.Name = "txthora_final";
            this.txthora_final.Size = new System.Drawing.Size(100, 26);
            this.txthora_final.TabIndex = 127;
            this.txthora_final.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Hora Final:";
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Crimson;
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(452, 111);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(93, 62);
            this.btnReservar.TabIndex = 130;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // txtIdLazer
            // 
            this.txtIdLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdLazer.FormattingEnabled = true;
            this.txtIdLazer.Location = new System.Drawing.Point(127, 111);
            this.txtIdLazer.Name = "txtIdLazer";
            this.txtIdLazer.Size = new System.Drawing.Size(310, 28);
            this.txtIdLazer.TabIndex = 128;
            this.txtIdLazer.Click += new System.EventHandler(this.txtIdLazer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 131;
            this.label5.Text = "Lazer:";
            // 
            // txtIdApartamento
            // 
            this.txtIdApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdApartamento.FormattingEnabled = true;
            this.txtIdApartamento.Location = new System.Drawing.Point(127, 145);
            this.txtIdApartamento.Name = "txtIdApartamento";
            this.txtIdApartamento.Size = new System.Drawing.Size(310, 28);
            this.txtIdApartamento.TabIndex = 129;
            this.txtIdApartamento.Click += new System.EventHandler(this.txtIdApartamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 133;
            this.label4.Text = "Apartamento:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(127, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Código:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(830, 111);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 62);
            this.btnExcluir.TabIndex = 136;
            this.btnExcluir.Text = "CANCELAR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(551, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 62);
            this.button1.TabIndex = 137;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmreserva_lazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdApartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdLazer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.txthora_final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthora_inicial);
            this.Controls.Add(this.txtdata_agendamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.grid_condominio);
            this.Name = "frmreserva_lazer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de lazer";
            this.Load += new System.EventHandler(this.frmreserva_lazer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_condominio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.DataGridView grid_condominio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtdata_agendamento;
        private System.Windows.Forms.MaskedTextBox txthora_inicial;
        private System.Windows.Forms.MaskedTextBox txthora_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox txtIdLazer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtIdApartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
    }
}