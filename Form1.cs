using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;



namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        struct pasazer
        {
            private int pozycja;
            private int cel;
            public void nowy(int poz, int c)
            {
                pozycja = poz;
                cel = c;
            }
        }

        pasazer osoba;
        ArrayList kolejka = new ArrayList();

        Deque

        Point pietro = new Point(660, 662);
        int iloscOsob = 0;
        int wagaOsoby = 70;
        int ciezarOsob = 0;
        int udzwig = 600;

        Graphics g;

        public int liczbaNaPietro(int a)
        {
            int y;
            y = 662 - a * 160;
            return y;
        }

        public iny pietroNaLiczbe(int a)
        {
            int y;
            y = (a - 22) / 160;
            return y;
        }


        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            timer1.Interval = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen BlackPen = new Pen(Color.Black);
            g.DrawRectangle(BlackPen, 440, 5, 350, 706);
            g.DrawLine(BlackPen, 0, 170, 440, 170);
            g.DrawLine(BlackPen, 0, 330, 440, 330);
            g.DrawLine(BlackPen, 0, 490, 440, 490);
            g.DrawLine(BlackPen, 0, 650, 440, 650);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = kolejka.Count.ToString();
            if (pictureBox2.Location.Y > pietro.Y - 120)
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);
            else
                if (pictureBox2.Location.Y < pietro.Y - 120)
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 1);
                else
                    if (pictureBox2.Location.Y == pietro.Y - 120)
                    {
                        if (kolejka.Count != 0)
                            {
                                //decyzja(kolejka, pietroNaLiczbe(pictureBox2.Location.Y+120));
                                pietro.Y = new Point(pictureBox2.Location.X, pietroNaLiczbe(kol));
                            }
                    }
                    else
                        if((pictureBox2.Location.Y + 120)%160 == 0)
        }

        static void decyzja(ArrayList kol, int y)
        {
            int maxDelta = 0;
            int terget;
            pasazer osob;
            foreach(object obj in kol)
            {
                osob = new pasazer.;
                if(Math.Abs(y-osoba.pozycja) > maxDelta)
                {
                    maxDelta = Math.Abs(y - osoba.pozycja);
                    terget = osoba.pozycja;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            osoba.nowy(3, 0);
            kolejka.Add(osoba);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            osoba.nowy(3, 1);
            kolejka.Add(osoba);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            osoba.nowy(3, 2);
            kolejka.Add(osoba);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            osoba.nowy(2, 0);
            kolejka.Add(osoba);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            osoba.nowy(2, 1);
            kolejka.Add(osoba);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            osoba.nowy(2, 3);
            kolejka.Add(osoba);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            osoba.nowy(1, 0);
            kolejka.Add(osoba);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            osoba.nowy(1, 2);
            kolejka.Add(osoba);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            osoba.nowy(1, 3);
            kolejka.Add(osoba);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            osoba.nowy(0, 1);
            kolejka.Add(osoba);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            osoba.nowy(0, 2);
            kolejka.Add(osoba);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            osoba.nowy(0, 3);
            kolejka.Add(osoba);
        }
    }
}





