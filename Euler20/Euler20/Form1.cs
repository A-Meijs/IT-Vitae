using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Euler20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BigInteger Factorial = 0;
        private int Number = 0;

        private void B_D0_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Nlabel.Text = Number.ToString();
        }

        private void B_D1_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 1;
            Nlabel.Text = Number.ToString();
        }

        private void B_D2_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 2;
            Nlabel.Text = Number.ToString();
        }

        private void B_D3_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 3;
            Nlabel.Text = Number.ToString();
        }

        private void B_D4_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 4;
            Nlabel.Text = Number.ToString();
        }

        private void B_D5_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 5;
            Nlabel.Text = Number.ToString();
        }

        private void B_D6_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 6;
            Nlabel.Text = Number.ToString();
        }

        private void B_D7_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 7;
            Nlabel.Text = Number.ToString();
        }

        private void B_D8_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 8;
            Nlabel.Text = Number.ToString();
        }

        private void B_D9_Click(object sender, EventArgs e)
        {
            Number *= 10;
            Number += 9;
            Nlabel.Text = Number.ToString();
        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            Number = 0;
            Nlabel.Text = Number.ToString();
        }

        private void Calculate_Factorial()
        {
            Factorial = 1;
            for (int i = 1; i <= Number; i += 1)
            {
                Factorial *= i;
            }
            FactLabel.Text = Factorial.ToString();
        }

        private void Sum_Of_Digits()
        {
            int Sum = 0;
            while(Factorial != 0)
            {
                Sum += (int)(Factorial % 10);
                Factorial /= 10;
            }
            SumLabel.Text = Sum.ToString();
        }

        private void B_Calculate_Click(object sender, EventArgs e)
        {
            Calculate_Factorial();
            Sum_Of_Digits();
            Number = 0;
            Nlabel.Text = Number.ToString();
        }
    }
}
