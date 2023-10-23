using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int ADET;
        int TEXTSAYI;
        int para;
        int fiyat;
        int alışadedi;
       
        
       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
           
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown1.Text);
            int al = (int)Convert.ToDouble(label109.Text);
            ADET = (int)Convert.ToDouble(label60.Text);
            fiyat = (int)Convert.ToDouble(label33.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11= (int)Convert.ToDouble(label101.Text);
            int fiyat12= (int)Convert.ToDouble(label102.Text);
            
            para = (int)Convert.ToDouble(label124.Text);

            numericUpDown1.Value = 0;

            if (TEXTSAYI>0&&TEXTSAYI<=al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
               
                ADET = ADET +TEXTSAYI;
                satışbilgisi[0] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt",satışbilgisi);
                label60.Text = satışbilgisi[0];
                para = para + fiyat * TEXTSAYI;
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];





                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
               
               
               

            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }
            
        }

        double veri1,satış1,satış2,satış3,satış4,satış5,satış6,alış1,alış2,alış3,alış4,alış5,alış6;
        String[] fiyat_bilgisi = { "veri1" };
        string[] satışbilgisi = { "satış1", "satış2", "satış3", "satış4", "satış5", "satış6" };
        string[] alışbilgisi = { "alış1", "alış2", "alış3", "alış4", "alış5", "alış6" };
       
     private void dataoku()
        {
            fiyat_bilgisi = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            satışbilgisi = System.IO.File.ReadAllLines(Application.StartupPath + "\\satışadet.txt");
            alışbilgisi = System.IO.File.ReadAllLines(Application.StartupPath + "\\alışadet.txt");


            label124.Text = fiyat_bilgisi[0];
            label122.Text = fiyat_bilgisi[0];

            label60.Text = satışbilgisi[0];
            label55.Text = satışbilgisi[1];
            label56.Text = satışbilgisi[2];
            label57.Text = satışbilgisi[3];
            label58.Text = satışbilgisi[4];
            label59.Text = satışbilgisi[5];

            label109.Text = alışbilgisi[0];
            label110.Text = alışbilgisi[1];
            label111.Text = alışbilgisi[2];
            label112.Text = alışbilgisi[3];
            label113.Text = alışbilgisi[4];
            label114.Text = alışbilgisi[5];
          

        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            dataoku();
            int sayı1 = (int)Convert.ToDouble(label60.Text);
            int sayı2 = (int)Convert.ToDouble(label55.Text);
            int sayı3 = (int)Convert.ToDouble(label56.Text);
            int sayı4 = (int)Convert.ToDouble(label57.Text);
            int sayı5 = (int)Convert.ToDouble(label58.Text);
            int sayı6 = (int)Convert.ToDouble(label59.Text);
            int sayı7 = (int)Convert.ToDouble(label109.Text);
            int sayı8 = (int)Convert.ToDouble(label110.Text);
            int sayı9 = (int)Convert.ToDouble(label111.Text);
            int sayı10 =(int)Convert.ToDouble(label112.Text);
            int sayı11= (int)Convert.ToDouble(label113.Text);
            int sayı12= (int)Convert.ToDouble(label114.Text);
            int para = (int)Convert.ToDouble(label97.Text);
            int para1 = (int)Convert.ToDouble(label98.Text);
            int para2= (int)Convert.ToDouble(label99.Text);
            int para3= (int)Convert.ToDouble(label100.Text);
            int para4= (int)Convert.ToDouble(label101.Text);
            int para5= (int)Convert.ToDouble(label102.Text);
            int moneys = (int)Convert.ToDouble(label122.Text);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = sayı7-sayı1;
            numericUpDown1.Increment = 1;
            numericUpDown1.ReadOnly = true;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = sayı8-sayı2;
            numericUpDown2.Increment = 1;
            numericUpDown2.ReadOnly = true;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = sayı9-sayı3;
            numericUpDown3.Increment = 1;
            numericUpDown3.ReadOnly = true;

            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = sayı10-sayı4;
            numericUpDown4.Increment = 1;
            numericUpDown4.ReadOnly = true;

            numericUpDown5.Minimum = 0;
            numericUpDown5.Maximum = sayı11-sayı5;
            numericUpDown5.Increment = 1;
            numericUpDown5.ReadOnly = true;

            numericUpDown6.Minimum = 0;
            numericUpDown6.Maximum = sayı12-sayı6;
            numericUpDown6.Increment = 1;
            numericUpDown6.ReadOnly = true;
            numericUpDown7.Minimum = 0;
          
            numericUpDown7.Increment = 1;
            numericUpDown8.Minimum = 0;
          
            numericUpDown8.Increment = 1;
            numericUpDown9.Minimum = 0;
           
            numericUpDown9.Increment = 1;
            numericUpDown10.Minimum = 0;
            
            numericUpDown10.Increment = 1;
            numericUpDown11.Minimum = 0;
           
            numericUpDown11.Increment = 1;
            numericUpDown12.Minimum = 0;
            
            numericUpDown12.Increment = 1;
            numericUpDown7.ReadOnly = true;
            numericUpDown8.ReadOnly = true;
            numericUpDown9.ReadOnly = true;
            numericUpDown10.ReadOnly = true;
            numericUpDown11.ReadOnly = true;
            numericUpDown12.ReadOnly = true;

           
        }

       

        
        private void button2_Click(object sender, EventArgs e)
        {
            int al = (int)Convert.ToDouble(label110.Text);
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown2.Text);
            ADET = (int)Convert.ToDouble(label55.Text);
            fiyat = (int)Convert.ToDouble(label36.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11 = (int)Convert.ToDouble(label101.Text);
            int fiyat12 = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
            numericUpDown2.Value = 0;

            if (TEXTSAYI > 0 && TEXTSAYI <= al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
                para = para + fiyat * TEXTSAYI;
                ADET = ADET + TEXTSAYI;
                numericUpDown2.Maximum = al - ADET;
                satışbilgisi[1] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt", satışbilgisi);
                label55.Text = satışbilgisi[1];
               

               
               
                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
               
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];


            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int al = (int)Convert.ToDouble(label111.Text);
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown3.Text);
            ADET = (int)Convert.ToDouble(label56.Text);
            fiyat = (int)Convert.ToDouble(label39.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11 = (int)Convert.ToDouble(label101.Text);
            int fiyat12 = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
           

            if (TEXTSAYI > 0 && TEXTSAYI <=al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
                para = para + fiyat * TEXTSAYI;
                ADET = ADET + TEXTSAYI;
                satışbilgisi[2] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt", satışbilgisi);
                label56.Text = satışbilgisi[2];

                numericUpDown3.Maximum = al -ADET;
                numericUpDown3.Value = 0;
                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
               
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];



            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int al = (int)Convert.ToDouble(label112.Text);
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown4.Text);
            ADET = (int)Convert.ToDouble(label57.Text);
            fiyat = (int)Convert.ToDouble(label42.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11 = (int)Convert.ToDouble(label101.Text);
            int fiyat12 = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
            

            if (TEXTSAYI > 0 && TEXTSAYI <=al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
                para = para + fiyat * TEXTSAYI;
                ADET = ADET + TEXTSAYI;
                satışbilgisi[3] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt", satışbilgisi);
                label57.Text = satışbilgisi[3];
                numericUpDown4.Maximum = al-ADET;
                numericUpDown4.Value = 0;
                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
              
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];


            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int al = (int)Convert.ToDouble(label113.Text);
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown5.Text);
            ADET = (int)Convert.ToDouble(label58.Text);
            fiyat = (int)Convert.ToDouble(label45.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11 = (int)Convert.ToDouble(label101.Text);
            int fiyat12 = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
           

            if (TEXTSAYI > 0 && TEXTSAYI <= al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
                para = para + fiyat * TEXTSAYI;
                ADET = ADET + TEXTSAYI;
                satışbilgisi[4] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt", satışbilgisi);
                label58.Text = satışbilgisi[4];
                numericUpDown5.Maximum =al- ADET;
                numericUpDown5.Value = 0;
                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
             
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int al = (int)Convert.ToDouble(label114.Text);
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown6.Text);
            ADET = (int)Convert.ToDouble(label59.Text);
            fiyat = (int)Convert.ToDouble(label48.Text);
            int fiyat7 = (int)Convert.ToDouble(label97.Text);
            int fiyat8 = (int)Convert.ToDouble(label98.Text);
            int fiyat9 = (int)Convert.ToDouble(label99.Text);
            int fiyat10 = (int)Convert.ToDouble(label100.Text);
            int fiyat11 = (int)Convert.ToDouble(label101.Text);
            int fiyat12 = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
            

            if (TEXTSAYI > 0 && TEXTSAYI <=al-ADET)
            {
                MessageBox.Show("İŞLEMİNİZ BAŞARILI");
                para = para + fiyat * TEXTSAYI;
                ADET = ADET + TEXTSAYI;
                satışbilgisi[5] = Convert.ToString(ADET);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\satışadet.txt", satışbilgisi);
                label59.Text = satışbilgisi[5];
                numericUpDown6.Maximum =al- ADET;
                numericUpDown6.Value = 0;
                numericUpDown7.Maximum = para / fiyat7;
                numericUpDown8.Maximum = para / fiyat8;
                numericUpDown9.Maximum = para / fiyat9;
                numericUpDown10.Maximum = para / fiyat10;
                numericUpDown11.Maximum = para / fiyat11;
                numericUpDown12.Maximum = para / fiyat12;
                label59.Text = Convert.ToString(ADET);
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];


            }
            else
            {
                MessageBox.Show("LÜTFEN SİZE VERİLEN ADET SAYISI KADAR GİRİNİZ");
            }

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown7.Text);
            alışadedi = (int)Convert.ToDouble(label109.Text);
            fiyat = (int)Convert.ToDouble(label97.Text);        
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label60.Text);
            numericUpDown7.Value = 0;


            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label109.Text = alışbilgisi[0];
                numericUpDown1.Maximum = alışadedi - ADET;



               
               

                para = para - fiyat * TEXTSAYI;
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

                numericUpDown7.Maximum = para / fiyat;

                
               

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown8.Text);
            alışadedi = (int)Convert.ToDouble(label110.Text);
            fiyat = (int)Convert.ToDouble(label98.Text);
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label55.Text);
            numericUpDown8.Value = 0;

            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label110.Text = alışbilgisi[0];
                ADET = ADET + TEXTSAYI;
                numericUpDown2.Maximum = alışadedi - ADET;
          
               
              
                para = para - fiyat * TEXTSAYI;
                numericUpDown8.Maximum = para / fiyat;

                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown9.Text);
            alışadedi = (int)Convert.ToDouble(label111.Text);
            fiyat = (int)Convert.ToDouble(label99.Text);
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label56.Text);
            numericUpDown9.Value = 0;

            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label111.Text = alışbilgisi[0];
                ADET = ADET + TEXTSAYI;
                numericUpDown3.Maximum = alışadedi - ADET;
       
               
              
              
                para = para - fiyat * TEXTSAYI;
                numericUpDown9.Maximum = para / fiyat;

                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown10.Text);
            alışadedi = (int)Convert.ToDouble(label112.Text);
            fiyat = (int)Convert.ToDouble(label100.Text);
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label57.Text);
            numericUpDown10.Value = 0;

            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label112.Text = alışbilgisi[0];
                ADET = ADET + TEXTSAYI;
                numericUpDown4.Maximum = alışadedi - ADET;
              
               
              
               
                para = para - fiyat * TEXTSAYI;
                numericUpDown10.Maximum = para / fiyat;

                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown11.Text);
            alışadedi = (int)Convert.ToDouble(label113.Text);
            fiyat = (int)Convert.ToDouble(label101.Text);
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label58.Text);
            numericUpDown11.Value = 0;

            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label113.Text = alışbilgisi[0];
                ADET = ADET + TEXTSAYI;
                numericUpDown5.Maximum = alışadedi - ADET;
              
               
              
              
                para = para - fiyat * TEXTSAYI;
               
                numericUpDown11.Maximum = para / fiyat;
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TEXTSAYI = (int)Convert.ToDouble(numericUpDown12.Text);
            alışadedi = (int)Convert.ToDouble(label114.Text);
            fiyat = (int)Convert.ToDouble(label102.Text);
            para = (int)Convert.ToDouble(label124.Text);
            ADET = (int)Convert.ToDouble(label59.Text);
            numericUpDown12.Value = 0;

            if (TEXTSAYI > 0 && fiyat * TEXTSAYI <= para && para > 0)
            {
                MessageBox.Show("işleminiz başarılı bir şekilde gerçekleşmiştir");
                alışadedi = alışadedi + TEXTSAYI;
                alışbilgisi[0] = Convert.ToString(alışadedi);
                System.IO.File.WriteAllLines(Application.StartupPath + "\\alışadet.txt", alışbilgisi);
                label114.Text = alışbilgisi[0];
                ADET = ADET + TEXTSAYI;
               
               
                
              
                para = para - fiyat * TEXTSAYI;
                numericUpDown6.Maximum = alışadedi - ADET;
              
                numericUpDown12.Maximum = para / fiyat;
                fiyat_bilgisi[0] = Convert.ToString(para);
                System.IO.File.WriteAllText(Application.StartupPath + "\\fiyat.txt", fiyat_bilgisi[0]);
                label124.Text = fiyat_bilgisi[0];
                label122.Text = fiyat_bilgisi[0];

            }
            else
            {
                MessageBox.Show("LÜTFEN  paranızı kontrl ediniz");
            }
        }

        private void label132_Click(object sender, EventArgs e)
        {

        }

        private void label135_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            int fiy1, fiy2, fiy3, fiy4, fiy5, fiy6, toplam1 = 0 ;
            int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6, toplam = 0; ;
            sayı1 = (int)Convert.ToDouble(label109.Text);
            sayı2 = (int)Convert.ToDouble(label110.Text);
            sayı3 = (int)Convert.ToDouble(label111.Text);
            sayı4 = (int)Convert.ToDouble(label112.Text);
            sayı5 = (int)Convert.ToDouble(label113.Text);
            sayı6 = (int)Convert.ToDouble(label114.Text);
            fiy1 = (int)Convert.ToDouble(label97.Text);
            fiy2 = (int)Convert.ToDouble(label98.Text);
            fiy3 = (int)Convert.ToDouble(label99.Text);
            fiy4 = (int)Convert.ToDouble(label100.Text);
            fiy5 = (int)Convert.ToDouble(label101.Text);
            fiy6 = (int)Convert.ToDouble(label102.Text);

            toplam = sayı1 + sayı2 + sayı3 + sayı4 + sayı5 + sayı6;
            label135.Text = Convert.ToString(toplam);
            toplam1 = fiy1 * sayı1 + fiy2 * sayı2 + fiy3 * sayı3 + fiy4 * sayı4 + fiy5 * sayı5 + fiy6 * sayı6;
            label136.Text = Convert.ToString(toplam1);
            
              
            int fiyy1, fiyy2, fiyy3, fiyy4, fiyy5, fiyy6, toplam11 = 0;
            int sayıı1=0, sayıı2=0, sayıı3=0, sayıı4=0, sayıı5=0, sayıı6=0, toplamm = 0; ;
            sayıı1 = (int)Convert.ToDouble(label60.Text);
            sayıı2 = (int)Convert.ToDouble(label55.Text);
            sayıı3 = (int)Convert.ToDouble(label56.Text);
            sayıı4 = (int)Convert.ToDouble(label57.Text);
            sayıı5 = (int)Convert.ToDouble(label58 .Text);
            sayıı6 = (int)Convert.ToDouble(label59.Text);
            fiyy1 = (int)Convert.ToDouble(label33.Text);
            fiyy2 = (int)Convert.ToDouble(label36.Text);
            fiyy3 = (int)Convert.ToDouble(label39.Text);
            fiyy4 = (int)Convert.ToDouble(label42.Text);
            fiyy5 = (int)Convert.ToDouble(label45.Text);
            fiyy6 = (int)Convert.ToDouble(label48.Text);
            toplam11 = sayıı1 + sayıı2 + sayıı3 + sayıı4 + sayıı5 + sayıı6;
            label137.Text = Convert.ToString(toplam11);
            toplamm = fiyy1 * sayıı1 + fiyy2 * sayıı2 + fiyy3 * sayıı4 + fiyy4 * sayıı4 + fiyy5 * sayıı5 + fiyy6 * sayıı6;
            label138.Text = Convert.ToString(toplamm);          
            label140.Text = label124.Text;
            int SATIŞ = (int)Convert.ToDouble(label138.Text);
            int ALIŞ = (int)Convert.ToDouble(label136.Text);
            int KARZARAR = SATIŞ - ALIŞ;
            label141.Text = Convert.ToString(KARZARAR);
           
           


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            button8.Enabled = true;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            button9.Enabled = true;
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            button10.Enabled = true;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            button11.Enabled = true;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            button12.Enabled = true;
        }
    }
}

