using System;
using System.Text;
using System.Windows.Forms;
using Business;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Model;
using System.Threading.Tasks;

namespace Gui
{
    public partial class FrmPrincipal : MetroForm
    {
        private bool edicao = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            metroTileSalvar.Click += MetroTile1_Click;
            metroTileLimpar.Click += MetroTileLimpar_Click;
            metroTileExcluir.Click += MetroTileExcluir_Click;
            metroTileNovo.Click += MetroTileNovo_Click;
            metroTileBuscar.Click += MetroTileBuscar_Click;
            metroTabPage2.Click += (o, s) => AtualizarDados();
            metroTabControl.Click += MetroTabControl_Click;
            Load += FrmPrincipal_Load;
        }

        private void MetroTabControl_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private async void MetroTileBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtBusca.Text);
                LimparControles();
                Lancamento lancamento = await LancamentoBusiness.GetAsync(id);

                if (lancamento != null)
                {
                    edicao = true;
                    txtId.Text = lancamento.Id.ToString();
                    txtData.Value = lancamento.Data;
                    txtHora.Text = lancamento.Hora?.ToString();
                    txtTerminal.Text = lancamento?.Terminal;
                    txtControle.Text = lancamento?.Controle;
                    txtContaCreditada.Text = lancamento?.ContaCreditada;
                    txtNome.Text = lancamento?.Nome;
                    txtValor.Text = lancamento?.Valor.ToString();
                    txtNumeroControle.Text = lancamento?.NumeroControle;
                    txtNumeroEnvelope.Text = lancamento?.NumeroEnvelope;
                    AlteraEstadoControles(true);
                    metroTileSalvar.Enabled = true;
                    metroTileLimpar.Enabled = true;
                    metroTileExcluir.Enabled = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "Nenhum lançamento encontrado", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                    metroTileSalvar.Enabled = false;
                    metroTileLimpar.Enabled = false;
                    metroTileExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Erro ao buscar informações \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                metroTileSalvar.Enabled = false;
                metroTileLimpar.Enabled = false;
                metroTileExcluir.Enabled = false;
            }

        }

        private async void MetroTileNovo_Click(object sender, EventArgs e)
        {
            var x = await LancamentoBusiness.NextIdAsync();
            edicao = false;
            txtId.Text = x.ToString();
            metroTileSalvar.Enabled = true;
            metroTileLimpar.Enabled = true;
            AlteraEstadoControles(true);
        }

        private async void MetroTileExcluir_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "Deseja excluir este lançamento", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 150);

            if (result == DialogResult.Yes)
            {
                await LancamentoBusiness.RemoveAsync(Convert.ToInt32(txtId.Text));
                LimparControles();
                AlteraEstadoControles(false);
                metroTileExcluir.Enabled = false;
                metroTileSalvar.Enabled = false;
                metroTileLimpar.Enabled = false;

                MetroMessageBox.Show(this, "lançamento excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarDados();

            metroTileSalvar.Enabled = false;
            metroTileLimpar.Enabled = false;
            metroTileExcluir.Enabled = false;
            AlteraEstadoControles(false);

            metroTabControl.SelectTab(0);
        }

        private void MetroTileLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
            metroTileExcluir.Enabled = false;
            metroTileSalvar.Enabled = false;
            metroTileLimpar.Enabled = false;
        }



        private void LimparControles()
        {
            foreach (var c in metroTabPage.Controls)
            {
                if (c is MetroTextBox)
                    (c as MetroTextBox).Text = string.Empty;
            }
        }

        private void AtualizarDados()
        {
            lancamentoBindingSource.DataSource = LancamentoBusiness.ListAsync();
        }

        private async void MetroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                Lancamento lancamento = new Lancamento()
                {
                    Id = Convert.ToInt64(txtId.Text),
                    Data = Convert.ToDateTime(txtData.Text),
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
                    await LancamentoBusiness.UpdateAsync(lancamento);
                    mensagem = "alterado";
                }
                else
                {
                    await LancamentoBusiness.InsertAsync(lancamento);
                    mensagem = "incluido";
                }

                LimparControles();
                metroTileSalvar.Enabled = false;
                metroTileExcluir.Enabled = false;
                metroTileLimpar.Enabled = false;
                MetroMessageBox.Show(this, $"Lançamento {mensagem} com sucesso !", "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Não foi possivel gravar o lançamento \n" + ex.Message, "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Hand, 150);
            }



        }


        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AlteraEstadoControles(bool estado)
        {

            txtData.Enabled = estado;
            txtHora.Enabled = estado;
            txtTerminal.Enabled = estado;
            txtControle.Enabled = estado;
            txtContaCreditada.Enabled = estado;
            txtNome.Enabled = estado;
            txtValor.Enabled = estado;
            txtNumeroControle.Enabled = estado;
            txtNumeroEnvelope.Enabled = estado;
        }
    }
}
