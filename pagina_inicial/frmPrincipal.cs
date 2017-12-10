using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;

namespace pagina_inicial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void cadastroDeBlocosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastro_bloco frmCadastro_Bloco = new frmcadastro_bloco();
            frmCadastro_Bloco.ShowDialog();
        }

        private void Condominio_Click(object sender, EventArgs e)
        {
            frmcadastro_condominio frmCadastroCondominio = new frmcadastro_condominio();
            frmCadastroCondominio.ShowDialog();
        }

        private void cadastroDeApartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastro_apartamento frmCadastroApartamento = new frmcadastro_apartamento();
            frmCadastroApartamento.ShowDialog();
        }

        private void cadastroDeMoradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastro_morador frmCadastroMorador = new frmcadastro_morador();
            frmCadastroMorador.ShowDialog();
        }

        private void cadastroDeLazeresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastro_lazer frmCadastroLazer = new frmcadastro_lazer();
            frmCadastroLazer.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreserva_lazer FrmReserva = new frmreserva_lazer();
            FrmReserva.ShowDialog();
        }
    }
}
