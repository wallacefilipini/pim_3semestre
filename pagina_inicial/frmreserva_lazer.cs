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
    public partial class frmreserva_lazer : Form
    {
        public frmreserva_lazer()
        {
            InitializeComponent();
        }

        private void frmreserva_lazer_Load(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            //Verifico se todos os campos estão preenchidos
            if (! txtdata_agendamento.MaskFull)
            {
                MessageBox.Show("Informe a data do agendamento!");
                txtdata_agendamento.Focus();
            }
            else if (! txthora_inicial.MaskFull)
            {
                MessageBox.Show("Informe a hora inicial!");
                txthora_inicial.Focus();
            }
            
            else if (! txthora_final.MaskFull)
            {
                MessageBox.Show("Informe a hora final");
                txthora_final.Focus();
            }
            else if (String.IsNullOrEmpty(txtIdLazer.Text))
            {
                MessageBox.Show("Informe o lazer!");
                txtIdLazer.Focus();
            }
            else if (String.IsNullOrEmpty(txtIdApartamento.Text))
            {
                MessageBox.Show("Informe o apartamento!");
                txtIdApartamento.Focus();
            }
            //Se tudo estiver preenchido, verifico se tem lazer livre para a data e horario escolhidos
            else
            {
                ReservaDAL verifica = new ReservaDAL();

                DateTime data_reserva = Convert.ToDateTime(txtdata_agendamento.Text);
                DateTime hora_inicial = Convert.ToDateTime(txthora_inicial.Text);
                DateTime hora_final = Convert.ToDateTime(txthora_final.Text);
                int id_lazer = Convert.ToInt32(txtIdLazer.SelectedValue);

                Reserva verificaReserva = verifica.FindForCode(data_reserva, hora_inicial, hora_final, id_lazer);

                int qtdReserva = verificaReserva.verifica;

                if (qtdReserva > 0)
                {
                    MessageBox.Show("Já existe uma reserva para este lazer e horário!");
                }
                else
                {
                    
                    Reserva c = new Reserva();

                    c.Data_agendamento = Convert.ToDateTime(txtdata_agendamento.Text);
                    c.Hora_inicial = Convert.ToDateTime(txthora_inicial.Text);
                    c.Hora_final = Convert.ToDateTime(txthora_final.Text);
                    c.Id_lazer = Convert.ToInt32(txtIdLazer.SelectedValue);
                    c.id_apartamento = Convert.ToInt32(txtIdApartamento.SelectedValue);

                    


                    ReservaDAL C = new ReservaDAL();
                    C.Record(c); //Gravando o condominio
                    MessageBox.Show("Reserva cadastrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     AlimentarGrid();
                    LimparCampos();
                    
                    
                        
                    
                }
            }
            



        }

        private void txtIdLazer_Click(object sender, EventArgs e)
        {
            LazerDAL B = new LazerDAL();
            txtIdLazer.DataSource = B.Listar();
            txtIdLazer.ValueMember = "Id";
            txtIdLazer.DisplayMember = "tipo_lazer";
        }

        private void txtIdApartamento_Click(object sender, EventArgs e)
        {
            ApartamentoDAL B = new ApartamentoDAL();
            txtIdApartamento.DataSource = B.Listar();
            txtIdApartamento.ValueMember = "Id";
            txtIdApartamento.DisplayMember = "numero_apto";
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
                ReservaDAL c = new ReservaDAL();
                grid_condominio.DataSource = c.Listar();//Popular o grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel exibir os dados" + ex);
            }

        }

        private void LimparCampos()
        {

            txtdata_agendamento.Text = null;
            txthora_inicial.Text = null;
            txthora_inicial.Text = null;
            txtIdLazer.Text = null;
            txtIdApartamento.Text = null;

        }

        private void grid_condominio_Click(object sender, EventArgs e)
        {
            if (grid_condominio.Visible == true)
            {
                txtId.Text = grid_condominio.SelectedRows[0].Cells[0].Value.ToString();
                txtdata_agendamento.Text = grid_condominio.SelectedRows[0].Cells[1].Value.ToString();
                txthora_inicial.Text = grid_condominio.SelectedRows[0].Cells[2].Value.ToString();
                txthora_final.Text = grid_condominio.SelectedRows[0].Cells[3].Value.ToString();
                txtIdLazer.ValueMember = grid_condominio.SelectedRows[0].Cells[5].Value.ToString();
                txtIdApartamento.ValueMember = grid_condominio.SelectedRows[0].Cells[7].Value.ToString();


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

                    Reserva b = new Reserva();
                    ReservaDAL B = new ReservaDAL();
                    b.Id = Convert.ToInt32(txtId.Text);

                    B.Delete(Convert.ToInt32(b.Id));

                    MessageBox.Show("Registro " + txtId.Text + " excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlimentarGrid();
                    LimparCampos();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
