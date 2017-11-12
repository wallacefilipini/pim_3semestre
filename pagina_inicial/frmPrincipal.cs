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
            frmcadastro_condominio frmCadastroBloco = new frmcadastro_condominio();
            frmCadastroBloco.ShowDialog();
        }
    }
}
