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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string k_adı,şifre;
        string[] veri = { "k_adı", "şifre" };    
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            veri=System.IO.File.ReadAllLines(Application.StartupPath + "\\pasword.txt");
            textBox2.PasswordChar = '*';          
        }    
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        { if(textBox1.Text==""||textBox2.Text=="")
            {
               
                MessageBox.Show("kutucuklar boş bırakılamaz");
            }
            else
            {
                int HAK = (int)Convert.ToDouble(label6.Text);
                if (textBox1.Text == veri[0].ToString() && textBox2.Text == veri[1].ToString())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞMİŞTİR");
                    Form3 f3 = new Form3();

                    f3.ShowDialog();
                    this.Close();
                }
                else
                {
                    HAK--;
                    label6.Text = Convert.ToString(HAK);
                    {
                        if (HAK != 0)
                        {
                            MessageBox.Show("YANLIŞ KULANICI ADI VEYA PAROLA TEKRAR DENEYİNİZ");
                        }
                        else
                        {
                            MessageBox.Show("ÇOK FAZLA YANLIŞ GİRİŞ DENENDİ UYGULAMA KAPANIYOR");
                            Application.Exit();
                        }
                    }
           
                }
               
               
            }

        }
    }
}
