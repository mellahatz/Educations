using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Girilen 2 sayıyı toplayan metot

        int toplam(int s1, int s2)
        {
           int toplam = s1 + s2;
            return toplam;
                
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
            
            textBox1.Text = "".ToString();
            textBox2.Text= "".ToString();
            label3.Text = toplam(s1, s2).ToString();
            label1.Text = "sayı 1";
            label2.Text = "sayı 2";

        }
    }
}
