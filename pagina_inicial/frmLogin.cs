using System;
using System.Windows.Forms;
using DAL.Persistence;
using DAL.Model;

namespace pagina_inicial
{
    public partial class frmLogin : Form
    {
        public bool logado = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logar();
        }

        public void logar()
        {
            try
            {
                UsuarioDAL log = new UsuarioDAL();
                Usuario u = log.FindForCode(name.Text, password.Text);


                if (u != null)
                {
                    logado = true;
                    Id_Usuario.Text = Convert.ToString(u.User_id);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                    logado = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
    }
}
