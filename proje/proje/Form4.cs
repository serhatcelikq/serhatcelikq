using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string k_adı, şifre;
        string[] veri = { "k_adı", "şifre" };

      

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==veri[0].ToString())
            {
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
                button1.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("GİRİLEN KULANICI ADINA AİT BİRİ BULUNAMADI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(maskedTextBox2.Text==maskedTextBox3.Text)
            { if(maskedTextBox2.Text==veri[1].ToString())
                {
                    MessageBox.Show("yeni şifreniz eskisiyle aynı olamaz");
                }
                else
                {
                    veri[1] = maskedTextBox2.Text;
                    System.IO.File.WriteAllLines(Application.StartupPath + "\\pasword.txt", veri);


                    MessageBox.Show("şifre başarılı bir şekilde değiştirilirdi");
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("yeni parolanız birbirine uymuyor");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            veri = System.IO.File.ReadAllLines(Application.StartupPath + "\\pasword.txt");
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            button1.Enabled = false;
            maskedTextBox2.Mask = "LL???????????????????????";
            maskedTextBox3.Mask = "LL???????????????????????";
        }
    }
}
