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
    public partial class FrmCardapioCad : Form
    {
        private CardapioItem _cardapioItem;

        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            _cardapioItem = cardapioItem;
            InitializeComponent();

            //carregar os dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            // popular os campos de texto e checkbox
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescrição.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // INSERIR
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            // ATUALIZAR
            else
            {
                AtualizarCardapio();
            }
               
        }

        private void AtualizarCardapio()
        {
            using(var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescrição.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuipreparo = chkPossuiPreparo.Checked;
                // Atualizar o cardapio
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuipreparo;
                //Salvar as alterações no banco
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirCardapio()
        {
            //Conecar
            using (var banco = new ComandaDBContext())
            {
                // Capturar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescrição.Text;
                decimal.TryParse(txtPreco.Text, out decimal preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // criar um novo cardapio
                var cardapio = new CardapioItem
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar o cardapio
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
                // salvar as alterações no banco
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
