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
    public partial class frmcadastro_lazer : Form
    {
        public frmcadastro_lazer()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                Lazer c = new Lazer();

                c.Tipo_Lazer = txtTipoLazer.Text;
                c.Local = txtTipoLocal.Text;
                c.Observacao = txtObservacao.Text;
                
                LazerDAL C = new LazerDAL();
                C.Record(c); //Gravando o condominio
                MessageBox.Show("Lazer cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlimentarGrid();
            }
            else
            {
                Lazer c = new Lazer();

                c.Tipo_Lazer = txtTipoLazer.Text;
                c.Local = txtTipoLocal.Text;
                c.Observacao = txtObservacao.Text;
                c.Observacao = txtObservacao.Text;
                c.Id = Convert.ToInt32(txtId.Text);

                LazerDAL C = new LazerDAL();
                C.Update(c); //Gravando o condominio
                MessageBox.Show("Lazer atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlimentarGrid();
            }
        }

        private void LimparCampos()
        {

            txtId.Text = null;
            txtTipoLocal.Text = null;
            txtTipoLazer.Text = null;
            txtObservacao.Text = null;
            
        }

        private void AlimentarGrid()
        {
            try
            {
                LazerDAL c = new LazerDAL();
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

                    Lazer C = new Lazer();
                    LazerDAL c = new LazerDAL();
                    C.Id = Convert.ToInt32(txtId.Text);

                    c.Delete(Convert.ToInt32(C.Id));

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
                txtTipoLazer.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txtTipoLocal.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txtObservacao.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
