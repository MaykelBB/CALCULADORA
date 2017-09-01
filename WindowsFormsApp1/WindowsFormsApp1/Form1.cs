using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        int operacion, opeant;
        string a, b; 
        double resultado;


        public Form1()
        {
            a = "";
            b = "0";
            resultado = 0;
            InitializeComponent();
            operacion = 0;
            opeant = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operacion==0) {
                a = "";
            }
            a = a + "1";
            this.textBox1.Text = a;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }


            a = a + "2";
            this.textBox1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "3";
            this.textBox1.Text = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "4";
            this.textBox1.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "5";
            this.textBox1.Text = a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "6";
            this.textBox1.Text = a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "7";
            this.textBox1.Text = a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "8";
            this.textBox1.Text = a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "9";
            this.textBox1.Text = a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                a = "";
            }
            a = a + "0";
            this.textBox1.Text = a;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (a == "") {
                resultado = 0;

            }
            else {
                a = "";
                this.textBox1.Text = a;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = a + ",";
            this.textBox1.Text = a;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 2;
            a = "";




            //resta
            //opeant = operacion;
            //if (a == "" & opeant == operacion)
            //   {
            //    resultado = resultado - resultado;
            //    this.textBox1.Text = "" + resultado;
            // }
            // else
            //  {
            //     resultado = resultado - double.Parse(a);
            //     this.textBox1.Text = "" + resultado;
            //     a = "";
            //  }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //multiplicacion
            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 3;
            a = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //division
            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 4;
            a = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            //=
            if (operacion == 0) { 
                a = "";
                resultado = 0;
            }

                switch (operacion)
            {
                case 0:
                    break;
                case 1:
                    resultado = resultado + double.Parse(a);
                    break;
                case 2:
                    resultado = resultado - double.Parse(a);
                    break;
                case 3:
                    resultado = resultado * double.Parse(a);
                    break;
                case 4:
                    resultado = resultado / double.Parse(a);
                    break;
                case 5:
                    break;
            }
            this.textBox1.Text = "" + resultado;

            a = this.textBox1.Text;
            opeant = 0;
            operacion = 0;

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //suma

            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 1;
            a = "";
            
                        

            
            
           
        }
    }
}
