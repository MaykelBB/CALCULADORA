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
        int operacion,ingreso, opeant,coma;
        string a, b; 
        double resultado;


        public Form1()
        {
            a = "";
            b = "0";
            resultado = 0;
            InitializeComponent();
            operacion = 10;
            opeant = 0;
            ingreso = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0) {
                            
                a = a + "1";
            }

            this.textBox1.Text = a;
            ingreso = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ingreso == 0)
            {
          
             a = a + "2";
            
            }
            this.textBox1.Text = a;
            ingreso = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           

                a = a + "3";
            }

            this.textBox1.Text = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
          
                a = a + "4";
            }
            this.textBox1.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           
                a = a + "5";
            }
                this.textBox1.Text = a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           
                a = a + "6";
            }
            this.textBox1.Text = a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           
                a = a + "7";
            }
             this.textBox1.Text = a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           
                a = a + "8";
            }
            this.textBox1.Text = a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (ingreso == 0)
            {
           
                a = a + "9";
            }
            this.textBox1.Text = a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
           
            if (ingreso == 0)
            {
                a = a + "0";
            }

             this.textBox1.Text = a;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // C
            coma = 0;
            if (a == "") {
                resultado = 0;

            }
            else {
                a = "";
               
            }
            this.textBox1.Text = a;
            opeant = 0;
            operacion = 10;

        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (ingreso == 0 & coma==0)
            {
            a = a + ",";
                coma = 1;
            }
            this.textBox1.Text = a;
            
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

            a = this.textBox1.Text;

            if (operacion == 0 & opeant == 0)
            {
                a = "" + resultado;

            }
            coma = 0;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = "";
            this.textBox1.Text = a;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //multiplicacion
            a = this.textBox1.Text;

            if (operacion == 0 & opeant == 0)
            {
                a = "" + resultado;

            }
            coma = 0;
            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 3;
            a = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //division

            a = this.textBox1.Text;

            if (operacion == 0 & opeant == 0)
            {
                a = "" + resultado;

            }
            coma = 0;
            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 4;
            a = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            //=
            coma = 0;




            if (a == "")
            {
           
            }
            else
            {
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
                opeant = 0;
                operacion = 0;
                a ="";
            }
            this.textBox1.Text = "" + resultado;

            
           
            //a = "";

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //suma
            b= this.textBox1.Text;
            
            if (operacion==0 & opeant == 0)
            {
                a = "" + resultado;

            }
            coma = 0;
            resultado = double.Parse(a);
            opeant = operacion;
            operacion = 1;
            a = "";
           
                        

            
            
           
        }
    }
}
