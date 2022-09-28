using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "marka";
            label2.Text = "arac yakıtı";
            label3.Text = "arac yakıt tuketimi";
            label4.Text = "hız";
            label5.Text = "enlem";
            label6.Text = "boylam";
        }
        Arac arac = new Arac();
        private void button1_Click(object sender, EventArgs e)
        {
            arac.marka = textBox1.Text;
            arac.aracYakiti = Convert.ToInt32(textBox2.Text);
            arac.yakitTuketimi = Convert.ToInt32(textBox3.Text);
            arac.hiz = Convert.ToInt32(textBox4.Text);
            arac.enlem = Convert.ToInt32(textBox5.Text);
            arac.boylam = Convert.ToInt32(textBox6.Text);

            string kg = arac.enlem > 0 ? "kuzey" : "guney";
            string bd = arac.boylam > 0 ? "dogu" : "batı";
            label7.Text = $"Arac markanız : {arac.marka} \nArac yakıtınız : {arac.aracYakiti} \nArac yakıt tüketiminiz : {arac.yakitTuketimi} \nArac hızınız : {arac.hiz} km/h \nArac enleminiz : {arac.enlem} {kg} \nArac boylamınız : {arac.boylam} {bd} \n";
        }
    }
}
