using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO [tb_condominio] " +
                        " (nome_condominio, cep, endereco, numero, complemento, cidade, estado, observacao) " +
                        " VALUES ('" + txtNome.Text + "', '" + txtCep.Text + "', '" + txtEndereco.Text + "', '" + txtNumero.Text + "', " +
                        "'" + txtComplemento.Text + "', '" + txtCidade.Text + "', '" + txtEstado.Text + "', '" + txtObservacao.Text + "')";

            conexao_banco.Open();
            cmd.ExecuteNonQuery();
            conexao_banco.Close();
            MessageBox.Show("Registro Inserido com sucesso!");

            txtNome.Text = null;
            txtCep.Text = null;
            txtEndereco.Text = null;
            txtNumero.Text = null;
            txtComplemento.Text = null;
            txtCidade.Text = null;
            txtEstado.Text = null;
            txtObservacao.Text = null;

            ListarCondominios();
            txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
        }

        public void frmcadastro_condominio_Load(object sender, EventArgs e)
        {
            ListarCondominios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Escolha um item na lista");
            }
            else
            {
                SqlConnection conexao_banco = new SqlConnection();
                conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao_banco;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "  delete from [tb_condominio] WHERE id = " + txtId.Text;

                conexao_banco.Open();
                int qtdeLinhas = cmd.ExecuteNonQuery();
                conexao_banco.Close();
                MessageBox.Show("O registro " + qtdeLinhas.ToString() + "foi excluído com sucesso!");
                ListarCondominios();
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
            }
            

        }

        public void ListarCondominios()
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT id AS Codigo, nome_condominio as [Condomínio], endereco As [Endereço], numero As Número" +
                                ", complemento As Complemento, cep As Cep,  bairro As Bairro, cidade As Cidade, estado As Estado, observacao As Observação from [tb_condominio]";

            conexao_banco.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conexao_banco.Close();
            grid_condominio.DataSource = dt;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
            txtEndereco.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
            txtNumero.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
            txtComplemento.Text = grid_condominio.SelectedRows[0].Cells[4].Value.ToString();
            txtCep.Text = grid_condominio.SelectedRows[0].Cells[5].Value.ToString();
            //txtBairro
            txtCidade.Text = grid_condominio.SelectedRows[0].Cells[7].Value.ToString();
            txtEstado.Text = grid_condominio.SelectedRows[0].Cells[8].Value.ToString();

            //txt.Text = grid_condominio.SelectedRows[0].Cells[4].Value.ToString();
        }

        
    }    
}

