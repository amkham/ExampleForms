using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxValidate(textBox1, textBox2, textBox3)) {

                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                double D = b * b - 4 * a * c;

                if (D >= 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    resultLabel.Text = x1 + " " + x2;
                }
                else resultLabel.Text = "Корней нет";
            }
        }

        private bool textBoxValidate(params TextBox[] textBox) {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;
           
        }

     
    }
}
