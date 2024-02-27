using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(squareA.Text);
                int B = Convert.ToInt32(squareB.Text);
                int C = Convert.ToInt32(squareC.Text);

                var result = new Square(A, B, C);
                squareLabel.Text = result.Print();
            }
            catch (FormatException) // виклик при невірному форматі в TextBox
            {
                squareLabel.Text = "Невірний формат";
            }
            catch (InvalidOperationException) // виклик при некоректному значенні А (а = 0)
            {
                squareLabel.Text = "Некоректна змінна А";
            }
            catch (Exception) // виклик, якщо дискримінант менше нуля
            {
                squareLabel.Text = "Коренів немає";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int K = Convert.ToInt32(linearB.Text);
                int B = Convert.ToInt32(linearA.Text);

                var result = new Linear(K, B);
                linearLabel.Text = result.Print();
            }
            catch (FormatException) // виклик при невірному форматі в TextBox
            {
                linearLabel.Text = "Невірний формат";
            }
            catch (InvalidOperationException) // виклик при некоректному значенні К (К = 0)
            {
                linearLabel.Text = "Некоректна змінна К";
            }
        }
    }
}