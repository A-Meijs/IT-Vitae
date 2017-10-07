using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float[] Values = new float[16];
        private int ValuesCur = 0;
        private char[] Instructions = new char[16];

        private int InstructionsCur = 0;
        private char Instruction = 'N';
        private float Total = 0;
        //private float Operand1 = 0, Operand2 = 0;
        //private 
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private class Eq_Part
        {
            public int Answer;
            public bool Solved;
            public Eq_Part Part1, Part2, Prev;
            public char Operation;
        }

        private Eq_Part Start;
        private Eq_Part CurPos;
        private void Add_Eq_Part(bool isValue, int Value, Eq_Part Previous)
        {
            Eq_Part To_Add = new Eq_Part();
            To_Add.Prev = Previous;
            if (isValue)
            {
                To_Add.Answer = Value;
                To_Add.Solved = true;
            }
            else
            {
                To_Add.Solved = false;

            }
        }
        //*/
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i += 1)
            {
                //Operand1 = 0
                Values[i] = 0;
                Instructions[i] = 'N';
            }
        }
        //---------------------------------Digit buttons------------------------------------------
        private void B_D0_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;//Total *= 10;
            Update_Label(); //label1.Text = Total.ToString();
        }


        private void B_D1_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 1;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D2_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 2;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D3_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 3;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D4_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 4;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D5_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 5;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D6_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 6;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D7_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 7;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D8_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 8;
            Update_Label(); //label1.Text = Total.ToString();
        }

        private void B_D9_Click(object sender, EventArgs e)
        {
            Values[ValuesCur] *= 10;
            Values[ValuesCur] += 9;
            Update_Label();
            //label1.Text = Total.ToString();
        }
        //---------------------------------Operator buttons------------------------------------------
        private void B_Plus_Click(object sender, EventArgs e)
        {
            //Instructions[InstructionsCur] = 'A';
            //InstructionsCur += 1;
            if (ValuesCur == 0)
                ValuesCur = 1;//+= 1;
            //else 
            Instruction = 'A';
        }

        private void B_Minus_Click(object sender, EventArgs e)
        {
            //Instructions[InstructionsCur] = 'S';
            //InstructionsCur += 1;
            //ValuesCur += 1;
            Instruction = 'S';
        }

        private void B_Product_Click(object sender, EventArgs e)
        {
            //Instructions[InstructionsCur] = 'P';
            //InstructionsCur += 1;
            //ValuesCur += 1;
            Instruction = 'M';
        }

        private void B_Division_Click(object sender, EventArgs e)
        {
            //Instructions[InstructionsCur] = 'M';
            //InstructionsCur += 1;
            //ValuesCur += 1;
            Instruction = 'D';
        }
        //---------------------------------Stuff------------------------------------------
        private void B_Comma_Click(object sender, EventArgs e)
        {

        }

        private void B_Equals_Click(object sender, EventArgs e)
        {
            //Evidently Visual Studio is of the opinion that things in switches should be as far to the right as possible.
            switch (Instruction)
            {
                case ('A'):
                {
                        Total = Values[0] += Values[1];
                        //Instructions[InstructionsCur] = '+';
                }break;
                case ('S'):
                {
                    Total = Values[0] -= Values[1];//Instructions[InstructionsCur] = '-';
                }break;
                case ('M'):
                {
                    Total = Values[0] *= Values[1];//Instructions[InstructionsCur] = '*';
                }break;
                case ('D'):
                {
                    if (Values[0] != 0)Total = Values[0] /= Values[1];// Instructions[InstructionsCur] = '÷';
                }break;
            }
            Values[0] = Total;
            label1.Text = Total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = Total.ToString();
        }

        private void Update_Label()
        {
            //if (Values[1] == 0 && Instructions[0] != 'N')
            //{
            //    label1.Text = Values[ValuesCur].ToString() + Instructions[0];
            //}
            label1.Text = Values[ValuesCur].ToString(); 
        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i += 1)
            {
                //Operand1 = 0
                Values[i] = 0;
                Instructions[i] = 'N';
                Instruction = 'N';
            }
        }
    }
}
