using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAlgebra_Lineal
{
    public partial class Form1 : Form
    {
        string seleccion;
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            label2.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBox1.SelectedItem.ToString();
            label2.Visible = true;
            button1.Visible = true;
            
            if (seleccion == "DETERMINANTE de 3x3")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox16.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox15.Visible = true;
                textBox14.Visible = true;
                textBox4.Visible = false;
                textBox8.Visible = false;
                textBox13.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                button1.Text = "Calcular";


            }
            if (seleccion == "INVERSA 3x3")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox16.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox15.Visible = true;
                textBox14.Visible = true;
                textBox4.Visible = false;
                textBox8.Visible = false;
                textBox13.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                button1.Text = "Calcular";


            }
            if (seleccion== "DETERMINANTE de 4x4")
            {
                
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                button1.Text = "Calcular";
            }
            if (seleccion == "INVERSA 4x4")
            {

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                button1.Text = "Calcular";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (seleccion == "DETERMINANTE de 3x3")
            {
                float r1 = (float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text)) +
                   (float.Parse(textBox5.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text)) +
                   (float.Parse(textBox16.Text) * float.Parse(textBox2.Text) * float.Parse(textBox7.Text));
                float r2 = (float.Parse(textBox3.Text) * float.Parse(textBox6.Text) * float.Parse(textBox16.Text)) +
               (float.Parse(textBox7.Text) * float.Parse(textBox15.Text) * float.Parse(textBox1.Text)) +
               (float.Parse(textBox14.Text) * float.Parse(textBox2.Text) * float.Parse(textBox5.Text));
                float determinante = r1 - r2;
                label3.Text = "La determinante es: " + determinante;

                button2.Visible = true;

            }
            if (seleccion == "DETERMINANTE de 4x4")
            {
                //a11
                float c1 = (float.Parse(textBox1.Text))*
               ( ((float.Parse(textBox6.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
                (float.Parse(textBox7.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text)) +
                (float.Parse(textBox15.Text) * float.Parse(textBox10.Text) * float.Parse(textBox8.Text)))-(
                ((float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox8.Text)) +
                (float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox6.Text)) +
                (float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox7.Text))))) ;

                float c2 = (-float.Parse(textBox5.Text)) *
              (((float.Parse(textBox2.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
               (float.Parse(textBox3.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text)) +
               (float.Parse(textBox4.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text))) - (
               ((float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox4.Text)) +
               (float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox2.Text)) +
               (float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text)))));

                float c3 = (float.Parse(textBox16.Text)) *
             (((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox9.Text)) +
              (float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox11.Text)) +
              (float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox10.Text))) - (
              ((float.Parse(textBox11.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
              (float.Parse(textBox10.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text)) +
              (float.Parse(textBox9.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)))));

                float c4 = (-float.Parse(textBox12.Text)) *
            (((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox13.Text)) +
             (float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox15.Text)) +
             (float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text))) - (
             ((float.Parse(textBox15.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
             (float.Parse(textBox14.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text)) +
             (float.Parse(textBox13.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)))));

                float deter = c1 + c2 + c3+ c4;

                label3.Text = "La determinante es: " +deter;

                button2.Visible = true;

            }
            if (seleccion == "INVERSA 3x3")
            {
                inversa3x3();
                button2.Visible = true;
            }
            if (seleccion == "INVERSA 4x4")
            {
                Inversa4x4();
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Visible = false; button1.Visible = false;
            textBox1.Text = ""; textBox1.Visible = false;
            textBox2.Text = ""; textBox2.Visible = false;
            textBox3.Text = ""; textBox3.Visible = false;
            textBox4.Text = ""; textBox4.Visible = false;
            textBox5.Text = ""; textBox5.Visible = false;
            textBox6.Text = ""; textBox6.Visible = false;
            textBox7.Text = ""; textBox7.Visible = false;
            textBox8.Text = ""; textBox8.Visible = false;
            textBox9.Text = ""; textBox9.Visible = false;
            textBox10.Text = ""; textBox10.Visible = false;
            textBox11.Text = ""; textBox11.Visible = false;
            textBox12.Text = ""; textBox12.Visible = false;
            textBox13.Text = ""; textBox13.Visible = false;
            textBox14.Text = ""; textBox14.Visible = false;
            textBox15.Text = ""; textBox15.Visible = false;
            textBox16.Text = ""; textBox16.Visible = false;
            label2.Visible = false; label3.Text = "";

        }
        private void inversa3x3()
        {
            float r1 = (float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text)) +
           (float.Parse(textBox5.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text)) +
           (float.Parse(textBox16.Text) * float.Parse(textBox2.Text) * float.Parse(textBox7.Text));
            float r2 = (float.Parse(textBox3.Text) * float.Parse(textBox6.Text) * float.Parse(textBox16.Text)) +
           (float.Parse(textBox7.Text) * float.Parse(textBox15.Text) * float.Parse(textBox1.Text)) +
           (float.Parse(textBox14.Text) * float.Parse(textBox2.Text) * float.Parse(textBox5.Text));
            float determinante = r1 - r2;
            float c11 = float.Parse(textBox6.Text) * float.Parse(textBox14.Text) - float.Parse(textBox7.Text) * float.Parse(textBox15.Text);
            float c12= -(float.Parse(textBox5.Text) * float.Parse(textBox14.Text) - float.Parse(textBox7.Text) * float.Parse(textBox16.Text));
            float c13 = float.Parse(textBox5.Text) * float.Parse(textBox15.Text) - float.Parse(textBox6.Text) * float.Parse(textBox16.Text);
            float c21 = -(float.Parse(textBox2.Text) * float.Parse(textBox14.Text) - float.Parse(textBox3.Text) * float.Parse(textBox15.Text));
            float c22 = float.Parse(textBox1.Text) * float.Parse(textBox14.Text) - float.Parse(textBox3.Text) * float.Parse(textBox16.Text);
            float c23 = -(float.Parse(textBox1.Text) * float.Parse(textBox15.Text) - float.Parse(textBox2.Text) * float.Parse(textBox16.Text));
            float c31 = float.Parse(textBox2.Text) * float.Parse(textBox7.Text) - float.Parse(textBox3.Text) * float.Parse(textBox6.Text);
            float c32 = -(float.Parse(textBox1.Text) * float.Parse(textBox7.Text) - float.Parse(textBox3.Text) * float.Parse(textBox5.Text));
            float c33 = float.Parse(textBox1.Text) * float.Parse(textBox6.Text) - float.Parse(textBox2.Text) * float.Parse(textBox5.Text);
            float c1 = c11 / determinante; float c2 = c21 / determinante; float c3 = c31 / determinante;
            float c4 = c12 / determinante; float c5 = c22 / determinante; float c6 = c32 / determinante;
            float c7 = c13 / determinante; float c8 = c23 / determinante; float c9 = c33 / determinante;
            textBox1.Text = ""+c1;
            textBox2.Text = ""+c2;
            textBox3.Text = ""+c3; 
            textBox4.Visible = false;
            textBox5.Text = "" + c4;
            textBox6.Text = "" + c5;
            textBox7.Text = "" + c6;
            textBox8.Visible = false;
             textBox9.Visible = false;
             textBox10.Visible = false;
             textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Text = "" + c9;
            textBox15.Text = "" + c8;
            textBox16.Text = ""+c7;
            label2.Visible = false; label3.Text = "";
        }
        private void Inversa4x4()
        {
            float c1 = (float.Parse(textBox1.Text)) *
               (((float.Parse(textBox6.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
                (float.Parse(textBox7.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text)) +
                (float.Parse(textBox15.Text) * float.Parse(textBox10.Text) * float.Parse(textBox8.Text))) - (
                ((float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox8.Text)) +
                (float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox6.Text)) +
                (float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox7.Text)))));

            float c2 = (-float.Parse(textBox5.Text)) *
          (((float.Parse(textBox2.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
           (float.Parse(textBox3.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text)) +
           (float.Parse(textBox4.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text))) - (
           ((float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox4.Text)) +
           (float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox2.Text)) +
           (float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text)))));

            float c3 = (float.Parse(textBox16.Text)) *
         (((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox9.Text)) +
          (float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox11.Text)) +
          (float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox10.Text))) - (
          ((float.Parse(textBox11.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
          (float.Parse(textBox10.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text)) +
          (float.Parse(textBox9.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)))));

            float c4 = (-float.Parse(textBox12.Text)) *
        (((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox13.Text)) +
         (float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox15.Text)) +
         (float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text))) - (
         ((float.Parse(textBox15.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
         (float.Parse(textBox14.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text)) +
         (float.Parse(textBox13.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)))));

            float deter = c1 + c2 + c3 + c4;
            float div = 1 / deter;

            float A1 = (((float.Parse(textBox6.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
                float.Parse(textBox7.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text) +
                float.Parse(textBox8.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text)) - 
                ((float.Parse(textBox8.Text) * float.Parse(textBox11.Text) * float.Parse(textBox14.Text)) +
                float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox6.Text) +
                float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox7.Text)))*div;

            float A2 = (-(((float.Parse(textBox5.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
                float.Parse(textBox7.Text) * float.Parse(textBox13.Text) * float.Parse(textBox12.Text) +
                float.Parse(textBox8.Text) * float.Parse(textBox16.Text) * float.Parse(textBox10.Text)) -
                ((float.Parse(textBox12.Text) * float.Parse(textBox14.Text) * float.Parse(textBox8.Text)) +
                float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox5.Text) +
                float.Parse(textBox9.Text) * float.Parse(textBox16.Text) * float.Parse(textBox7.Text))))*div;

            float A3 = (((float.Parse(textBox5.Text) * float.Parse(textBox15.Text) * float.Parse(textBox9.Text)) +
                float.Parse(textBox6.Text) * float.Parse(textBox13.Text) * float.Parse(textBox12.Text) +
                float.Parse(textBox8.Text) * float.Parse(textBox16.Text) * float.Parse(textBox11.Text)) -
                ((float.Parse(textBox12.Text) * float.Parse(textBox15.Text) * float.Parse(textBox8.Text)) +
                float.Parse(textBox11.Text) * float.Parse(textBox3.Text) * float.Parse(textBox5.Text) +
                float.Parse(textBox9.Text) * float.Parse(textBox16.Text) * float.Parse(textBox6.Text)))*div;

            float A4 = (-(((float.Parse(textBox5.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text)) +(
                float.Parse(textBox6.Text) * float.Parse(textBox14.Text) * float.Parse(textBox12.Text)) +
                (float.Parse(textBox7.Text) * float.Parse(textBox16.Text) * float.Parse(textBox11.Text))) -
                ((float.Parse(textBox12.Text) * float.Parse(textBox15.Text) * float.Parse(textBox7.Text)) +
                (float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox5.Text)) +
                (float.Parse(textBox10.Text) * float.Parse(textBox16.Text) * float.Parse(textBox6.Text)))))*div;

            float A5 = (-(((float.Parse(textBox2.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
                float.Parse(textBox3.Text) * float.Parse(textBox13.Text) * float.Parse(textBox11.Text) +
                float.Parse(textBox4.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text)) -
                ((float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox4.Text)) +
                float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox2.Text) +
                float.Parse(textBox9.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text))))*div;

            float A6 = (((float.Parse(textBox1.Text) * float.Parse(textBox14.Text) * float.Parse(textBox9.Text)) +
               float.Parse(textBox3.Text) * float.Parse(textBox13.Text) * float.Parse(textBox12.Text) +
               float.Parse(textBox4.Text) * float.Parse(textBox16.Text) * float.Parse(textBox10.Text)) -
               ((float.Parse(textBox12.Text) * float.Parse(textBox14.Text) * float.Parse(textBox4.Text)) +
               float.Parse(textBox10.Text) * float.Parse(textBox13.Text) * float.Parse(textBox1.Text) +
               float.Parse(textBox9.Text) * float.Parse(textBox16.Text) * float.Parse(textBox3.Text))) * div;

            float A7 = (-(((float.Parse(textBox1.Text) * float.Parse(textBox15.Text) * float.Parse(textBox9.Text)) +
             float.Parse(textBox2.Text) * float.Parse(textBox13.Text) * float.Parse(textBox12.Text) +
             float.Parse(textBox4.Text) * float.Parse(textBox16.Text) * float.Parse(textBox11.Text)) -
             ((float.Parse(textBox12.Text) * float.Parse(textBox15.Text) * float.Parse(textBox4.Text)) +
             float.Parse(textBox11.Text) * float.Parse(textBox13.Text) * float.Parse(textBox1.Text) +
             float.Parse(textBox9.Text) * float.Parse(textBox16.Text) * float.Parse(textBox2.Text)))) * div;

            float A8 = (((float.Parse(textBox1.Text) * float.Parse(textBox15.Text) * float.Parse(textBox10.Text)) +
             float.Parse(textBox2.Text) * float.Parse(textBox14.Text) * float.Parse(textBox12.Text) +
             float.Parse(textBox3.Text) * float.Parse(textBox16.Text) * float.Parse(textBox11.Text)) -
             ((float.Parse(textBox12.Text) * float.Parse(textBox15.Text) * float.Parse(textBox3.Text)) +
             float.Parse(textBox11.Text) * float.Parse(textBox14.Text) * float.Parse(textBox1.Text) +
             float.Parse(textBox10.Text) * float.Parse(textBox16.Text) * float.Parse(textBox2.Text))) *div;

            float A9 = (((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox9.Text)) +
             float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox11.Text) +
             float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox10.Text)) -
             ((float.Parse(textBox11.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
             float.Parse(textBox10.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text) +
             float.Parse(textBox9.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text))) * div;

            float A10 = (-(((float.Parse(textBox1.Text) * float.Parse(textBox7.Text) * float.Parse(textBox9.Text)) +
             float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox12.Text) +
             float.Parse(textBox4.Text) * float.Parse(textBox5.Text) * float.Parse(textBox10.Text)) -
             ((float.Parse(textBox12.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
             float.Parse(textBox10.Text) * float.Parse(textBox8.Text) * float.Parse(textBox1.Text) +
             float.Parse(textBox9.Text) * float.Parse(textBox5.Text) * float.Parse(textBox3.Text)))) * div;

            float A11 = (((float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox9.Text)) +
             float.Parse(textBox2.Text) * float.Parse(textBox8.Text) * float.Parse(textBox12.Text) +
             float.Parse(textBox4.Text) * float.Parse(textBox5.Text) * float.Parse(textBox11.Text)) -
             ((float.Parse(textBox12.Text) * float.Parse(textBox6.Text) * float.Parse(textBox4.Text)) +
             float.Parse(textBox11.Text) * float.Parse(textBox8.Text) * float.Parse(textBox1.Text) +
             float.Parse(textBox9.Text) * float.Parse(textBox5.Text) * float.Parse(textBox2.Text))) * div;

            float A12 = (-(((float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox10.Text)) +
             float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox12.Text) +
             float.Parse(textBox3.Text) * float.Parse(textBox5.Text) * float.Parse(textBox11.Text)) -
             ((float.Parse(textBox12.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)) +
             float.Parse(textBox11.Text) * float.Parse(textBox7.Text) * float.Parse(textBox1.Text) +
             float.Parse(textBox10.Text) * float.Parse(textBox5.Text) * float.Parse(textBox2.Text)))) * div;

            float A13= (-(((float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox13.Text)) +
            float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox15.Text) +
            float.Parse(textBox4.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text)) -
            ((float.Parse(textBox15.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
            float.Parse(textBox14.Text) * float.Parse(textBox8.Text) * float.Parse(textBox2.Text) +
            float.Parse(textBox13.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text))))* div;

            float A14 = (((float.Parse(textBox1.Text) * float.Parse(textBox7.Text) * float.Parse(textBox13.Text)) +
            float.Parse(textBox3.Text) * float.Parse(textBox8.Text) * float.Parse(textBox16.Text) +
            float.Parse(textBox4.Text) * float.Parse(textBox5.Text) * float.Parse(textBox14.Text)) -
            ((float.Parse(textBox16.Text) * float.Parse(textBox7.Text) * float.Parse(textBox4.Text)) +
            float.Parse(textBox14.Text) * float.Parse(textBox8.Text) * float.Parse(textBox1.Text) +
            float.Parse(textBox13.Text) * float.Parse(textBox5.Text) * float.Parse(textBox3.Text))) * div;

            float A15 = (-(((float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox13.Text)) +
            float.Parse(textBox2.Text) * float.Parse(textBox8.Text) * float.Parse(textBox16.Text) +
            float.Parse(textBox4.Text) * float.Parse(textBox5.Text) * float.Parse(textBox15.Text)) -
            ((float.Parse(textBox16.Text) * float.Parse(textBox6.Text) * float.Parse(textBox4.Text)) +
            float.Parse(textBox15.Text) * float.Parse(textBox8.Text) * float.Parse(textBox1.Text) +
            float.Parse(textBox13.Text) * float.Parse(textBox5.Text) * float.Parse(textBox2.Text)))) * div;

            float A16 = (((float.Parse(textBox1.Text) * float.Parse(textBox6.Text) * float.Parse(textBox14.Text)) +
            float.Parse(textBox2.Text) * float.Parse(textBox7.Text) * float.Parse(textBox16.Text) +
            float.Parse(textBox3.Text) * float.Parse(textBox5.Text) * float.Parse(textBox15.Text)) -
            ((float.Parse(textBox16.Text) * float.Parse(textBox6.Text) * float.Parse(textBox3.Text)) +
            float.Parse(textBox15.Text) * float.Parse(textBox7.Text) * float.Parse(textBox1.Text) +
            float.Parse(textBox14.Text) * float.Parse(textBox5.Text) * float.Parse(textBox2.Text))) * div;

            textBox1.Text = "" + A1;
            textBox2.Text = "" + A5;
            textBox3.Text = "" + A9;
            textBox4.Text = ""+A13;
            textBox5.Text = "" +A2;
            textBox6.Text = "" + A6;
            textBox7.Text = "" + A10;
            textBox8.Text= "" + A14;
            textBox9.Text = "" + A16;
            textBox10.Text = "" + A12;
            textBox11.Text = "" + A8;
            textBox12.Text = "" + A4;
            textBox13.Text = "" + A15;
            textBox14.Text = "" + A11;
            textBox15.Text = "" + A7;
            textBox16.Text = "" + A3;
            label2.Visible = false; label3.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}