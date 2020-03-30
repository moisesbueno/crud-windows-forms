using Model;

namespace Gui
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtBusca = new MetroFramework.Controls.MetroTextBox();
            this.metroTileBuscar = new MetroFramework.Controls.MetroTile();
            this.txtHora = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroTileNovo = new MetroFramework.Controls.MetroTile();
            this.metroTileSalvar = new MetroFramework.Controls.MetroTile();
            this.metroTileExcluir = new MetroFramework.Controls.MetroTile();
            this.metroTileLimpar = new MetroFramework.Controls.MetroTile();
            this.txtTerminal = new MetroFramework.Controls.MetroTextBox();
            this.txtControle = new MetroFramework.Controls.MetroTextBox();
            this.txtNumeroControle = new MetroFramework.Controls.MetroTextBox();
            this.txtNumeroEnvelope = new MetroFramework.Controls.MetroTextBox();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.txtContaCreditada = new MetroFramework.Controls.MetroTextBox();
            this.txtData = new MetroFramework.Controls.MetroDateTime();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaCreditadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEnvelopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroControleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(1035, 511);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage
            // 
            this.metroTabPage.Controls.Add(this.metroLabel10);
            this.metroTabPage.Controls.Add(this.metroLabel9);
            this.metroTabPage.Controls.Add(this.metroLabel8);
            this.metroTabPage.Controls.Add(this.metroLabel7);
            this.metroTabPage.Controls.Add(this.metroLabel6);
            this.metroTabPage.Controls.Add(this.metroLabel5);
            this.metroTabPage.Controls.Add(this.metroLabel4);
            this.metroTabPage.Controls.Add(this.metroLabel3);
            this.metroTabPage.Controls.Add(this.metroLabel2);
            this.metroTabPage.Controls.Add(this.metroLabel1);
            this.metroTabPage.Controls.Add(this.txtId);
            this.metroTabPage.Controls.Add(this.txtBusca);
            this.metroTabPage.Controls.Add(this.metroTileBuscar);
            this.metroTabPage.Controls.Add(this.txtHora);
            this.metroTabPage.Controls.Add(this.txtNome);
            this.metroTabPage.Controls.Add(this.metroTileNovo);
            this.metroTabPage.Controls.Add(this.metroTileSalvar);
            this.metroTabPage.Controls.Add(this.metroTileExcluir);
            this.metroTabPage.Controls.Add(this.metroTileLimpar);
            this.metroTabPage.Controls.Add(this.txtTerminal);
            this.metroTabPage.Controls.Add(this.txtControle);
            this.metroTabPage.Controls.Add(this.txtNumeroControle);
            this.metroTabPage.Controls.Add(this.txtNumeroEnvelope);
            this.metroTabPage.Controls.Add(this.txtValor);
            this.metroTabPage.Controls.Add(this.txtContaCreditada);
            this.metroTabPage.Controls.Add(this.txtData);
            this.metroTabPage.HorizontalScrollbarBarColor = true;
            this.metroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage.HorizontalScrollbarSize = 10;
            this.metroTabPage.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage.Name = "metroTabPage";
            this.metroTabPage.Size = new System.Drawing.Size(1027, 469);
            this.metroTabPage.TabIndex = 0;
            this.metroTabPage.Text = "Cadastro";
            this.metroTabPage.UseCustomForeColor = true;
            this.metroTabPage.VerticalScrollbarBarColor = true;
            this.metroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 19);
            this.metroLabel10.TabIndex = 36;
            this.metroLabel10.Text = "N° Envelope";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 223);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Nome";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 194);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "C .Creditada";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 315);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "N° Controle";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 252);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Valor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 136);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Terminal";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Controle";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Hora";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Data";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Id";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(87, 45);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(120, 23);
            this.txtId.TabIndex = 26;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBusca
            // 
            // 
            // 
            // 
            this.txtBusca.CustomButton.Image = null;
            this.txtBusca.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtBusca.CustomButton.Name = "";
            this.txtBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusca.CustomButton.TabIndex = 1;
            this.txtBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusca.CustomButton.UseSelectable = true;
            this.txtBusca.CustomButton.Visible = false;
            this.txtBusca.Lines = new string[0];
            this.txtBusca.Location = new System.Drawing.Point(300, 16);
            this.txtBusca.MaxLength = 32767;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusca.SelectedText = "";
            this.txtBusca.SelectionLength = 0;
            this.txtBusca.SelectionStart = 0;
            this.txtBusca.ShortcutsEnabled = true;
            this.txtBusca.Size = new System.Drawing.Size(75, 23);
            this.txtBusca.TabIndex = 4;
            this.txtBusca.UseSelectable = true;
            this.txtBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTileBuscar
            // 
            this.metroTileBuscar.ActiveControl = null;
            this.metroTileBuscar.BackColor = System.Drawing.Color.Yellow;
            this.metroTileBuscar.ForeColor = System.Drawing.Color.Black;
            this.metroTileBuscar.Location = new System.Drawing.Point(381, 3);
            this.metroTileBuscar.Name = "metroTileBuscar";
            this.metroTileBuscar.Size = new System.Drawing.Size(65, 36);
            this.metroTileBuscar.TabIndex = 5;
            this.metroTileBuscar.Text = "Buscar";
            this.metroTileBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBuscar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileBuscar.UseCustomBackColor = true;
            this.metroTileBuscar.UseCustomForeColor = true;
            this.metroTileBuscar.UseSelectable = true;
            // 
            // txtHora
            // 
            // 
            // 
            // 
            this.txtHora.CustomButton.Image = null;
            this.txtHora.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtHora.CustomButton.Name = "";
            this.txtHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHora.CustomButton.TabIndex = 1;
            this.txtHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHora.CustomButton.UseSelectable = true;
            this.txtHora.CustomButton.Visible = false;
            this.txtHora.Lines = new string[0];
            this.txtHora.Location = new System.Drawing.Point(87, 103);
            this.txtHora.MaxLength = 32767;
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.PromptText = "hh:mm:ss";
            this.txtHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHora.SelectedText = "";
            this.txtHora.SelectionLength = 0;
            this.txtHora.SelectionStart = 0;
            this.txtHora.ShortcutsEnabled = true;
            this.txtHora.Size = new System.Drawing.Size(120, 23);
            this.txtHora.TabIndex = 7;
            this.txtHora.UseSelectable = true;
            this.txtHora.WaterMark = "hh:mm:ss";
            this.txtHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(87, 219);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(344, 23);
            this.txtNome.TabIndex = 11;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTileNovo
            // 
            this.metroTileNovo.ActiveControl = null;
            this.metroTileNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroTileNovo.ForeColor = System.Drawing.Color.Black;
            this.metroTileNovo.Location = new System.Drawing.Point(0, 3);
            this.metroTileNovo.Name = "metroTileNovo";
            this.metroTileNovo.Size = new System.Drawing.Size(65, 36);
            this.metroTileNovo.TabIndex = 0;
            this.metroTileNovo.Text = "Novo";
            this.metroTileNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileNovo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileNovo.UseCustomBackColor = true;
            this.metroTileNovo.UseCustomForeColor = true;
            this.metroTileNovo.UseSelectable = true;
            // 
            // metroTileSalvar
            // 
            this.metroTileSalvar.ActiveControl = null;
            this.metroTileSalvar.BackColor = System.Drawing.Color.SpringGreen;
            this.metroTileSalvar.ForeColor = System.Drawing.Color.Black;
            this.metroTileSalvar.Location = new System.Drawing.Point(71, 3);
            this.metroTileSalvar.Name = "metroTileSalvar";
            this.metroTileSalvar.Size = new System.Drawing.Size(65, 36);
            this.metroTileSalvar.TabIndex = 1;
            this.metroTileSalvar.Text = "Salvar";
            this.metroTileSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSalvar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSalvar.UseCustomBackColor = true;
            this.metroTileSalvar.UseCustomForeColor = true;
            this.metroTileSalvar.UseSelectable = true;
            // 
            // metroTileExcluir
            // 
            this.metroTileExcluir.ActiveControl = null;
            this.metroTileExcluir.BackColor = System.Drawing.Color.Red;
            this.metroTileExcluir.ForeColor = System.Drawing.Color.Black;
            this.metroTileExcluir.Location = new System.Drawing.Point(213, 3);
            this.metroTileExcluir.Name = "metroTileExcluir";
            this.metroTileExcluir.Size = new System.Drawing.Size(65, 36);
            this.metroTileExcluir.TabIndex = 3;
            this.metroTileExcluir.Text = "Excluir";
            this.metroTileExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExcluir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileExcluir.UseCustomBackColor = true;
            this.metroTileExcluir.UseCustomForeColor = true;
            this.metroTileExcluir.UseSelectable = true;
            // 
            // metroTileLimpar
            // 
            this.metroTileLimpar.ActiveControl = null;
            this.metroTileLimpar.BackColor = System.Drawing.Color.Gold;
            this.metroTileLimpar.ForeColor = System.Drawing.Color.Black;
            this.metroTileLimpar.Location = new System.Drawing.Point(142, 3);
            this.metroTileLimpar.Name = "metroTileLimpar";
            this.metroTileLimpar.Size = new System.Drawing.Size(65, 36);
            this.metroTileLimpar.TabIndex = 2;
            this.metroTileLimpar.Text = "Limpar";
            this.metroTileLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLimpar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileLimpar.UseCustomBackColor = true;
            this.metroTileLimpar.UseCustomForeColor = true;
            this.metroTileLimpar.UseSelectable = true;
            // 
            // txtTerminal
            // 
            // 
            // 
            // 
            this.txtTerminal.CustomButton.Image = null;
            this.txtTerminal.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtTerminal.CustomButton.Name = "";
            this.txtTerminal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTerminal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTerminal.CustomButton.TabIndex = 1;
            this.txtTerminal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTerminal.CustomButton.UseSelectable = true;
            this.txtTerminal.CustomButton.Visible = false;
            this.txtTerminal.Lines = new string[0];
            this.txtTerminal.Location = new System.Drawing.Point(87, 132);
            this.txtTerminal.MaxLength = 32767;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.PasswordChar = '\0';
            this.txtTerminal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTerminal.SelectedText = "";
            this.txtTerminal.SelectionLength = 0;
            this.txtTerminal.SelectionStart = 0;
            this.txtTerminal.ShortcutsEnabled = true;
            this.txtTerminal.Size = new System.Drawing.Size(120, 23);
            this.txtTerminal.TabIndex = 8;
            this.txtTerminal.UseSelectable = true;
            this.txtTerminal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTerminal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtControle
            // 
            // 
            // 
            // 
            this.txtControle.CustomButton.Image = null;
            this.txtControle.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtControle.CustomButton.Name = "";
            this.txtControle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtControle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtControle.CustomButton.TabIndex = 1;
            this.txtControle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtControle.CustomButton.UseSelectable = true;
            this.txtControle.CustomButton.Visible = false;
            this.txtControle.Lines = new string[0];
            this.txtControle.Location = new System.Drawing.Point(87, 161);
            this.txtControle.MaxLength = 32767;
            this.txtControle.Name = "txtControle";
            this.txtControle.PasswordChar = '\0';
            this.txtControle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtControle.SelectedText = "";
            this.txtControle.SelectionLength = 0;
            this.txtControle.SelectionStart = 0;
            this.txtControle.ShortcutsEnabled = true;
            this.txtControle.Size = new System.Drawing.Size(120, 23);
            this.txtControle.TabIndex = 9;
            this.txtControle.UseSelectable = true;
            this.txtControle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtControle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumeroControle
            // 
            // 
            // 
            // 
            this.txtNumeroControle.CustomButton.Image = null;
            this.txtNumeroControle.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtNumeroControle.CustomButton.Name = "";
            this.txtNumeroControle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroControle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroControle.CustomButton.TabIndex = 1;
            this.txtNumeroControle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroControle.CustomButton.UseSelectable = true;
            this.txtNumeroControle.CustomButton.Visible = false;
            this.txtNumeroControle.Lines = new string[0];
            this.txtNumeroControle.Location = new System.Drawing.Point(87, 315);
            this.txtNumeroControle.MaxLength = 32767;
            this.txtNumeroControle.Name = "txtNumeroControle";
            this.txtNumeroControle.PasswordChar = '\0';
            this.txtNumeroControle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroControle.SelectedText = "";
            this.txtNumeroControle.SelectionLength = 0;
            this.txtNumeroControle.SelectionStart = 0;
            this.txtNumeroControle.ShortcutsEnabled = true;
            this.txtNumeroControle.Size = new System.Drawing.Size(120, 23);
            this.txtNumeroControle.TabIndex = 14;
            this.txtNumeroControle.UseSelectable = true;
            this.txtNumeroControle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroControle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumeroEnvelope
            // 
            // 
            // 
            // 
            this.txtNumeroEnvelope.CustomButton.Image = null;
            this.txtNumeroEnvelope.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtNumeroEnvelope.CustomButton.Name = "";
            this.txtNumeroEnvelope.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroEnvelope.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroEnvelope.CustomButton.TabIndex = 1;
            this.txtNumeroEnvelope.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroEnvelope.CustomButton.UseSelectable = true;
            this.txtNumeroEnvelope.CustomButton.Visible = false;
            this.txtNumeroEnvelope.Lines = new string[0];
            this.txtNumeroEnvelope.Location = new System.Drawing.Point(87, 281);
            this.txtNumeroEnvelope.MaxLength = 32767;
            this.txtNumeroEnvelope.Name = "txtNumeroEnvelope";
            this.txtNumeroEnvelope.PasswordChar = '\0';
            this.txtNumeroEnvelope.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroEnvelope.SelectedText = "";
            this.txtNumeroEnvelope.SelectionLength = 0;
            this.txtNumeroEnvelope.SelectionStart = 0;
            this.txtNumeroEnvelope.ShortcutsEnabled = true;
            this.txtNumeroEnvelope.Size = new System.Drawing.Size(120, 23);
            this.txtNumeroEnvelope.TabIndex = 13;
            this.txtNumeroEnvelope.UseSelectable = true;
            this.txtNumeroEnvelope.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroEnvelope.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(87, 248);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(120, 23);
            this.txtValor.TabIndex = 12;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContaCreditada
            // 
            // 
            // 
            // 
            this.txtContaCreditada.CustomButton.Image = null;
            this.txtContaCreditada.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtContaCreditada.CustomButton.Name = "";
            this.txtContaCreditada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContaCreditada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContaCreditada.CustomButton.TabIndex = 1;
            this.txtContaCreditada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContaCreditada.CustomButton.UseSelectable = true;
            this.txtContaCreditada.CustomButton.Visible = false;
            this.txtContaCreditada.Lines = new string[0];
            this.txtContaCreditada.Location = new System.Drawing.Point(87, 190);
            this.txtContaCreditada.MaxLength = 32767;
            this.txtContaCreditada.Name = "txtContaCreditada";
            this.txtContaCreditada.PasswordChar = '\0';
            this.txtContaCreditada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContaCreditada.SelectedText = "";
            this.txtContaCreditada.SelectionLength = 0;
            this.txtContaCreditada.SelectionStart = 0;
            this.txtContaCreditada.ShortcutsEnabled = true;
            this.txtContaCreditada.Size = new System.Drawing.Size(120, 23);
            this.txtContaCreditada.TabIndex = 10;
            this.txtContaCreditada.UseSelectable = true;
            this.txtContaCreditada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContaCreditada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtData
            // 
            this.txtData.CustomFormat = "hh:mm";
            this.txtData.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(87, 72);
            this.txtData.MinimumSize = new System.Drawing.Size(0, 25);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 25);
            this.txtData.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1027, 469);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Consulta";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.horaDataGridViewTextBoxColumn,
            this.terminalDataGridViewTextBoxColumn,
            this.controleDataGridViewTextBoxColumn,
            this.contaCreditadaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.numeroEnvelopeDataGridViewTextBoxColumn,
            this.numeroControleDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.lancamentoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 24);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1024, 353);
            this.metroGrid1.TabIndex = 2;
            // 
            // lancamentoBindingSource
            // 
            this.lancamentoBindingSource.DataSource = typeof(Model.Lancamento);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 80;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            this.terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            this.terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            this.terminalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controleDataGridViewTextBoxColumn
            // 
            this.controleDataGridViewTextBoxColumn.DataPropertyName = "Controle";
            this.controleDataGridViewTextBoxColumn.HeaderText = "Controle";
            this.controleDataGridViewTextBoxColumn.Name = "controleDataGridViewTextBoxColumn";
            this.controleDataGridViewTextBoxColumn.ReadOnly = true;
            this.controleDataGridViewTextBoxColumn.Width = 130;
            // 
            // contaCreditadaDataGridViewTextBoxColumn
            // 
            this.contaCreditadaDataGridViewTextBoxColumn.DataPropertyName = "ContaCreditada";
            this.contaCreditadaDataGridViewTextBoxColumn.HeaderText = "ContaCreditada";
            this.contaCreditadaDataGridViewTextBoxColumn.Name = "contaCreditadaDataGridViewTextBoxColumn";
            this.contaCreditadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroEnvelopeDataGridViewTextBoxColumn
            // 
            this.numeroEnvelopeDataGridViewTextBoxColumn.DataPropertyName = "NumeroEnvelope";
            this.numeroEnvelopeDataGridViewTextBoxColumn.HeaderText = "NumeroEnvelope";
            this.numeroEnvelopeDataGridViewTextBoxColumn.Name = "numeroEnvelopeDataGridViewTextBoxColumn";
            this.numeroEnvelopeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroControleDataGridViewTextBoxColumn
            // 
            this.numeroControleDataGridViewTextBoxColumn.DataPropertyName = "NumeroControle";
            this.numeroControleDataGridViewTextBoxColumn.HeaderText = "NumeroControle";
            this.numeroControleDataGridViewTextBoxColumn.Name = "numeroControleDataGridViewTextBoxColumn";
            this.numeroControleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1075, 591);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Resizable = false;
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage.ResumeLayout(false);
            this.metroTabPage.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroDateTime txtData;
        private MetroFramework.Controls.MetroTextBox txtControle;
        private MetroFramework.Controls.MetroTextBox txtNumeroControle;
        private MetroFramework.Controls.MetroTextBox txtNumeroEnvelope;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroTextBox txtContaCreditada;
        private MetroFramework.Controls.MetroTextBox txtTerminal;
        private MetroFramework.Controls.MetroTile metroTileNovo;
        private MetroFramework.Controls.MetroTile metroTileSalvar;
        private MetroFramework.Controls.MetroTile metroTileExcluir;
        private MetroFramework.Controls.MetroTile metroTileLimpar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtHora;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile metroTileBuscar;
        private MetroFramework.Controls.MetroTextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.BindingSource lancamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaCreditadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEnvelopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroControleDataGridViewTextBoxColumn;
    }
}

