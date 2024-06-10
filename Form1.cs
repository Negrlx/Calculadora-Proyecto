using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Proyecto
{
    public partial class Form1 : Form
    {
        double nm1 = 0, nm2 = 0;

        char op;
        bool opv = false;
        bool re = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void imp (object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (re) { textBox2.Text = "0"; re = false; }

            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }

            textBox2.Text += boton.Text;
        }

        private void activadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void conversionDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void activadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                Size = new Size(640, 500);
            }
            else {
                if (panel5.Visible == true)
                {
                    Size = new Size(965, 500);
                }
                else
                {
                    if (panel12.Visible == true)
                    {
                        Size = new Size(955, 500);
                    }
                }
            }

            
            
            
        }

        private void desactivadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (panel4.Visible == true)
            {
                Size = new Size(320, 500);
            }
            else
            {
                if (panel5.Visible == true)
                {
                    Size = new Size(640, 500);
                }
                else { 
                    if (panel12.Visible == true)
                    {
                        Size = new Size(640, 500);
                    } 
                }
            }
        }

        private void modoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
            panel12.Visible = false;
            Size = new Size(320, 500);
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
            panel12.Visible = false;
            Size = new Size(320, 500);
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = true;
            panel12.Visible = false;
            Size = new Size(640, 500);

            button19.Visible = true;
            button71.Visible = true;
            button68.Visible = true;
            button65.Visible = true;
            button31.Visible = true;
            button60.Visible = true;

            button49.Visible = true;
            button48.Visible = true;
            button47.Visible = true;
            button44.Visible = true;
            button43.Visible = true;
            button42.Visible = true;
            button38.Visible = true;
            button37.Visible = true;
            button34.Visible = false;
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel12.Visible = true;
            Size = new Size(640, 500);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = true;
            button71.Visible = true;
            button68.Visible = true;
            button65.Visible = true;
            button31.Visible = true;
            button60.Visible = true;

            button49.Visible = true;
            button48.Visible = true;
            button47.Visible = true;
            button44.Visible = true;
            button43.Visible = true;
            button42.Visible = true;
            button38.Visible = true;
            button37.Visible = true;
            button34.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = false;
            button71.Visible = false;
            button68.Visible = false;
            button65.Visible = false;
            button31.Visible = false;
            button60.Visible = false;

            button49.Visible = false;
            button48.Visible = false;
            button47.Visible = false;
            button44.Visible = false;
            button43.Visible = false;
            button42.Visible = false;
            button38.Visible = false;
            button37.Visible = false;
            button34.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = false;
            button71.Visible = false;
            button68.Visible = false;
            button65.Visible = false;
            button31.Visible = false;
            button60.Visible = false;

            button49.Visible = true;
            button48.Visible = false;
            button47.Visible = false;
            button44.Visible = true;
            button43.Visible = true;
            button42.Visible = true;
            button38.Visible = true;
            button37.Visible = true;
            button34.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button19.Visible = false;
            button71.Visible = false;
            button68.Visible = false;
            button65.Visible = false;
            button31.Visible = false;
            button60.Visible = false;

            button49.Visible = true;
            button48.Visible = true;
            button47.Visible = true;
            button44.Visible = true;
            button43.Visible = true;
            button42.Visible = true;
            button38.Visible = true;
            button37.Visible = true;
            button34.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
                
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Boton (+-)
            nm1 = Convert.ToDouble(textBox2.Text);
            nm1 *= -1;
            textBox2.Text = nm1.ToString();  
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // Boton (C)

            nm1 = 0;
            nm2 = 0;
            op = '\0';
            textBox2.Text = "0"; //string.Empty vacia la cadena, pero tambien se puede solo poner "0"
        }
        private void button9_Click(object sender, EventArgs e)
        {            
            //Boton (CE)

            textBox2.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Boton de borrar un solo numero
            if (textBox2.Text.Length > 1)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1); //(Subtring) es para seleccionar una parte especifica de la cadena
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Boton punto/coma

            if (!textBox2.Text.Contains(".")) //(Contains) permite para saber si aparece cierta cosa dentro de la cadena
            {
                textBox2.Text += ".";
            }
        }

                
        private void opbtt(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
           
            if (!opv)
            {                       
                nm1 = Convert.ToDouble(textBox2.Text);
                op = Convert.ToChar(boton.Tag);

                if (op == 'x' || op == '√')
                {
                    switch (op)
                    {
                        case 'x':
                            nm1 = (1 / nm1);
                            textBox2.Text = nm1.ToString();
                            re = true;
                            break;

                        case '√':
                            nm1 = Math.Sqrt(nm1);
                            textBox2.Text = nm1.ToString();
                            re = true;
                            break;
                    }
                }
                else
                {
                    textBox2.Text = "0";
                }
                opv = true;
            }
            else
            {
                
                button16_Click(sender, e);
                textBox2.Text = "0";                
                opv = true;
            }

        }

        private void porcentaje(object sender, EventArgs e)
        {
            //Boton (%)

            nm2 = Convert.ToDouble(textBox2.Text);
            switch (op)
            {
                case '+':
                    textBox2.Text = (nm1 + (nm1*(nm2/100))).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '-':
                    textBox2.Text = (nm1 - (nm1 * (nm2 / 100))).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '/':
                    textBox2.Text = (nm1 / (nm1 * (nm2 / 100))).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '*':
                    textBox2.Text = (nm1 * (nm1 * (nm2 / 100))).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
            }
            re = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Boton (=) //Tenia que haberle puesto nombre a los botones
            if (!opv) { return; }

            nm2 = Convert.ToDouble(textBox2.Text);
            switch (op)
            {
                case '+':
                    textBox2.Text = (nm1 + nm2).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '-':
                    textBox2.Text = (nm1 - nm2).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '/':
                    textBox2.Text = (nm1 / nm2).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;
                case '*':
                    textBox2.Text = (nm1 * nm2).ToString();
                    nm1 = Convert.ToDouble(textBox2.Text);
                    break;                
            }


            opv = false;
            re = true;
        }

        private void modoClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modoOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
