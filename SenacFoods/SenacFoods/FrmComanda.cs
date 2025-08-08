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
    public partial class FrmComanda : Form
    {
        public object ComandaSelecionada { get; private set; }

        public FrmComanda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ComandaSelecionada != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.ComandaItems.Remove((ComandaItem)ComandaSelecionada);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Comanda excluida com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarComanda();
                ComandaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione uma comanda para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarComanda()
        {
            // Conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // Consultar a tabela cardapioItem
                var comandas = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    comandas = comandas.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                    c.Descricao.Contains(txtPesquisa.Text));
                }

                // popular o grid com a tabela consultanda
                dataGridView1.DataSource = comandas.ToList();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarComanda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ComandaSelecionada != null)
            {
                // abrir o formulario de edição
                var frm = new FrmComandaCad(ComandaSelecionada);
                frm.ShowDialog();
                // atualizar a lista de cardapio
                BuscarComanda();
                ComandaSelecionada = null;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
