
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
    public partial class FrmMesa : Form
    {
        Mesa? MesaSelacionado;

        internal mesaItem MesaSelecionada { get; private set; }

        public FrmMesa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var mesa = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    mesa = mesa.Where(m => m.NumeroMesa == int.Parse(txtPesquisa.Text));
                }
                dataGridView1.DataSource = mesa.ToList();
            }
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            var FrmMesaCad = new FrmMesaCad();
            FrmMesaCad.ShowDialog();
            BuscarMesa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MesaSelecionada != null)
            {


                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.mesaItem.Remove(MesaSelecionada);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Mesa excluido com suceso!", "Suceso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                MesaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione uma mesa para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MesaSelecionada != null)
            {
                var MEditar = new FrmMesaCad(MesaSelecionada);
                MEditar.ShowDialog();
                BuscarMesa();
                MesaSelecionada = null;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MesaSelecionada != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.mesaItem.Remove(MesaSelecionada);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                MesaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}