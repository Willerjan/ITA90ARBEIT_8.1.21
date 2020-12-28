using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITA90ARBEIT_8._1._21
{
    public partial class Form1 : Form
    {


        public double zahl1, zahl2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }
         
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrolle();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrolle();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kontrolle();
        }

        private void cmb2_TextChanged(object sender, EventArgs e)
        {
            kontrolle();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            kontrolle();
        }



        public void kontrolle()
        {

            if (textBox1.Text == "")
            {

            }
            else
            {
                zahl1 = double.Parse(textBox1.Text);

                Update();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char überbrüffe = e.KeyChar;
            if(!Char.IsDigit(überbrüffe) && überbrüffe != 8)
            {
                e.Handled = true;
                MessageBox.Show("Bitte nur Zahlen eingeben");
            }
        }

       
        public void Update()
        {
            if(cmb1.Text == "Kelvin")
            {
                if(cmb2.Text == "Kelvin")
                {
                    zahl2 = zahl1;
                    textBox2.Text = zahl2.ToString();
                }
                if(cmb2.Text == "Celsius")
                {
                    zahl2 = zahl1 - 273.15;
                    textBox2.Text = zahl2.ToString();
                }
                if(cmb2.Text == "Fahrenheit")
                {
                    zahl2 = zahl1 * 1.8 - 459.67;
                    textBox2.Text = zahl2.ToString();
                }
            }
            if (cmb1.Text == "Celsius")
            {
                if(cmb2.Text == "Kelvin")
                {
                    zahl2 = zahl1 + 273.15;
                    textBox2.Text = zahl2.ToString();
                }
                if(cmb2.Text == "Celsius")
                {
                    zahl2 = zahl1;
                    textBox2.Text = zahl2.ToString();
                }
                if(cmb2.Text == "Fahrenheit")
                {
                    zahl2 = zahl1 * 1.8 + 32;
                    textBox2.Text = zahl2.ToString();
                }
            }
            if (cmb1.Text == "Fahrenheit")
            {
                if (cmb2.Text == "Kelvin")
                {
                    zahl1 = zahl1 + 459.67;
                    zahl2 = zahl1 * 5 / 9;
                    textBox2.Text = zahl2.ToString();
                }
                if (cmb2.Text == "Celsius")
                {
                    zahl1 = zahl1 - 32;
                    zahl2 = zahl1 * 5 / 9;
                    textBox2.Text = zahl2.ToString();
                }
                if (cmb2.Text == "Fahrenheit")
                {
                    zahl2 = zahl1;
                    textBox2.Text = zahl2.ToString();
                }
            }
        }
    }
}
