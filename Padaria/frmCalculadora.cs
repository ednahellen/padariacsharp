﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //comentário de linha
            /*Comentário de bloco
             * 
             */
            /*declarando variável 
            int valor1, valor4,resp;
            double valor2;
            float valor3;
            bool flag;
            string nome;
            char sexo;

            //inicializar as variáveis
            valor1 = 10;
            valor4 = 20;

            resp = valor1 + valor4; */
            double num1, num2, resp=0;

            //inicializar as variáveis

            try
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                if (!rdbSomar.Checked && !rdbSubtrair.Checked && !rdbMultiplicar.Checked && !rdbDivisao.Checked)
                {
                    MessageBox.Show("Selecione uma operação", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rdbSomar.Checked)
                {
                    resp = num1 + num2;
                }
                else if (rdbSubtrair.Checked)
                {
                    resp = num1 - num2;
                }
                else if (rdbMultiplicar.Checked)
                {
                    resp = num1 * num2;
                }
                else if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível dividir por zero", "Mensagem do sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resp = num1 / num2;
                }

                txtResposta.Text = resp.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Inserir somente números", "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                txtResposta.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
            {
                //sair do sistema e encerrar processo
                Application.Exit();
            }

            private void btnLimpar_Click(object sender, EventArgs e)
            {
                txtNum1.Text = ""; //limpar a caixa
                txtNum2.Clear(); //limpar a caixa
                txtResposta.Clear();

                rdbSomar.Checked = false;
                rdbSubtrair.Checked = false;    
                rdbMultiplicar.Checked = false;
                rdbDivisao.Checked = false;

                txtNum1.Focus();
            
            }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
