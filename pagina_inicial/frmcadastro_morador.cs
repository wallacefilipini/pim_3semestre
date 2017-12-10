using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Model;
using DAL.Persistence;


namespace pagina_inicial
{
    public partial class frmcadastro_morador : Form
    {
        public frmcadastro_morador()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                if (String.IsNullOrEmpty(txtIdApartamento.Text))
                {
                    MessageBox.Show("Infome o apartamento!");
                }
                else
                {
                    Morador b = new Morador();

                    b.Nome = txtNome.Text;
                    b.Data_nascimento = Convert.ToDateTime(txtNascimento.Text);
                    b.Sexo = txtSexo.Text;
                    b.Cpf = txtCPF.Text;
                    b.Rg = txtRg.Text;
                    b.Id_Apartamento = Convert.ToInt32(txtIdApartamento.SelectedValue);


                    MoradorDAL B = new MoradorDAL();
                    B.Record(b); //Gravando o condominio
                    MessageBox.Show("Morador cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtIdApartamento.Text))
                {
                    MessageBox.Show("Infome o apartamento!");
                }
                else
                {
                    Morador b = new Morador();

                    b.Nome = txtNome.Text;
                    b.Data_nascimento = Convert.ToDateTime(txtNascimento.Text);
                    b.Sexo = txtSexo.Text;
                    b.Cpf = txtCPF.Text;
                    b.Rg = txtRg.Text;
                    b.Id_Apartamento = Convert.ToInt32(txtIdApartamento.SelectedValue);
                    b.Id = Convert.ToInt32(txtId.Text);

                    MoradorDAL B = new MoradorDAL();
                    B.Update(b); //Gravando o condominio
                    MessageBox.Show("Apartamento atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();
                }

            }
        }

        private void txtIdApartamento_Click(object sender, EventArgs e)
        {
            ApartamentoDAL B = new ApartamentoDAL();
            txtIdApartamento.DataSource = B.Listar();
            txtIdApartamento.ValueMember = "Id";
            txtIdApartamento.DisplayMember = "numero_apto";
        }

        private void LimparCampos()
        {
            txtId.Text = null;
            txtNome.Text = null;
            txtNascimento.Text = null;
            txtCPF.Text = null;
            txtRg.Text = null;
            txtIdApartamento.Text = null;
            txtSexo.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AlimentarGrid()
        {
            try
            {
                MoradorDAL B = new MoradorDAL();
                grid_condominio.DataSource = B.Listar();//Popular o grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel exibir os dados" + ex);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grid_condominio.Visible = true;
            AlimentarGrid();
        }

        private void grid_condominio_Click(object sender, EventArgs e)
        {
            if (grid_condominio.Visible == true)
            {
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txtNascimento.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txtSexo.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
                txtCPF.Text = grid_condominio.SelectedRows[0].Cells[4].Value.ToString();
                txtRg.Text = grid_condominio.SelectedRows[0].Cells[5].Value.ToString();
                txtIdApartamento.ValueMember = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Escolha um item na lista");
            }
            else
            {
                if (MessageBox.Show("Deseja Excluir este registro? \nEssa ação não poderá ser desfeita!", "Atenção", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    Morador b = new Morador();
                    MoradorDAL B = new MoradorDAL();
                    b.Id = Convert.ToInt32(txtId.Text);

                    B.Delete(Convert.ToInt32(b.Id));

                    MessageBox.Show("Registro " + txtId.Text + " excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();

                }
            }
        }
    }
}
