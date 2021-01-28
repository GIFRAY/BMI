using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
        
    {
        double mass, lenght, BMI;
        string mass_str, lenght_str, lenght_rep;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            lenght_str = textBox2.Text;
            lenght_rep = lenght_str.Replace(".", ",");

            lenght = Convert.ToDouble(lenght_rep);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           mass = Double.Parse(textBox1.Text);
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            BMI = (mass / (lenght * lenght));
            textBox3.Text = BMI.ToString();
        }
     private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("16 и менее -> выраженный дефицит массы тела \n16 - 18,5 -> недостаточная масса тела(дефицит) \n18,5 - 24 -> нормальная масса тела \n25 - 30 -> избыточная масса тела(предожирение) \n30 - 35 -> ожирение I степени \n35 - 40 -> ожирение II степени \n40 и более -> Ожирение III степени");
        }
    }
}
