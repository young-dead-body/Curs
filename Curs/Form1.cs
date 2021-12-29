using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;

namespace Curs
{
    public partial class Form1 : Form
    {
        int budhour;
        int budmin;
        int kolvotemp = 1;
        int smesh = 0;
        bool flag = false;
        bool numtel = false;
        int vstav;
        //int starnum;
        SoundPlayer sndPlayer, sndPlayer1, sndPlayer2;
        int panel = 1;
        void Panel1()
        {
            panel = 1;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\zastavka.jpg");
            //this.BackgroundImage = new Bitmap(@"Resourse\SCIZld5pCNk.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Clock.Visible = true;
            Trybka.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Zvonok.Visible = false;
            Sbros.Visible = false;
            Otklon.Visible = false;
            Otvetit.Visible = false;
            Kontacti.Visible = false;
            Dobnewcont.Visible = false;
            Gotovo.Visible = false;
            flowLayoutPanel1.Visible = false;
            Soobsh.Visible = true;
            textBox10.Visible = false;
            textBox9.Visible = false;
            textBox8.Visible = false;
            Otpravit.Visible = false;
            flowLayoutPanel1.Visible = false;
            panel1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            Otmenit.Visible = false;
            VibKontSMS.Visible = false;
            OtmDobCont.Visible = false;
            Internet.Visible = true;
            Vihod.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }
        void Panel2()
        {
            panel = 2;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\mob.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Clock.Visible = false;
            Trybka.Visible = false;
            Vihod.Visible = false;
            Internet.Visible = false;
            textBox3.Visible = true;
            label1.Visible = true;
            Zvonok.Visible = true;
            Kontacti.Visible = true;
            Soobsh.Visible = false;
        }

        void Panel3()
        {
            panel = 3;
            Kontacti.Visible = false;
            Zvonok.Visible = false;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\Zvonok.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "Идет вызов";
            Sbros.Visible = true;
            //sndPlayer1 = new SoundPlayer(@"D:\Curs\Curs\Resources\Gydok.wav");
            sndPlayer1 = new SoundPlayer(@"Resourse\Gydok.wav");

            //тут запускаем таймер на 36 секунд
            timer5.Enabled = true;

            sndPlayer1.Play();
            numtel = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label1.Location = new System.Drawing.Point(60, 50);
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, 
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Text = "Нет ответа, на указанный номер";
            timer6.Enabled = true;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            // тут делаем переход к странице дозвона
            Panel2();
        }

        void Panel4()
        {
            panel = 4;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\kont.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            Clock.Visible = false;
            Trybka.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            Zvonok.Visible = false;
            Kontacti.Visible = false;

            flowLayoutPanel1.Visible = true;
            Dobnewcont.Visible = true;

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;

            listBox1.Items.Clear();

            StreamReader reader = new StreamReader("контакты.txt"); // открытие файла с базой данных
                                                              // и считывание информации из него
            while (!reader.EndOfStream)
            {
                listBox1.Items.Add(reader.ReadLine());
            }
            reader.Close(); // ОБЯЗАТЕЛЬНОЕ ЗАКРЫТИЕ ФАЙЛА
        }

        void Panel5()
        {
            panel = 5;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\dobcontact.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            Clock.Visible = false;
            Trybka.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            Zvonok.Visible = false;
            Kontacti.Visible = false;
            Dobnewcont.Visible = false;
            Gotovo.Visible = true;
            Dobnewcont.Visible = false;
            flowLayoutPanel1.Visible = false;

            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            OtmDobCont.Visible = true;

            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            Sbros.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
        }


        public Form1()
        {
           
            InitializeComponent();

            kolvotemp = 0;
            //картинка на фон
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\zastavka.jpg");
            //this.BackgroundImage = new Bitmap(@"D:\Curs\Curs\Resources\SCIZld5pCNk.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            //круглая кнопка home
            System.Drawing.Drawing2D.GraphicsPath myPath =new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, button1.Width, button1.Height);
            Region myRegion = new Region(myPath);
            button1.Region = myRegion;
        }
                
        

        private void button1_Click(object sender, EventArgs e) // кнопка домой
        {
            Panel1();
        }

