using System;
using System.Windows.Forms;
using DAL.Model;
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
            Condominio CadastroCondominio = new Condominio();
            
            CadastroCondominio.setNome(txtNome.Text);
            CadastroCondominio.setCep(txtCep.Text);
            CadastroCondominio.setEndereco(txtEndereco.Text);
            CadastroCondominio.setBairro(txtBairro.Text);
            CadastroCondominio.setCidade(txtCidade.Text);
            CadastroCondominio.setEstado(txtEstado.Text);
            CadastroCondominio.setNumero(Convert.ToInt32(txtNumero.Text));
            CadastroCondominio.setComplemento(txtComplemento.Text);

            //Se o ID estiver vazio insiro um novo registro.
            if (String.IsNullOrEmpty(txtId.Text))
            {
                CadastroCondominio.InserirNoBanco();
                grid_condominio.DataSource = CadastroCondominio.ListarRegistros();
                LimparCampos();

                MessageBox.Show("Registro incluído com sucesso!");
            }
            else
            {
                CadastroCondominio.AtualizarRegistro(Convert.ToInt32(txtId.Text));
                if (MessageBox.Show("Deseja atualizar este registro?", "Atenção", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int qtdeLinhas = CadastroCondominio.AtualizarRegistro(Convert.ToInt32(txtId.Text));
                    if (qtdeLinhas == 1)
                    {

                        MessageBox.Show("Registro" + txtId.Text + " atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grid_condominio.DataSource = CadastroCondominio.ListarRegistros();
                        LimparCampos();
                    }
                }


            }





            
        }

        public void frmcadastro_condominio_Load(object sender, EventArgs e)
        {
            Condominio CadastroCondominio = new Condominio();
            grid_condominio.DataSource = CadastroCondominio.ListarRegistros();
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
                    Condominio CadastroCondominio = new Condominio();
                    int qtdeLinhas = CadastroCondominio.ExcluirBanco(Convert.ToInt32(txtId.Text));
                    if (qtdeLinhas == 1)
                    {
                        
                        MessageBox.Show("Registro" + txtId.Text +"excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grid_condominio.DataSource = CadastroCondominio.ListarRegistros();
                        LimparCampos();
                    }
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
            txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
            txtEndereco.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
            txtNumero.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
            txtComplemento.Text = grid_condominio.SelectedRows[0].Cells[4].Value.ToString();
            txtCep.Text = grid_condominio.SelectedRows[0].Cells[5].Value.ToString();
            txtBairro.Text = grid_condominio.SelectedRows[0].Cells[6].Value.ToString();
            txtCidade.Text = grid_condominio.SelectedRows[0].Cells[7].Value.ToString();
            txtEstado.Text = grid_condominio.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void LimparCampos()
        {
            txtId = null;
            txtId = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

    

