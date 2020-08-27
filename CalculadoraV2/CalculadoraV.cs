using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV2
{
   
    public partial class Calculadora : Form
    {
        double numa;
        double numb;
        string temp = String.Empty;
        char operador = ' ';
        bool jorge = true;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (numa == 0)
            {
                numa = double.Parse(txt_digitar.Text);
            }
            
            
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
                txt_resposta.Text =  Resultado.ErroRe();
            }
            else
            {
                temp = txt_digitar.Text;

                Resultado.Numb(temp, numa, operador, out numa, out numb);
                //try
                //{
                //    numb = double.Parse(temp.Substring(temp.LastIndexOf(' ')));
                //}
                //catch
                //{
                //    numa = double.Parse(txt_digitar.Text);
                //    numb = 0;
                //}

                txt_resposta.Text = Resultado.Resposta(numa, numb, operador).ToString();
                
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
            txt_digitar.Text = "";

        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            try {

                txt_digitar.Text = double.Parse(txt_resposta.Text).ToString();

            }
            catch
            {
                txt_digitar.Text = "";
            }
            
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += ",";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn_porcento_Click(object sender, EventArgs e)
        {
            txt_digitar.Text += "%";
            if (operador == ' ')
            {
                numa = double.Parse(txt_digitar.Text.Replace("%", "")) / 100;
            }
            else
            {
                Resultado.Numb(txt_digitar.Text, numa, operador, out numa, out numb);                
            }
            
        }

        private void btn_limpartudo_Click(object sender, EventArgs e)
        {
            txt_digitar.Text = "";
            txt_resposta.Text = "";
        }

        private void btn_turbo_Click(object sender, EventArgs e)
        {
           
            if (jorge == true)
            {

                MessageBox.Show("MOOOODDDOOOOO TURBOOOOOO");
                this.BackColor = Color.Black;
                this.txt_digitar.BackColor = Color.LightGreen;
                this.txt_resposta.BackColor = Color.LightGreen;
                jorge = false;
            }
            else
            {
                MessageBox.Show("MODO CHATO E NORMAL");
                this.BackColor = Color.White;
                this.txt_digitar.BackColor = Color.White;
                this.txt_resposta.BackColor = Color.White;
                jorge = true;
            }

        }
    }
}
