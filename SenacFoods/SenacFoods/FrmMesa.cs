
namespace SenacFoods
{
    public partial class FrmMesa : Form
    {
        Mesa? MesaSelacionado;
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        { }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }