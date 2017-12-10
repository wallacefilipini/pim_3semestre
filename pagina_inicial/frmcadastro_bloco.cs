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
    public partial class frmcadastro_bloco : Form
    {
        public frmcadastro_bloco()
        {
            InitializeComponent();
        }



        private void txtQtdAndares_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQtdApartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {

            txtId.Text = null;
            txtDescricao.Text = null;
            txtQtdAndares.Text = null;
            txtQtdApartamento.Text = null;
            txtIdCondominio.Text = null;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                if (String.IsNullOrEmpty(txtIdCondominio.Text))
                {
                    MessageBox.Show("Infome o condominio!");
                }
                else
                {
                    Bloco b = new Bloco();

                    b.Descricao = txtDescricao.Text;
                    b.Qtd_andar = Convert.ToInt32(txtQtdAndares.Text);
                    b.Qtd_apartamento = Convert.ToInt32(txtQtdApartamento.Text);
                    b.Id_condominio = Convert.ToInt32(txtIdCondominio.SelectedValue);

                    BlocoDAL B = new BlocoDAL();
                    B.Record(b); //Gravando o condominio
                    MessageBox.Show("Bloco cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();
                }
                



            }
            else
            {
                if (String.IsNullOrEmpty(txtIdCondominio.Text))
                {
                    MessageBox.Show("Infome o condominio!");
                }
                else
                {
                    Bloco b = new Bloco();

                    b.Descricao = txtDescricao.Text;
                    b.Qtd_andar = Convert.ToInt32(txtQtdAndares.Text);
                    b.Qtd_apartamento = Convert.ToInt32(txtQtdApartamento.Text);
                    b.Id_condominio = Convert.ToInt32(txtIdCondominio.SelectedValue);
                    b.Id = Convert.ToInt32(txtId.Text);

                    BlocoDAL B = new BlocoDAL();
                    B.Update(b); //Gravando o condominio
                    MessageBox.Show("Bloco atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();
                }
                
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

                    Bloco b = new Bloco();
                    BlocoDAL B = new BlocoDAL();
                    b.Id = Convert.ToInt32(txtId.Text);

                    B.Delete(Convert.ToInt32(b.Id));

                    MessageBox.Show("Registro " + txtId.Text + " excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();

                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grid_condominio.Visible = true;
            AlimentarGrid();
        }

        private void AlimentarGrid()
        {
            try
            {
                BlocoDAL B = new BlocoDAL();
                grid_condominio.DataSource = B.Listar();//Popular o grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel exibir os dados" + ex);
            }

        }

        private void grid_condominio_Click(object sender, EventArgs e)
        {
            if (grid_condominio.Visible == true)
            {
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
                txtDescricao.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txtQtdAndares.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txtQtdApartamento.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
                txtIdCondominio.ValueMember = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();
                //txtIdCondominio.Text = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();

            }
        }

        private void txtIdCondominio_Click(object sender, EventArgs e)
        {
            CondominioDAL B = new CondominioDAL();
            txtIdCondominio.DataSource = B.Listar();
            txtIdCondominio.ValueMember = "Id";
            txtIdCondominio.DisplayMember = "nome_condominio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


    }
}
