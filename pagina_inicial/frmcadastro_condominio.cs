using System;
using System.Windows.Forms;
using DAL.Model;
using DAL.Persistence;
namespace pagina_inicial
{
    public partial class frmcadastro_condominio : Form
    {
        public frmcadastro_condominio()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                Condominio c = new Condominio();

                c.Nome_condominio = txtNome.Text;
                c.Cep = txtCep.Text;
                c.Endereco = txtEndereco.Text;
                c.Bairro = txtBairro.Text;
                c.Cidade = txtCidade.Text;
                c.Estado = txtEstado.Text;
                c.Numero = Convert.ToInt32(txtNumero.Text);
                c.Complemento = txtComplemento.Text;
                c.Observacao = txtObservacao.Text;

                CondominioDAL C = new CondominioDAL();
                C.Record(c); //Gravando o condominio
                MessageBox.Show("Condominio cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlimentarGrid();
                LimparCampos();


            }
            else
            {
                Condominio c = new Condominio();

                c.Id = Convert.ToInt32(txtId.Text);
                c.Nome_condominio = txtNome.Text;
                c.Cep = txtCep.Text;
                c.Endereco = txtEndereco.Text;
                c.Bairro = txtBairro.Text;
                c.Cidade = txtCidade.Text;
                c.Estado = txtEstado.Text;
                c.Numero = Convert.ToInt32(txtNumero.Text);
                c.Complemento = txtComplemento.Text;
                c.Observacao = txtObservacao.Text;

                CondominioDAL C = new CondominioDAL();
                C.Update(c); //Gravando o condominio
                MessageBox.Show("Condominio atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlimentarGrid();
                LimparCampos();
            }
            
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
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

                    Condominio C = new Condominio();
                    CondominioDAL c = new CondominioDAL();
                    C.Id = Convert.ToInt32(txtId.Text);

                    c.Delete(Convert.ToInt32(C.Id));
                        
                    MessageBox.Show("Registro " + txtId.Text +" excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();
                    
                }
            }
        }
 
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void grid_condominio_Click(object sender, EventArgs e)
        {

            if (grid_condominio.Visible == true)
            {
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txtCep.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txtEndereco.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
                txtBairro.Text = grid_condominio.SelectedRows[0].Cells[4].Value.ToString();
                txtCidade.Text = grid_condominio.SelectedRows[0].Cells[5].Value.ToString();
                txtEstado.Text = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();
                txtNumero.Text = grid_condominio.SelectedRows[0].Cells[7].Value.ToString();
                txtComplemento.Text = grid_condominio.SelectedRows[0].Cells[8].Value.ToString();
                txtObservacao.Text = grid_condominio.SelectedRows[0].Cells[11].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            
            txtId.Text= null;
            txtNome.Text = null;
            txtCep.Text = null;
            txtEndereco.Text = null;
            txtNumero.Text = null;
            txtComplemento.Text = null;
            txtCidade.Text = null;
            txtEstado.Text = null;
            txtObservacao.Text = null;
            txtBairro.Text = null;
        }

        private void AlimentarGrid()
        {
            try
            {
                CondominioDAL c = new CondominioDAL();
                grid_condominio.DataSource = c.Listar();//Popular o grid
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

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


    }
}

    

