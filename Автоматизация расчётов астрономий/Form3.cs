using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автоматизация_расчётов_астрономий
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
              MessageBox.Show("Заполните оба поля: Т3 и T", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                if (!double.TryParse(textBox7.Text, out double T3))
                {
                    MessageBox.Show("Т3 должно быть числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    if (!double.TryParse(textBox8.Text, out double T))
                    {
                        MessageBox.Show("T должно быть числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        if (T - T3 == 0)
                        {
                            MessageBox.Show("Знаменатель T - T3 не может быть равен нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        double numerator = T3 * T;     
                        double denominator = T - T3;    
                        double S = numerator / denominator;
                        textBox1.Text = $"{S:F4}";
                        textBox3.Text = numerator.ToString("F2");
                        textBox4.Text= denominator.ToString("F2");
                        double years = Math.Floor(Math.Abs(S)); 
                        double fraction = Math.Abs(S) - years;   
                        int days = (int)Math.Round(fraction * 365);
                        if (S < 0)
                        {
                            textBox5.Text = $"-{years}";
                            textBox2.Text = "-"+years.ToString();
                            textBox6.Text = $"-{days}";
                            textBox9.Text = $"-{days}";
                        }
                            else textBox2.Text = "-" + years.ToString(); textBox5.Text = years.ToString(); textBox6.Text = days.ToString();
            if(S < 0)
                textBox9.Text = $"{days}";
                    else textBox9.Text = $"{days}";
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
