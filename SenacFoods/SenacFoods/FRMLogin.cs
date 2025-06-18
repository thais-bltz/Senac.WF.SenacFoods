using System.Diagnostics.Eventing.Reader;

namespace SenacFoods
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { // true, false
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            //SE true
            if (loginValido)
            {
                //oculta a tela de login
                this.Hide();
                //criar uma instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                //exibe a tela principal
                frmPrincipal.Show();

            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            //CONECTA NO BANCO
            using (var banco = new ComandaDBContext())
            {
                //CONSULTAR A TABELA USUARIO SELECT * FROM USUARIOS WHERE EMAIL = ? ANO SENHA = ?
                var usuario = banco. Usuarios. FirstOrDefault(u => u.Email == nome && u.Senha == senha);
                if (usuario is not null)
                    usuarioValido = true;
            }
                // SE nome é igual a admin Esenha é igual a 123
                if (usuarioValido)
                { //RETURNA verdadeiro
                    return true;
                }
                else
                { //EXIBE uma mensagem de erro
                    MessageBox.Show("Login ou Senha inválidos");
                    //RETORNA false
                    return false;
                }
        }

                private void btnFechar_Click(object sender, EventArgs e)
                {
                    // fecha a tela de login
                    Close();
                    // encerra o aplicativo
                    Application.Exit();
                }
    }
}