        private void label5_Click(object sender, EventArgs e)// кнопка сохранить у будильника
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите время когда должен сработать будильник!");
            }
            else
            {
                budhour = Convert.ToInt32(textBox1.Text);
                budmin = Convert.ToInt32(textBox2.Text);

                string sHH = DateTime.Now.ToString("HH");
                string smm = DateTime.Now.ToString("mm");
                string sss = DateTime.Now.ToString("ss");

                int ss1 = Convert.ToInt32(sHH) * 120 + Convert.ToInt32(smm) * 60 + Convert.ToInt32(sss);

                int ss2 = budhour * 120 + budmin * 60;

                int ttt = 1000 * (ss2 - ss1);
                timer1.Interval = ttt;

                timer1.Enabled = true;

                timer1.Start();

                button1_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)// таймер для будильника
        {
            timer1.Interval = 30000;
            sndPlayer = new SoundPlayer(@"Resourse\bud.wav");
            sndPlayer.Play();
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\C7ScxuFswkY.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Clock.Visible = false;
            Trybka.Visible = false;
            Soobsh.Visible = false;
            Internet.Visible = false;
            Vihod.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            label2.Text = DateTime.Now.ToString("HH:mm");
        }

        private void label6_Click(object sender, EventArgs e) // остановка будильника
        {
            sndPlayer.Stop();
            timer1.Stop();
            timer1.Interval = 1000;
            timer1.Enabled = false;
            button1_Click(sender, e);
        }

        bool menuHour = false;
        private void Clock_Click(object sender, EventArgs e) //кнопка "Часы"
        {
            //flaglabel1 = true;
            Clock.Visible = false;
            Vihod.Visible = false;
            Internet.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            Trybka.Visible = false;
            Soobsh.Visible = false;
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\qiccg-h4eMo.jpg");
            //this.BackgroundImage = new Bitmap(@"Resourse\SCIZld5pCNk.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            menuHour = true;
            //MessageBox.Show("Недопустимый символ!");
        }

        private void Trybka_Click(object sender, EventArgs e)
        {
            Panel2();
        }

        private void Zvonok_Click(object sender, EventArgs e) // звук на заставке телефона при звонке
        {
            if (textBox3.Text == "" && numtel==false)
            {
                MessageBox.Show("Введите номер телефона!");
            }
            else
            {
                Panel3();
            }
        }

        private void Sbros_Click(object sender, EventArgs e)
        {
            sndPlayer1.Stop();
            label8.Visible = false;
            textBox7.Visible = false;
            Panel2();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Otklon.Visible = true;
            Otvetit.Visible = true;
            Clock.Visible = false;
            Soobsh.Visible = false;
            Internet.Visible = false;
            Trybka.Visible = false;
            Vihod.Visible = false;
          
            textBox3.Visible = true; 
            textBox3.Text="Неизвестно";
            pictureBox1.BackgroundImage = new Bitmap(@"D:\Curs\Curs\Resources\Zvonokmne1.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            if (radioButton1.Checked == true)
                sndPlayer2 = new SoundPlayer(@"D:\Curs\Curs\Resources\zvonokmne.wav");
            else sndPlayer2 = new SoundPlayer(@"D:\Curs\Curs\Resources\vibracija.wav");
            sndPlayer2.Play();                     
        }

        private void Otklon_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            timer3.Stop();
            sndPlayer2.Stop();
            button1_Click(sender, e);
        }

        private void Otvetit_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            sndPlayer2.Stop();

            Otklon.Visible = false;
            Otvetit.Visible = false;

            pictureBox1.BackgroundImage = new Bitmap(@"D:\Curs\Curs\Resources\Zvonok.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            textBox3.Visible = true;
            Sbros.Visible = true;
            sndPlayer1 = new SoundPlayer(@"D:\Curs\Curs\Resources\Razgovor.wav");
            sndPlayer1.Play();                        
        }

        private void Kontacti_Click(object sender, EventArgs e)
        {
            Panel4();
            kolvotemp = listBox1.Items.Count;

        }

        private void Dobnewcont_Click(object sender, EventArgs e) // кнопка добавления контакта
        {
            Panel5();
        }       
              
        private void Gotovo_Click(object sender, EventArgs e)// готово кнопка (добавление контакта)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Введите данные контакта!");
            }
            else
            {
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                Dobnewcont.Visible = false;
                Gotovo.Visible = false;
                OtmDobCont.Visible = false;


                if (flag == true)
                {
                    try
                    {
                        listBox1.Items.RemoveAt(vstav);
                        listBox1.Items.Insert(vstav, textBox4.Text + " " + textBox5.Text + " " + textBox6.Text);
                        rewriteBDEvent("контакты.txt");
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                {
                    listBox1.Items.Add(textBox4.Text + " " + textBox5.Text + " " + textBox6.Text);
                    kolvotemp++;
                    rewriteBDEvent("контакты.txt");
                }
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button6.Visible = true;

                Kontacti_Click(sender, e);
            }
        }

        public void rewriteBDEvent(String FileName)
        {
            FileStream file = new FileStream(FileName, FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                writer.WriteLine(listBox1.Items[i]);
            }
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)// кнопка позвонить
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Контакт не выбран!");
            }
            else
            {
                numtel = true;
                string num = "";
                string name = "";
                string fam = "";

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.SelectedIndex == i)
                    {
                        String s = Convert.ToString(listBox1.Items[i]);
                        String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        num = words[2];
                        name = words[0];
                        fam = words[1];
                    }
                }

                textBox7.Visible = true;
                flowLayoutPanel1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                Dobnewcont.Visible = false;
                label8.Visible = true;
                label8.Text = name + " " + fam;
                textBox7.Text = num;
                Zvonok_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)// удалить
        {
            if (listBox1.SelectedIndex <0)                
            {
                MessageBox.Show("Контакт не выбран!");
            }
            else
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить данного абонента?", "Подтвердите удаление",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.SelectedIndex == i)
                        {
                            listBox1.Items.RemoveAt(i);
                            kolvotemp--;
                            rewriteBDEvent("контакты.txt");
                        }
                    }
                }
            }     
        }

        bool messageOpen = false;
        private void Soobsh_Click(object sender, EventArgs e) // кнопка сообщения
        {
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\naborsoobsh.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            Soobsh.Visible = false;
            Trybka.Visible = false;
            Vihod.Visible = false;
            Clock.Visible = false;
            Internet.Visible = false;
            textBox8.Visible = true;
            textBox9.Visible = true;
            //textBox10.Visible = true;
            Otpravit.Visible = true;
            panel1.Visible = true;
            Otmenit.Visible = true;
            VibKontSMS.Visible = true;
           //========================
            messageOpen = true;
            


            //if (textBox8.Text != Convert.ToString(starnum))
            //{
            //    panel1.Controls.Clear();
            //    textBox8.Text = "";
            //    smesh = 0;
            //}
        }

        private void IsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Otpravit_Click(object sender, EventArgs e) // кнопка отправки смс знак вверх
        {
            if (textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Введите номер телефона и/или текст сообщения!");
            }
            else
            {
                //starnum = Convert.ToInt32(textBox8.Text);
                //textBox10.Text = textBox8.Text;

                string[] strArr = new string[4];
                strArr[0] = "Я на совещании";
                strArr[1] = "Позвоню как буду дома";
                strArr[2] = "Сейчас занят";
                strArr[3] = "Позвоню позже";
                //Console.WriteLine(strArr[new Random().Next(0, strArr.Length)]);
                
                TextBox tb = new TextBox();

                tb = new System.Windows.Forms.TextBox();
                tb.Location = new System.Drawing.Point(170, 2 + smesh);
                tb.Size = new System.Drawing.Size(140, 20);
                tb.Text = textBox9.Text;
                panel1.Controls.Add(tb);

                tb.BringToFront();
                tb.KeyPress += new KeyPressEventHandler(IsDigit_KeyPress);

                textBox9.Text = "";


                TextBox tbSOB = new TextBox();
                tbSOB = new System.Windows.Forms.TextBox();
                tbSOB.Location = new System.Drawing.Point(2, 27 + smesh);
                tbSOB.Size = new System.Drawing.Size(140, 20);
                tbSOB.Text = strArr[new Random().Next(0, strArr.Length)];
                panel1.Controls.Add(tbSOB);
                tbSOB.BringToFront();
                tbSOB.KeyPress += new KeyPressEventHandler(IsDigit_KeyPress);

                smesh = smesh + 50;
            }
        }

        private void button4_Click(object sender, EventArgs e)// кнопка отправить смс
        {
             if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Контакт не выбран!");
            }
            else
            {
                string num = "";
                string name = "";
                string fam = "";

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.SelectedIndex == i)
                    {
                        String s = Convert.ToString(listBox1.Items[i]);
                        String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        num = words[2];
                        name = words[0];
                        fam = words[1];
                    }
                }

                flowLayoutPanel1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                Dobnewcont.Visible = false;
                textBox8.Text = num;
                //starnum = Convert.ToInt32(textBox8.Text);
                textBox10.Visible = true;
                textBox10.Text = name + " " + fam;
                Soobsh_Click(sender, e);
                panel = 10;
            }
        }

        private void Otmenit_Click(object sender, EventArgs e) // кнопка отменить
        {
            //panel1.Controls.Clear();
            //textBox10.Text = "";
            //smesh = 0;
            if (panel == 10)
            {
                Panel1();
                Panel2();
                Panel4();
            }
            else { Panel1(); }
        }

        private void VibKontSMS_Click(object sender, EventArgs e) // кнопка большого плюса предположение - добавть контак
        {
            pictureBox1.BackgroundImage = new Bitmap(@"Resourse\kont.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            Clock.Visible = false;
            Trybka.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            Zvonok.Visible = false;
            Kontacti.Visible = false;
            panel1.Visible = false;
            Otmenit.Visible = false;

            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Otpravit.Visible = false;
            VibKontSMS.Visible = false;

            Dobnewcont.Visible = false;

            flowLayoutPanel1.Visible = true;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) // выбрать номер
        {
            string num = "";
            string name = "";
            string fam = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.SelectedIndex == i)
                {
                    String s = Convert.ToString(listBox1.Items[i]);
                    String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    num = words[2];
                    name = words[0];
                    fam = words[1];
                }
            }            
            flowLayoutPanel1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            Dobnewcont.Visible = false;
            textBox8.Text = num;
            //starnum = Convert.ToInt32(textBox8.Text);
            textBox10.Visible = true;
            textBox10.Text = name + " " + fam;
            Soobsh_Click(sender, e);
        }

        private static void zapretnavvodcifr(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private static void zapretnavvodbukv(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodcifr(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodcifr(e);
        }        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodbukv(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodbukv(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodbukv(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodbukv(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            zapretnavvodbukv(e);
        }

        private void button6_Click(object sender, EventArgs e)// редактировать номер
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Контакт не выбран!");
            }
            else
            {
                flag = true;
                string num = "";
                string name = "";
                string fam = "";

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.SelectedIndex == i)
                    {
                        String s = Convert.ToString(listBox1.Items[i]);
                        String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        num = words[2];
                        name = words[0];
                        fam = words[1];
                        vstav = i;
                    }
                }

                Dobnewcont_Click(sender, e);

                textBox4.Text = name;
                textBox5.Text = fam;
                textBox6.Text = num;
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            smesh = 0;
            textBox10.Visible = false;
        }

        private void OtmDobCont_Click(object sender, EventArgs e) // кнопка отменить
        {
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            OtmDobCont.Visible = false;
            Dobnewcont.Visible = false;
            Gotovo.Visible = false;
            Kontacti_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 613;
            this.Height = 1005;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vihod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text += "#";
        }

        /// <summary>
        /// ВЫВОД В ЦБЕЗЗВУЧНЫЙ РЕЖИМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) {
                panel6.Visible = true;
                
                panel6.Width = 124;
                panel6.Height = 124;
                panel6.Location = new System.Drawing.Point((this.Width/2 - panel6.Width)+60, this.Height/2 - panel6.Height);
                panel6.BringToFront();
                timer4.Enabled = true;
                timer4.Interval = 1200;
            }
            
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        

        private void Internet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Соединение с интернетом не установлено!");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (panel == 2)
            {
                Panel1();
            }
            if (panel == 3)
            {
                sndPlayer1.Stop();
                label8.Visible = false;
                textBox7.Visible = false;
                Panel2();
            }
            if (panel == 4)
            {
                Panel1();
                Panel2();
            }
            if (panel == 5)
            {
                Panel1();
                Panel2();
                Panel4();
            }
            if (messageOpen) 
            {
                messageOpen = false;
                // тут добавить возвращение на главный экран 
                Panel1();
            }
            if (menuHour) 
            {
                menuHour = false;
                // тут добавить возвращение на главный экран 
                Panel1();
            }

        }
    }
}
