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
    public partial class FrmCardápio : Form
    {
        public FrmCardápio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCardápio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            // Conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // Consultar a tabela cardapioItem
                var cardapios = bd.CardapioItems.ToList();

                // popular o grid com a tabela consultanda
                dataGridView1.DataSource = cardapios;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }
    }
}
