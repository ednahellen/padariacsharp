namespace Padaria
{
    partial class frmPesquisarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.gpbPesquisarpor = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbCod = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.gpbPesquisarpor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarpor
            // 
            this.gpbPesquisarpor.Controls.Add(this.textBox1);
            this.gpbPesquisarpor.Controls.Add(this.rdbNome);
            this.gpbPesquisarpor.Controls.Add(this.rdbCod);
            this.gpbPesquisarpor.Controls.Add(this.lblDescricao);
            this.gpbPesquisarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarpor.Location = new System.Drawing.Point(7, 8);
            this.gpbPesquisarpor.Name = "gpbPesquisarpor";
            this.gpbPesquisarpor.Size = new System.Drawing.Size(628, 108);
            this.gpbPesquisarpor.TabIndex = 0;
            this.gpbPesquisarpor.TabStop = false;
            this.gpbPesquisarpor.Text = "Pesquisar por";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(25, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Location = new System.Drawing.Point(20, 34);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(77, 24);
            this.rdbCod.TabIndex = 0;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Código";
            this.rdbCod.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(126, 34);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 69);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(650, 21);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(122, 95);
            this.btPesquisar.TabIndex = 4;
            this.btPesquisar.Text = "&Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.Location = new System.Drawing.Point(650, 125);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 100);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.Location = new System.Drawing.Point(8, 125);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(626, 121);
            this.ltbPesquisar.TabIndex = 3;
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.gpbPesquisarpor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarFuncionarios";
            this.Text = "frmPesquisarFuncionarios";
            this.gpbPesquisarpor.ResumeLayout(false);
            this.gpbPesquisarpor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarpor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCod;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListBox ltbPesquisar;
    }
}