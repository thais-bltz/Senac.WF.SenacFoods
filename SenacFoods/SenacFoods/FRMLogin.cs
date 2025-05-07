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
        { // SE nome é igual a admin Esenha é igual a 123
            if (nome == "admin" && senha == "123")
            { //RETURNA verdadeiro
                return false;
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
