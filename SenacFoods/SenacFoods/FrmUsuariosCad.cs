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
    public partial class FrmUsuariosCad : Form
    {
        private Usuario _usuarioItem;
        private Usuario? usuarioItem;
        

        public FrmUsuariosCad(Usuario usuarioItem)
        {
            InitializeComponent();
        }

        public FrmUsuariosCad(object usuarioSelecionado)
        {
            _usuarioItem = usuarioItem;
            InitializeComponent();

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_usuarioItem == null)
            {
                txtNome.Text = _usuarioItem.Nome;
                txtEmail.Text = _usuarioItem.Email;
                txtSenha.Text = _usuarioItem.Senha;
                txtConfirmacaoDeSenha.Text = _usuarioItem.ConfirmacaoDeSenha;
                comboBoxPerfil.Text = _usuarioItem.Perfil;
            }
        }

        public FrmUsuariosCad()
        {
        }

        private void comboBoxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            using (var banco = new ComandaDBContext())
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                
                var usuario = new Usuario();
                {
                    nome = nome;
                    email = email;
                    senha = senha;
                    
                }
            }
        }

        private void AtualizarUsuario()
        {
            if(!ValidarCampos())
                 return; 
            using (var banco = new ComandaDBContext())
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                string perfil = comboBoxPerfil.Text;

                // Atualizar o usuario
                var usuario = new Usuario
                { 
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Perfil = perfil,
                };
                //Salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
                MessageBox.Show("Usuario salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
        }

        private bool ValidarCampos()
        {
            throw new NotImplementedException();
        }

        private void InserirUsuario()
        {
            //Conecar
            using (var banco = new ComandaDBContext())
            {
                var usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    Perfil = comboBoxPerfil.Text
                };
                // adicionar o cardapio
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();
                // salvar as alterações no banco
            }
            MessageBox.Show("Usuario salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void FrmUsuariosCad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmacaoDeSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
