using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0; int dogru = 0; int  yanlis = 0 ;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            Lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {

                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ? ";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";

            }

            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz ?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";

            }


        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text= BtnA.Text; 
            if(label4.Text== label5.Text)
            {
                Lbldogru.Text = Convert.ToString(label5.Text);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = Convert.ToString(label4.Text);
                pictureBox1.Visible=true;
            }
        }
    }
}
