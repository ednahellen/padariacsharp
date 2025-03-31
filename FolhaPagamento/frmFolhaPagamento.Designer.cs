namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.btSair = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lbSalliq = new System.Windows.Forms.Label();
            this.txtSalliq = new System.Windows.Forms.TextBox();
            this.lbImposto = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtSalFo = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.checkPlano = new System.Windows.Forms.CheckBox();
            this.lbClub = new System.Windows.Forms.Label();
            this.cbClube = new System.Windows.Forms.ComboBox();
            this.lbsal = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbdatafolha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(570, 379);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(175, 43);
            this.btSair.TabIndex = 32;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlimpar.Location = new System.Drawing.Point(313, 379);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(175, 43);
            this.btlimpar.TabIndex = 31;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(34, 130);
            this.txtSal.MaxLength = 1000;
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(221, 26);
            this.txtSal.TabIndex = 20;
            // 
            // lbSalliq
            // 
            this.lbSalliq.AutoSize = true;
            this.lbSalliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalliq.Location = new System.Drawing.Point(448, 238);
            this.lbSalliq.Name = "lbSalliq";
            this.lbSalliq.Size = new System.Drawing.Size(107, 20);
            this.lbSalliq.TabIndex = 28;
            this.lbSalliq.Text = "Salário líquido";
            // 
            // txtSalliq
            // 
            this.txtSalliq.Enabled = false;
            this.txtSalliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalliq.Location = new System.Drawing.Point(570, 237);
            this.txtSalliq.MaxLength = 1000;
            this.txtSalliq.Name = "txtSalliq";
            this.txtSalliq.Size = new System.Drawing.Size(200, 26);
            this.txtSalliq.TabIndex = 29;
            // 
            // lbImposto
            // 
            this.lbImposto.AutoSize = true;
            this.lbImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImposto.Location = new System.Drawing.Point(423, 174);
            this.lbImposto.Name = "lbImposto";
            this.lbImposto.Size = new System.Drawing.Size(141, 20);
            this.lbImposto.TabIndex = 26;
            this.lbImposto.Text = "Imposto de Renda";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(570, 168);
            this.txtImposto.MaxLength = 1000;
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(200, 26);
            this.txtImposto.TabIndex = 27;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(462, 110);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(102, 20);
            this.lblSal.TabIndex = 24;
            this.lblSal.Text = "Salário Folha";
            // 
            // txtSalFo
            // 
            this.txtSalFo.Enabled = false;
            this.txtSalFo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFo.Location = new System.Drawing.Point(570, 107);
            this.txtSalFo.MaxLength = 1000;
            this.txtSalFo.Name = "txtSalFo";
            this.txtSalFo.ReadOnly = true;
            this.txtSalFo.Size = new System.Drawing.Size(200, 26);
            this.txtSalFo.TabIndex = 25;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btCalcular.Image")));
            this.btCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalcular.Location = new System.Drawing.Point(57, 379);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(175, 43);
            this.btCalcular.TabIndex = 30;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // checkPlano
            // 
            this.checkPlano.AutoSize = true;
            this.checkPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPlano.Location = new System.Drawing.Point(35, 191);
            this.checkPlano.Name = "checkPlano";
            this.checkPlano.Size = new System.Drawing.Size(141, 24);
            this.checkPlano.TabIndex = 21;
            this.checkPlano.Text = "Plano de Saúde";
            this.checkPlano.UseVisualStyleBackColor = true;
            // 
            // lbClub
            // 
            this.lbClub.AutoSize = true;
            this.lbClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClub.Location = new System.Drawing.Point(31, 254);
            this.lbClub.Name = "lbClub";
            this.lbClub.Size = new System.Drawing.Size(116, 20);
            this.lbClub.TabIndex = 22;
            this.lbClub.Text = "Clube de Lazer";
            // 
            // cbClube
            // 
            this.cbClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClube.FormattingEnabled = true;
            this.cbClube.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbClube.Location = new System.Drawing.Point(34, 277);
            this.cbClube.Name = "cbClube";
            this.cbClube.Size = new System.Drawing.Size(255, 28);
            this.cbClube.TabIndex = 23;
            // 
            // lbsal
            // 
            this.lbsal.AutoSize = true;
            this.lbsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsal.Location = new System.Drawing.Point(31, 107);
            this.lbsal.Name = "lbsal";
            this.lbsal.Size = new System.Drawing.Size(58, 20);
            this.lbsal.TabIndex = 19;
            this.lbsal.Text = "Salário";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(35, 63);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(122, 26);
            this.dtData.TabIndex = 18;
            this.dtData.TabStop = false;
            // 
            // lbdatafolha
            // 
            this.lbdatafolha.AutoSize = true;
            this.lbdatafolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatafolha.Location = new System.Drawing.Point(31, 29);
            this.lbdatafolha.Name = "lbdatafolha";
            this.lbdatafolha.Size = new System.Drawing.Size(114, 20);
            this.lbdatafolha.TabIndex = 17;
            this.lbdatafolha.Text = "Data da Folha ";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lbSalliq);
            this.Controls.Add(this.txtSalliq);
            this.Controls.Add(this.lbImposto);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtSalFo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.checkPlano);
            this.Controls.Add(this.lbClub);
            this.Controls.Add(this.cbClube);
            this.Controls.Add(this.lbsal);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lbdatafolha);
            this.Name = "frmFolhaPagamento";
            this.Text = "frmFolhaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lbSalliq;
        private System.Windows.Forms.TextBox txtSalliq;
        private System.Windows.Forms.Label lbImposto;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtSalFo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.CheckBox checkPlano;
        private System.Windows.Forms.Label lbClub;
        private System.Windows.Forms.ComboBox cbClube;
        private System.Windows.Forms.Label lbsal;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lbdatafolha;
    }
}