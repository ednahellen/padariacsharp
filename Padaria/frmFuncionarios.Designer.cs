namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDadospessoais = new System.Windows.Forms.GroupBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mkdCod = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.mktTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbNinformar = new System.Windows.Forms.RadioButton();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btCarregar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.mkdCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.txtNumend = new System.Windows.Forms.TextBox();
            this.lblNumend = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar2 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCompl = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.gpbDadospessoais.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.gpbEndereco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadospessoais
            // 
            this.gpbDadospessoais.Controls.Add(this.btLimpar);
            this.gpbDadospessoais.Controls.Add(this.btAlterar);
            this.gpbDadospessoais.Controls.Add(this.btCarregar);
            this.gpbDadospessoais.Controls.Add(this.lblFoto);
            this.gpbDadospessoais.Controls.Add(this.picFoto);
            this.gpbDadospessoais.Controls.Add(this.gpbSexo);
            this.gpbDadospessoais.Controls.Add(this.mktTel);
            this.gpbDadospessoais.Controls.Add(this.lblTel);
            this.gpbDadospessoais.Controls.Add(this.dtpDataNasc);
            this.gpbDadospessoais.Controls.Add(this.label1);
            this.gpbDadospessoais.Controls.Add(this.mkdCod);
            this.gpbDadospessoais.Controls.Add(this.lblCPF);
            this.gpbDadospessoais.Controls.Add(this.txtEmail);
            this.gpbDadospessoais.Controls.Add(this.lblEmail);
            this.gpbDadospessoais.Controls.Add(this.txtNome);
            this.gpbDadospessoais.Controls.Add(this.lblnome);
            this.gpbDadospessoais.Controls.Add(this.txtcod);
            this.gpbDadospessoais.Controls.Add(this.lblcodigo);
            this.gpbDadospessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadospessoais.Location = new System.Drawing.Point(1, 12);
            this.gpbDadospessoais.Name = "gpbDadospessoais";
            this.gpbDadospessoais.Size = new System.Drawing.Size(775, 257);
            this.gpbDadospessoais.TabIndex = 0;
            this.gpbDadospessoais.TabStop = false;
            this.gpbDadospessoais.Text = "Dados Pessoais";
            this.gpbDadospessoais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(3, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Location = new System.Drawing.Point(61, 36);
            this.txtcod.MaxLength = 10;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 26);
            this.txtcod.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(219, 36);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(168, 42);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(523, 36);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(466, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(3, 84);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(59, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "Código";
            // 
            // mkdCod
            // 
            this.mkdCod.Location = new System.Drawing.Point(68, 80);
            this.mkdCod.Mask = "999,999,999-99";
            this.mkdCod.Name = "mkdCod";
            this.mkdCod.Size = new System.Drawing.Size(123, 26);
            this.mkdCod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(353, 80);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(107, 26);
            this.dtpDataNasc.TabIndex = 4;
            // 
            // mktTel
            // 
            this.mktTel.Location = new System.Drawing.Point(550, 76);
            this.mktTel.Mask = "99999-9999";
            this.mktTel.Name = "mktTel";
            this.mktTel.Size = new System.Drawing.Size(123, 26);
            this.mktTel.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(473, 82);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(71, 20);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefone";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbNinformar);
            this.gpbSexo.Controls.Add(this.rbMasculino);
            this.gpbSexo.Controls.Add(this.rbFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(3, 118);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(212, 128);
            this.gpbSexo.TabIndex = 6;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(7, 26);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbFeminino.TabIndex = 6;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 56);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbNinformar
            // 
            this.rbNinformar.AutoSize = true;
            this.rbNinformar.Location = new System.Drawing.Point(7, 86);
            this.rbNinformar.Name = "rbNinformar";
            this.rbNinformar.Size = new System.Drawing.Size(169, 24);
            this.rbNinformar.TabIndex = 8;
            this.rbNinformar.TabStop = true;
            this.rbNinformar.Text = "Não desejo informar";
            this.rbNinformar.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(315, 131);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(176, 113);
            this.picFoto.TabIndex = 15;
            this.picFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(250, 131);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(42, 20);
            this.lblFoto.TabIndex = 16;
            this.lblFoto.Text = "Foto";
            // 
            // btCarregar
            // 
            this.btCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btCarregar.Image")));
            this.btCarregar.Location = new System.Drawing.Point(497, 131);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(51, 37);
            this.btCarregar.TabIndex = 9;
            this.btCarregar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.Location = new System.Drawing.Point(497, 170);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(51, 28);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.Location = new System.Drawing.Point(497, 204);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(51, 40);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.textBox1);
            this.gpbEndereco.Controls.Add(this.lblCompl);
            this.gpbEndereco.Controls.Add(this.txtNumend);
            this.gpbEndereco.Controls.Add(this.lblNumend);
            this.gpbEndereco.Controls.Add(this.cboxUF);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.textBairro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.mkdCEP);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(1, 275);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(775, 191);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // mkdCEP
            // 
            this.mkdCEP.Location = new System.Drawing.Point(652, 36);
            this.mkdCEP.Mask = "999,999,999-99";
            this.mkdCEP.Name = "mkdCEP";
            this.mkdCEP.Size = new System.Drawing.Size(123, 26);
            this.mkdCEP.TabIndex = 14;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(613, 39);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(99, 36);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(313, 26);
            this.txtLogradouro.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(3, 42);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(99, 82);
            this.textBairro.MaxLength = 100;
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(241, 26);
            this.textBairro.TabIndex = 15;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(10, 88);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(519, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // cboxUF
            // 
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.ItemHeight = 20;
            this.cboxUF.Items.AddRange(new object[] {
            "AC",
            " AL",
            " AP",
            " AM",
            " BA",
            " CE",
            " DF",
            " ES",
            " GO",
            " MA",
            " MT",
            " MS",
            " MG",
            " PA",
            " PB",
            " PR",
            " PE",
            " PI",
            " RJ",
            " RN",
            " RS",
            " RO",
            " RR",
            " SC",
            " SP",
            " SE",
            " TO"});
            this.cboxUF.Location = new System.Drawing.Point(607, 127);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(92, 28);
            this.cboxUF.TabIndex = 16;
            // 
            // txtNumend
            // 
            this.txtNumend.Location = new System.Drawing.Point(497, 36);
            this.txtNumend.MaxLength = 100;
            this.txtNumend.Name = "txtNumend";
            this.txtNumend.Size = new System.Drawing.Size(113, 26);
            this.txtNumend.TabIndex = 13;
            // 
            // lblNumend
            // 
            this.lblNumend.AutoSize = true;
            this.lblNumend.Location = new System.Drawing.Point(426, 39);
            this.lblNumend.Name = "lblNumend";
            this.lblNumend.Size = new System.Drawing.Size(65, 20);
            this.lblNumend.TabIndex = 13;
            this.lblNumend.Text = "Número";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar2);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(1, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 100);
            this.panel1.TabIndex = 14;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(24, 23);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 60);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(130, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 60);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar2
            // 
            this.btnAlterar2.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar2.Image")));
            this.btnAlterar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar2.Location = new System.Drawing.Point(236, 23);
            this.btnAlterar2.Name = "btnAlterar2";
            this.btnAlterar2.Size = new System.Drawing.Size(100, 60);
            this.btnAlterar2.TabIndex = 21;
            this.btnAlterar2.Text = "&Alterar";
            this.btnAlterar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(342, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 60);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(448, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 60);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(554, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 60);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(660, 24);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 60);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 130);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 26);
            this.textBox1.TabIndex = 17;
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.Location = new System.Drawing.Point(10, 133);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(108, 20);
            this.lblCompl.TabIndex = 17;
            this.lblCompl.Text = "Complemento";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(486, 82);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(241, 26);
            this.txtCidade.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(397, 88);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 19;
            this.lblCidade.Text = "Cidade";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadospessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.gpbDadospessoais.ResumeLayout(false);
            this.gpbDadospessoais.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadospessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mkdCod;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbNinformar;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.MaskedTextBox mktTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mkdCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtNumend;
        private System.Windows.Forms.Label lblNumend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCompl;
    }
}