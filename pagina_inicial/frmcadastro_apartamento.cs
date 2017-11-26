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
    public partial class frmcadastro_apartamento : Form
    {
        public frmcadastro_apartamento()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                if (String.IsNullOrEmpty(txtIdBloco.Text))
                {
                    MessageBox.Show("Infome o bloco!");
                }
                else
                {
                    Apartamento b = new Apartamento();

                    b.Numero_apto = Convert.ToInt32(txtApartamento.Text);
                    b.Andar_apto = Convert.ToInt32(txtAndar.Text);
                    b.Numero_garagem = Convert.ToInt32(txtGaragem.Text);
                    b.Id_Bloco = Convert.ToInt32(txtIdBloco.SelectedValue);

                    ApartamentoDAL B = new ApartamentoDAL();
                    B.Record(b); //Gravando o condominio
                    MessageBox.Show("Apartamento cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                }




            }
            else
            {
                if (String.IsNullOrEmpty(txtIdBloco.Text))
                {
                    MessageBox.Show("Infome o bloco!");
                }
                else
                {
                    Apartamento b = new Apartamento();

                    b.Numero_apto = Convert.ToInt32(txtApartamento.Text);
                    b.Andar_apto = Convert.ToInt32(txtAndar.Text);
                    b.Numero_garagem = Convert.ToInt32(txtGaragem.Text);
                    b.Id_Bloco = Convert.ToInt32(txtIdBloco.SelectedValue);
                    b.Id = Convert.ToInt32(txtId.Text);

                    ApartamentoDAL B = new ApartamentoDAL();
                    B.Update(b); //Gravando o condominio
                    MessageBox.Show("Apartamento atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                }

            }
        }

        private void txtIdBloco_Click(object sender, EventArgs e)
        {
            BlocoDAL B = new BlocoDAL();
            txtIdBloco.DataSource = B.Listar();
            txtIdBloco.ValueMember = "Id";
            txtIdBloco.DisplayMember = "descricao";
        }

        private void txtApartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtAndar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtGaragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void AlimentarGrid()
        {
            try
            {
                ApartamentoDAL B = new ApartamentoDAL();
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

        private void LimparCampos()
        {
            txtId.Text = null;
            txtAndar.Text = null;
            txtApartamento.Text = null;
            txtGaragem.Text = null;
            txtIdBloco.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

                    Apartamento b = new Apartamento();
                    ApartamentoDAL B = new ApartamentoDAL();
                    b.Id = Convert.ToInt32(txtId.Text);

                    B.Delete(Convert.ToInt32(b.Id));

                    MessageBox.Show("Registro " + txtId.Text + " excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();

                }
            }
        }

        private void grid_condominio_Click(object sender, EventArgs e)
        {
            if (grid_condominio.Visible == true)
            {
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
                txtApartamento.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txtAndar.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txtGaragem.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
                txtIdBloco.ValueMember = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();

                
            }
        }
    }
}
