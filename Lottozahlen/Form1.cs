using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[6];
        Random random = new Random();

        private void button_auslosen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int check = random.Next(1, 49);
                if (numbers.Contains(check))
                {
                    i--;
                }
                else
                {
                    numbers[i] = check;
                }
            }
            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();

            if (numbers.Contains(Convert.ToInt32(number1.Text)))
            {
                number1.BackColor = Color.Green;
            }
            else
            {
                number1.BackColor = Color.White;
            }

            if (numbers.Contains(Convert.ToInt32(number2.Text)))
            {
                number2.BackColor = Color.Green;
            }
            else
            {
                number2.BackColor = Color.White;
            }

            if (numbers.Contains(Convert.ToInt32(number3.Text)))
            {
                number3.BackColor = Color.Green;
            }
            else
            {
                number3.BackColor = Color.White;
            }

            if (numbers.Contains(Convert.ToInt32(number4.Text)))
            {
                number4.BackColor = Color.Green;
            }
            else
            {
                number4.BackColor = Color.White;
            }

            if (numbers.Contains(Convert.ToInt32(number5.Text)))
            {
                number5.BackColor = Color.Green;
            }
            else
            {
                number5.BackColor = Color.White;
            }

            if (numbers.Contains(Convert.ToInt32(number6.Text)))
            {
                number6.BackColor = Color.Green;
            }
            else
            {
                number6.BackColor = Color.White;
            }
        }
    }
}

