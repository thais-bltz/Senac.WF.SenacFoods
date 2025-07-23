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
    public partial class FrmUsuarios : Form
    {
        private object usuarioSelecionado;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            BuscarUsuarios();
        }

        private void BuscarUsuarios()
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var FrmUsuariosCad = new FrmUsuariosCad();
            FrmUsuariosCad.ShowDialog();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Usuarios.Remove((Usuario)usuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Usuario excluido com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um  para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                // abrir o formulario de edição
                var frm = new FrmUsuariosCad((Usuario)usuarioSelecionado);
                frm.ShowDialog();
                // atualizar a lista de cardapio
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                // pegar o cardapio de edição
                usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
