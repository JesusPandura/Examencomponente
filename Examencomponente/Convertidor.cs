using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaGradosaFarenheit;

namespace Examencomponente
{
    public partial class Convertidor : UserControl
    {
        public Convertidor()
        {
            InitializeComponent();
        }
        double uno = 0.0;
        double dos = 0.0;
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                uno = double.Parse(textBox1.Text);

                textBox2.Text = opera.gradoscaF(uno).ToString();


            }



            if (radioButton2.Checked)
            {
                dos = double.Parse(textBox2.Text);


                textBox1.Text = opera.gradosfac(dos).ToString();
                    

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
 }

