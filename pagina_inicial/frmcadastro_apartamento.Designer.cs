﻿namespace pagina_inicial
{
    partial class frmcadastro_apartamento
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
            this.txtIdBloco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGaragem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grid_condominio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_condominio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdBloco
            // 
            this.txtIdBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdBloco.FormattingEnabled = true;
            this.txtIdBloco.Location = new System.Drawing.Point(171, 201);
            this.txtIdBloco.Name = "txtIdBloco";
            this.txtIdBloco.Size = new System.Drawing.Size(411, 28);
            this.txtIdBloco.TabIndex = 84;
            this.txtIdBloco.Click += new System.EventHandler(this.txtIdBloco_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Bloco:";
            // 
            // txtGaragem
            // 
            this.txtGaragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaragem.Location = new System.Drawing.Point(171, 164);
            this.txtGaragem.Name = "txtGaragem";
            this.txtGaragem.Size = new System.Drawing.Size(411, 26);
            this.txtGaragem.TabIndex = 83;
            this.txtGaragem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGaragem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Numero da Garagem:";
            // 
            // txtAndar
            // 
            this.txtAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAndar.Location = new System.Drawing.Point(171, 132);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(411, 26);
            this.txtAndar.TabIndex = 82;
            this.txtAndar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAndar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Andar:";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 92;
            this.button1.TabStop = false;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Lista de Apartamentos";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamento.Location = new System.Drawing.Point(172, 97);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(411, 26);
            this.txtApartamento.TabIndex = 81;
            this.txtApartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApartamento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nº Apartamento:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(171, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 26);
            this.txtId.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Código:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(174, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnExcluir.TabIndex = 88;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(187, 246);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 23);
            this.btnAlterar.TabIndex = 87;
            this.btnAlterar.Text = "VISUALIZAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.AutoEllipsis = true;
            this.btnIncluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 35);
            this.btnIncluir.TabIndex = 86;
            this.btnIncluir.TabStop = false;
            this.btnIncluir.Text = "SALVAR";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // grid_condominio
            // 
            this.grid_condominio.AllowUserToAddRows = false;
            this.grid_condominio.AllowUserToDeleteRows = false;
            this.grid_condominio.AllowUserToResizeColumns = false;
            this.grid_condominio.AllowUserToResizeRows = false;
            this.grid_condominio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_condominio.Location = new System.Drawing.Point(12, 272);
            this.grid_condominio.MultiSelect = false;
            this.grid_condominio.Name = "grid_condominio";
            this.grid_condominio.ReadOnly = true;
            this.grid_condominio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_condominio.Size = new System.Drawing.Size(735, 223);
            this.grid_condominio.TabIndex = 85;
            this.grid_condominio.TabStop = false;
            this.grid_condominio.Visible = false;
            this.grid_condominio.Click += new System.EventHandler(this.grid_condominio_Click);
            // 
            // frmcadastro_apartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 525);
            this.Controls.Add(this.txtIdBloco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGaragem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.grid_condominio);
            this.Name = "frmcadastro_apartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Apartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.grid_condominio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIdBloco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGaragem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.DataGridView grid_condominio;
    }
}