using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double numa;
        double numb;
        double resultado;
        string temp = String.Empty;
        char operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            numa = double.Parse(txt_digitar.Text);
            txt_digitar.Text += " + ";
            operador = '+';

        }
        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            numa = double.Parse(txt_digitar.Text);
            txt_digitar.Text += " - ";
            operador = '-';
        }
        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            numa = double.Parse(txt_digitar.Text);
            txt_digitar.Text += " * ";
            operador = '*';
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            numa = double.Parse(txt_digitar.Text);
            txt_digitar.Text += " / ";
            operador = '/';

        }


        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (txt_digitar.Text == "")
            {
                txt_resposta.Text = "Não seja um animal";
            }
            else
            {
                temp = txt_digitar.Text;
                try
                {
                    numb = double.Parse(temp.Substring(temp.LastIndexOf(' ')));
                }
                catch
                {
                    numa = double.Parse(txt_digitar.Text);
                    numb = 0;
                }

                switch (operador)
                {
                    case '+':
                        resultado = numa + numb;
                        txt_resposta.Text = resultado.ToString();
                        break;
                    case '-':
                        resultado = numa - numb;
                        txt_resposta.Text = resultado.ToString();
                        break;
                    case '*':
                        resultado = numa * numb;
                        txt_resposta.Text = resultado.ToString();
                        break;
                    case '/':
                        if (numb != 0)
                        {
                            resultado = numa / numb;
                            txt_resposta.Text = resultado.ToString();
                        }
                        else
                        {
                            txt_resposta.Text = "Não seja um animal, dividir por 0 não dá";
                        }
                        break;
                    case ' ':
                        resultado = numa;
                        txt_resposta.Text = resultado.ToString();
                        break;

                }
                Limpar();
            }


        }

        private void txt_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "8";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "7";
        }



        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "6";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "5";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "4";
        }



        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "3";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "2";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "1";
        }



        private void btn_ponto_Click(object sender, EventArgs e)
        {
            txt_digitar.Text = "";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "0";
        }


        private void txt_digitar_TextChanged(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            numa = 0;
            numb = 0;
            operador = ' ';
            temp = String.Empty;
            resultado = 0;
            txt_digitar.Text = "";

        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            txt_digitar.Text = txt_resposta.Text;
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += ",";
        }
    }
}
