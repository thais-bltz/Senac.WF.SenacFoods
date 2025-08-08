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

    public partial class FrmMesaCad : Form
    {

        private mesaItem _mesaItem;
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        public FrmMesaCad(mesaItem mesaItem)
        {
            _mesaItem = mesaItem;
            InitializeComponent();
            // carregar os dados da tela
            CarregarDadosNaTela();

        }
        //metodo que gera o evento de carregamento do form
        private void CarregarDadosNaTela()
        {
            //popular os campos de texto e checkbox
            if (_mesaItem != null)
            {
                txtNumeroMesa.Text = _mesaItem.NumeroMesa;

            }
        }

        private void btnSalvarMesa_Click(object sender, EventArgs e)
        {   //INSERIR
            if (_mesaItem == null)
            {
                InserirMesa();
            }
            //ATUALIZAR
            else
            {
                AtualizarMesa();
            }

        }

        private void AtualizarMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                var mesa = banco.Mesas.First(x => x.Id == _mesaItem.Id);

                int.TryParse(txtNumeroMesa.Text, out var numeroMesa);

                mesa.NumeroMesa = numeroMesa;// atualizar o numero da mesa
                banco.Mesas.Update(mesa);// atualizar o cardapio
                banco.SaveChanges(); // salvar as alterações no banco



            }
            MessageBox.Show("Mesa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                var mesa = banco.Mesas.First(x => x.Id == _mesaItem.Id);

                int.TryParse(txtNumeroMesa.Text, out var numeroMesa);

                var mesas = new Mesa()
                {
                    NumeroMesa = numeroMesa,

                };

                banco.Mesas.Add(mesa);// atualizar o cardapio
                banco.SaveChanges(); // salvar as alterações no banco



            }
            MessageBox.Show("Mesa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroMesa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}