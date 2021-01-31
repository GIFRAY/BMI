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
        string lenght_str, lenght_rep, mass_rep;
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

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("16 и менее -> выраженный дефицит массы тела \n16 - 18,5 -> недостаточная масса тела(дефицит) \n18,5 - 24 -> нормальная масса тела \n25 - 30 -> избыточная масса тела(предожирение) \n30 - 35 -> ожирение I степени \n35 - 40 -> ожирение II степени \n40 и более -> Ожирение III степени");
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
            mass_rep = textBox1.Text;
            if (Double.TryParse(mass_rep, out mass))
            {
                if (Double.TryParse(lenght_rep, out lenght))
                {
                }
                else
                {
                    MessageBox.Show("Введите число в поле 'Рост'!");
                }
            }
            else
            {
                MessageBox.Show("Введите число в поле 'Масса' !");
            }   
            

            
           //вывод ->
            BMI = (mass / (lenght * lenght));
            textBox3.Text = BMI.ToString();

          
            
            
            
            
            if (BMI > 40)
            {
                label4.Text = "Ожирение III степени";
            }
            else
            {
                if (BMI > 35)
                {
                    label4.Text = "Ожирение II степени";
                }
                else
                {
                    if (BMI > 30)
                    {
                        label4.Text = "Ожирение I степени";
                    }
                    else
                    {
                        if (BMI > 24)
                        {
                            label4.Text = "Избыточная масса тела (предожирение)";
                        }
                        else
                        {
                            if (BMI > 18.5)
                            {
                                label4.Text = "Нормальная масса тела";
                            }


                            else
                            {
                                if (BMI > 16)
                                {
                                    label4.Text = "Недостаточная масса тела (дефицит)";
                                }
                                else

                                {
                                    label4.Text = "Выраженный дефицит массы тела";
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
                            
    

