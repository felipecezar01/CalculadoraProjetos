using System;
using System.Data; // Para usar DataTable e avaliar expressões
using System.Windows.Forms;

namespace CalculadoraGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNumero_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            txtDisplay.Text += botao.Text;
        }

        private void ButtonOperador_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            txtDisplay.Text += " " + botao.Text + " ";
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txtDisplay.Text.Replace("x", "*");
                var resultado = new DataTable().Compute(expressao, null);
                txtDisplay.Text = resultado.ToString();
            }
            catch
            {
                txtDisplay.Text = "Erro";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
