namespace Financeiro.Gui
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPrincipal = new TabControl();
            tabPagCadastro = new TabPage();
            dateTimePicker = new DateTimePicker();
            txtNumeroControle = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtNumeroEnvelope = new TextBox();
            txtValor = new TextBox();
            txtNome = new TextBox();
            txtContaCreditada = new TextBox();
            txtControle = new TextBox();
            txtTerminal = new TextBox();
            txtHora = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPrincipal.SuspendLayout();
            tabPagCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPagCadastro);
            tabPrincipal.Controls.Add(tabPage2);
            tabPrincipal.Location = new Point(12, 12);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(794, 445);
            tabPrincipal.TabIndex = 0;
            // 
            // tabPagCadastro
            // 
            tabPagCadastro.Controls.Add(dateTimePicker);
            tabPagCadastro.Controls.Add(txtNumeroControle);
            tabPagCadastro.Controls.Add(label10);
            tabPagCadastro.Controls.Add(label9);
            tabPagCadastro.Controls.Add(label8);
            tabPagCadastro.Controls.Add(txtNumeroEnvelope);
            tabPagCadastro.Controls.Add(txtValor);
            tabPagCadastro.Controls.Add(txtNome);
            tabPagCadastro.Controls.Add(txtContaCreditada);
            tabPagCadastro.Controls.Add(txtControle);
            tabPagCadastro.Controls.Add(txtTerminal);
            tabPagCadastro.Controls.Add(txtHora);
            tabPagCadastro.Controls.Add(txtId);
            tabPagCadastro.Controls.Add(label7);
            tabPagCadastro.Controls.Add(label6);
            tabPagCadastro.Controls.Add(label5);
            tabPagCadastro.Controls.Add(label4);
            tabPagCadastro.Controls.Add(label3);
            tabPagCadastro.Controls.Add(label2);
            tabPagCadastro.Controls.Add(txtBuscar);
            tabPagCadastro.Controls.Add(btnBuscar);
            tabPagCadastro.Controls.Add(btnExcluir);
            tabPagCadastro.Controls.Add(btnLimpar);
            tabPagCadastro.Controls.Add(btnSalvar);
            tabPagCadastro.Controls.Add(btnNovo);
            tabPagCadastro.Controls.Add(label1);
            tabPagCadastro.Location = new Point(4, 29);
            tabPagCadastro.Name = "tabPagCadastro";
            tabPagCadastro.Padding = new Padding(3);
            tabPagCadastro.Size = new Size(786, 412);
            tabPagCadastro.TabIndex = 0;
            tabPagCadastro.Text = "Cadastro";
            tabPagCadastro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker.Location = new Point(106, 83);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(124, 27);
            dateTimePicker.TabIndex = 26;
            // 
            // txtNumeroControle
            // 
            txtNumeroControle.Location = new Point(106, 367);
            txtNumeroControle.Name = "txtNumeroControle";
            txtNumeroControle.Size = new Size(125, 27);
            txtNumeroControle.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 374);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 24;
            label10.Text = "Nº Controle";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 338);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 23;
            label9.Text = "Nº Envelope";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 305);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 22;
            label8.Text = "Valor";
            label8.Click += label8_Click;
            // 
            // txtNumeroEnvelope
            // 
            txtNumeroEnvelope.Location = new Point(106, 331);
            txtNumeroEnvelope.Name = "txtNumeroEnvelope";
            txtNumeroEnvelope.Size = new Size(125, 27);
            txtNumeroEnvelope.TabIndex = 21;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(106, 298);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 20;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 265);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(444, 27);
            txtNome.TabIndex = 19;
            // 
            // txtContaCreditada
            // 
            txtContaCreditada.Location = new Point(106, 232);
            txtContaCreditada.Name = "txtContaCreditada";
            txtContaCreditada.Size = new Size(125, 27);
            txtContaCreditada.TabIndex = 18;
            // 
            // txtControle
            // 
            txtControle.Location = new Point(106, 197);
            txtControle.Name = "txtControle";
            txtControle.Size = new Size(125, 27);
            txtControle.TabIndex = 17;
            // 
            // txtTerminal
            // 
            txtTerminal.Location = new Point(106, 160);
            txtTerminal.Name = "txtTerminal";
            txtTerminal.Size = new Size(125, 27);
            txtTerminal.TabIndex = 16;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(106, 124);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(125, 27);
            txtHora.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(106, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 160);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Terminal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 197);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Controle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 235);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "C. Creditada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 270);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Data";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(418, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(559, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(306, 6);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(206, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(106, 6);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 6);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 462);
            Controls.Add(tabPrincipal);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            tabPrincipal.ResumeLayout(false);
            tabPagCadastro.ResumeLayout(false);
            tabPagCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagCadastro;
        private TabPage tabPage2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnNovo;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox txtNumeroEnvelope;
        private TextBox txtValor;
        private TextBox txtNome;
        private TextBox txtContaCreditada;
        private TextBox txtControle;
        private TextBox txtTerminal;
        private TextBox txtHora;
        private TextBox txtId;
        private TextBox txtNumeroControle;
        private Label label10;
        private DateTimePicker dateTimePicker;
    }
}