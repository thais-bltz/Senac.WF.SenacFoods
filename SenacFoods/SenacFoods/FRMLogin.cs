namespace SenacFoods
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //oculta a tela de login
            this.Hide();
            //criar uma instancia de FrmPrincipal
            var FrmPrincipal = new FrmPrincipal();
            //exibe a tela principal
            FrmPrincipal.Show();

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
