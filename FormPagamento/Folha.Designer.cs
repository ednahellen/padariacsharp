namespace FormPagamento
{
    partial class Follha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FP));
            this.lbdatafolha = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbsal = new System.Windows.Forms.Label();
            this.cbClube = new System.Windows.Forms.ComboBox();
            this.lbClub = new System.Windows.Forms.Label();
            this.checkPlano = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtSalFo = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lbImposto = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lbSalliq = new System.Windows.Forms.Label();
            this.txtSalliq = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdatafolha
            // 
            this.lbdatafolha.AutoSize = true;
            this.lbdatafolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatafolha.Location = new System.Drawing.Point(9, 16);
            this.lbdatafolha.Name = "lbdatafolha";
            this.lbdatafolha.Size = new System.Drawing.Size(114, 20);
            this.lbdatafolha.TabIndex = 0;
            this.lbdatafolha.Text = "Data da Folha ";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(13, 50);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(122, 26);
            this.dtData.TabIndex = 1;
            this.dtData.TabStop = false;
            // 
            // lbsal
            // 
            this.lbsal.AutoSize = true;
            this.lbsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsal.Location = new System.Drawing.Point(9, 94);
            this.lbsal.Name = "lbsal";
            this.lbsal.Size = new System.Drawing.Size(58, 20);
            this.lbsal.TabIndex = 3;
            this.lbsal.Text = "Salário";
            // 
            // cbClube
            // 
            this.cbClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClube.FormattingEnabled = true;
            this.cbClube.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbClube.Location = new System.Drawing.Point(12, 264);
            this.cbClube.Name = "cbClube";
            this.cbClube.Size = new System.Drawing.Size(255, 28);
            this.cbClube.TabIndex = 7;
            // 
            // lbClub
            // 
            this.lbClub.AutoSize = true;
            this.lbClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClub.Location = new System.Drawing.Point(9, 241);
            this.lbClub.Name = "lbClub";
            this.lbClub.Size = new System.Drawing.Size(116, 20);
            this.lbClub.TabIndex = 6;
            this.lbClub.Text = "Clube de Lazer";
            // 
            // checkPlano
            // 
            this.checkPlano.AutoSize = true;
            this.checkPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPlano.Location = new System.Drawing.Point(13, 178);
            this.checkPlano.Name = "checkPlano";
            this.checkPlano.Size = new System.Drawing.Size(141, 24);
            this.checkPlano.TabIndex = 5;
            this.checkPlano.Text = "Plano de Saúde";
            this.checkPlano.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btCalcular.Image")));
            this.btCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalcular.Location = new System.Drawing.Point(35, 366);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(175, 43);
            this.btCalcular.TabIndex = 14;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            // 
            // txtSalFo
            // 
            this.txtSalFo.Enabled = false;
            this.txtSalFo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFo.Location = new System.Drawing.Point(548, 94);
            this.txtSalFo.MaxLength = 1000;
            this.txtSalFo.Name = "txtSalFo";
            this.txtSalFo.ReadOnly = true;
            this.txtSalFo.Size = new System.Drawing.Size(200, 26);
            this.txtSalFo.TabIndex = 9;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(440, 97);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(102, 20);
            this.lblSal.TabIndex = 8;
            this.lblSal.Text = "Salário Folha";
            // 
            // lbImposto
            // 
            this.lbImposto.AutoSize = true;
            this.lbImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImposto.Location = new System.Drawing.Point(401, 161);
            this.lbImposto.Name = "lbImposto";
            this.lbImposto.Size = new System.Drawing.Size(141, 20);
            this.lbImposto.TabIndex = 10;
            this.lbImposto.Text = "Imposto de Renda";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(548, 155);
            this.txtImposto.MaxLength = 1000;
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(200, 26);
            this.txtImposto.TabIndex = 11;
            // 
            // lbSalliq
            // 
            this.lbSalliq.AutoSize = true;
            this.lbSalliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalliq.Location = new System.Drawing.Point(426, 225);
            this.lbSalliq.Name = "lbSalliq";
            this.lbSalliq.Size = new System.Drawing.Size(107, 20);
            this.lbSalliq.TabIndex = 12;
            this.lbSalliq.Text = "Salário líquido";
            // 
            // txtSalliq
            // 
            this.txtSalliq.Enabled = false;
            this.txtSalliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalliq.Location = new System.Drawing.Point(548, 224);
            this.txtSalliq.MaxLength = 1000;
            this.txtSalliq.Name = "txtSalliq";
            this.txtSalliq.Size = new System.Drawing.Size(200, 26);
            this.txtSalliq.TabIndex = 13;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(12, 117);
            this.txtSal.MaxLength = 1000;
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(221, 26);
            this.txtSal.TabIndex = 4;
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlimpar.Location = new System.Drawing.Point(291, 366);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(175, 43);
            this.btlimpar.TabIndex = 15;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(548, 366);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(175, 43);
            this.btSair.TabIndex = 16;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // FP
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
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FP";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbdatafolha;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lbsal;
        private System.Windows.Forms.ComboBox cbClube;
        private System.Windows.Forms.Label lbClub;
        private System.Windows.Forms.CheckBox checkPlano;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtSalFo;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lbImposto;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lbSalliq;
        private System.Windows.Forms.TextBox txtSalliq;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btSair;
    }
}

