using Financeiro.Business;
using Financeiro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Gui
{
    public partial class FrmPrincipal : Form
    {
        private bool edicao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void ChangeStateControls(bool state)
        {

            dateTimePicker.Enabled = state;
            txtHora.Enabled = state;
            txtTerminal.Enabled = state;
            txtControle.Enabled = state;
            txtContaCreditada.Enabled = state;
            txtNome.Enabled = state;
            txtValor.Enabled = state;
            txtNumeroControle.Enabled = state;
            txtNumeroEnvelope.Enabled = state;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Lancamento lancamento = new Lancamento()
                {
                    Id = Convert.ToInt64(txtId.Text),
                    Data = Convert.ToDateTime(dateTimePicker.Text),
                    Hora = txtHora.Text,
                    Terminal = txtTerminal.Text,
                    Controle = txtControle.Text,
                    ContaCreditada = txtContaCreditada.Text,
                    Nome = txtNome.Text,
                    Valor = Convert.ToDecimal(txtValor.Text),
                    NumeroEnvelope = txtNumeroEnvelope.Text,
                    NumeroControle = txtNumeroControle.Text,
                };

                string mensagem = string.Empty;
                if (edicao)
                {
                    await new LancamentoBusiness().UpdateAsync(lancamento);
                    mensagem = "alterado";
                }
                else
                {
                    await new LancamentoBusiness().InsertAsync(lancamento);
                    mensagem = "incluido";
                }

                LimparControles();
                ChangeStateButtons(false);
                ChangeStateControls(false);

                MessageBox.Show(this, $"Lançamento {mensagem} com sucesso !", "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possivel gravar o lançamento \n" + ex.Message, "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void LimparControles()
        {


            foreach (var c in tabPagCadastro.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
            ChangeStateButtons(false);
            ChangeStateControls(false);
        }

        private void ChangeStateButtons(bool state)
        {
            btnSalvar.Enabled = state;
            btnExcluir.Enabled = state;
            btnLimpar.Enabled = state;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarDados();
            ChangeStateButtons(false);
            ChangeStateControls(false);

            tabPrincipal.SelectTab(0);
        }

        private async void AtualizarDados()
        {
            dataGridLancamentos.DataSource = await new LancamentoBusiness().ListAsync();
            dataGridLancamentos.Refresh();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Deseja excluir este lançamento", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await new LancamentoBusiness().RemoveAsync(Convert.ToInt32(txtId.Text));
                LimparControles();
                ChangeStateControls(false);
                ChangeStateButtons(false);


                MessageBox.Show(this, "lançamento excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            var id = await new LancamentoBusiness().NextIdAsync();
            edicao = false;
            txtId.Text = id.ToString();
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            ChangeStateControls(true);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtBuscar.Text);
                LimparControles();
                Lancamento lancamento = await new LancamentoBusiness().GetAsync(id);

                if (lancamento != null)
                {
                    edicao = true;
                    txtId.Text = lancamento.Id.ToString();
                    dateTimePicker.Value = lancamento.Data;
                    txtHora.Text = lancamento.Hora?.ToString();
                    txtTerminal.Text = lancamento?.Terminal;
                    txtControle.Text = lancamento?.Controle;
                    txtContaCreditada.Text = lancamento?.ContaCreditada;
                    txtNome.Text = lancamento?.Nome;
                    txtValor.Text = lancamento?.Valor.ToString();
                    txtNumeroControle.Text = lancamento?.NumeroControle;
                    txtNumeroEnvelope.Text = lancamento?.NumeroEnvelope;
                    ChangeStateControls(true);
                    ChangeStateButtons(true);

                }
                else
                {
                    MessageBox.Show(this, "Nenhum lançamento encontrado", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangeStateButtons(false);
                    ChangeStateControls(false);
                    LimparControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao buscar informações \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStateButtons(false);
            }
        }



        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 1)
            {
                AtualizarDados();
            }
        }
    }
}
