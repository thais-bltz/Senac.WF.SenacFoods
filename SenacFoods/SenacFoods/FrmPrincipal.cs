using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            //exibe o nome do usuario na tela principal
            lblMensagem.Text = "Bem Vinda " + nome;
        }



        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            // fecha a tela principal
            Close();
            // cria uma instancia da tela de login
            var FrmLogin = new FRMLogin();
            // exibe a tela de login
            FrmLogin.Show();
        }

        private void btnCardápio_Click(object sender, EventArgs e)
        {
            // cria uma instancia do FrmCardápio
            var FrmCardápio = new FrmCardápio();
            // exibe a tela de cardápio em estilo modal()
            FrmCardápio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //altera o estado da tela
            //para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var FrmComanda = new FrmComanda();
            FrmComanda.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedidoCozinha();
            frmPedido.ShowDialog();
        }
       private void btnUsuário_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
} 
