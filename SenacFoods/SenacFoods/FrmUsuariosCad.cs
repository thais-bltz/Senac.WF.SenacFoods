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
        private object _Usuario;

        public FrmUsuariosCad(Usuario usuarioSelecionado)
        {
            InitializeComponent();
        }

        public FrmUsuariosCad()
        {
            InitializeComponent();
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
            // INSERIR
            if (_Usuario == null)
            {
                InserirUsuario();
            }
            // ATUALIZAR
            else
            {
                AtualizarUsuario();
            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {

                // Atualizar o cardapio
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.);
                usuario.Nome = txtNome;
                usuario.Email = txtEmail;
                usuario.Senha = txtSenha;
                usuario.Perfil = comboBoxPerfil;
                //Salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuario salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
