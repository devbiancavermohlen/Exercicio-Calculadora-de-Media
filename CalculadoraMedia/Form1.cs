using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // limpar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                  ((TextBox)controle).Text = "";
                }

                this.Controls["label6"].Text = "...";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // calcular
        {
            float soma, media, valor;
            soma = 0;

            foreach(Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }
                media = soma / 4;
                this.Controls["label6"].Text = media.ToString();



            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string input = new string(textBox3.Text.Where(char.IsDigit).Take(2).ToArray());

            if (!string.IsNullOrEmpty(input))
            {
                textBox3.Text = input;
                textBox3.SelectionStart = input.Length;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          string input = new string(textBox1.Text.Where(char.IsDigit).Take(2).ToArray());

            if (!string.IsNullOrEmpty(input))
            {
                textBox1.Text = input;
                textBox1.SelectionStart = input.Length;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            string input = new string(textBox6.Text.Where(char.IsDigit).Take(2).ToArray());

            if (!string.IsNullOrEmpty(input))
            {
                textBox6.Text = input;
                textBox6.SelectionStart = input.Length;
            }
        }
    }
}
