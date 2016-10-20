using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] dizi;
        int xMax, yMax;

        private void btnCiz_Click(object sender, EventArgs e)
        {
            int deger1, deger2;
            bool deger1Kontrol = true, deger2Kontrol = true;
            foreach (char item in txtX.Text)
            {
                if (item < 47 || item > 58)
                {
                    deger1Kontrol = false;
                    break;
                }
            }

            foreach (char item in txtY.Text)
            {
                if (item < 47 || item > 58)
                {
                    deger2Kontrol = false;
                    break;
                }
            }
            if(deger1Kontrol && deger2Kontrol && txtX.Text != "" && txtY.Text != "")
            {
                deger1 = Convert.ToInt32(txtX.Text);
                deger2 = Convert.ToInt32(txtY.Text);
                dizi = new int[deger1, deger2];
                for (int i = 0; i < deger1; i++)
                {
                    for (int j = 0; j < deger2; j++)
                    {
                        dizi[i, j] = 0;
                    }
                }
                xMax = deger1;
                yMax = deger2;
                Ciz(deger1, deger2);
            }
            else MessageBox.Show("Lütfen sayı giriniz");

        }

        private void btnDuvar_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string[] bol = new string[2];
            bol = b.Tag.ToString().Split(',');
            b.Image = Properties.Resources.duvar;
            b.Text = "";
            dizi[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -1;
        }

        private async void btnBasla_Click(object sender, EventArgs e)
        {
            txtX.Enabled = false;
            txtY.Enabled = false;
            btnCiz.Enabled = false;
            pnlIcerik.Enabled = false;
            btnBasla.Enabled = false;
            await hareket();
        }

        private async Task<int> hareket()
        {
            int x = 1, y = 1;
            while (true)
            {
                if (x > xMax || y > yMax) break;
                int xBulunan = 0, yBulunan = y, min = 0, bulunan = 0;

                int ust = y - 1;
                int alt = y + 1;
                int sol = x - 1;
                int sag = x + 1;
                int[] siralama = new int[] { int.MaxValue, dizi[x, ust], dizi[x, alt], dizi[sol, y], dizi[sag, y] };
                for (int i = 1; i < siralama.Length; i++)
                {
                    if (siralama[i] < siralama[min] && siralama[i] != -1)
                    {
                        min = i;
                        if (i == 1)
                        {
                            xBulunan = x;
                            yBulunan = ust;
                        }
                        else if (i == 2)
                        {
                            xBulunan = x;
                            yBulunan = alt;
                        }
                        else if (i == 3)
                        {
                            xBulunan = sol;
                            yBulunan = y;
                        }
                        else if (i == 4)
                        {
                            xBulunan = sag;
                            yBulunan = y;
                        }
                        bulunan = i;
                    }
                }

                foreach (var i in pnlIcerik.Controls)
                {
                    if (i is Button)
                    {
                        string[] bol = new string[2];
                        bol = (i as Button).Tag.ToString().Split(',');
                        if (bol[0] == xBulunan.ToString() && bol[1] == yBulunan.ToString())
                        {
                            (i as Button).Image = Properties.Resources.mouse;
                            (i as Button).Text = "";
                            await Task.Delay(150);
                            dizi[xBulunan, yBulunan] += 1;
                            (i as Button).Text = dizi[xBulunan, yBulunan].ToString();
                            (i as Button).BackColor = Color.Transparent;
                            (i as Button).Image = null;
                            break;
                        }
                    }
                }
                x = xBulunan;
                y = yBulunan;

                await Task.Delay(150);
            }
            return 0;
        }

        private void Ciz(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0)
                        dizi[i, j] = -1;
                    else if (j == 0)
                        dizi[i, j] = -1;
                    else if (j == y - 1)
                        dizi[i, j] = -1;
                    else if (i == x - 1)
                        dizi[i, j] = -1;
                }
            }

            int xPoint = 0, yPoint = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button b = new Button();
                    if (dizi[i, j] == -1)
                    {
                        b.Image = Properties.Resources.duvar;
                    }
                    else
                    {
                        b.Text = "0";
                        b.BackColor = Color.Transparent;
                    }

                    b.FlatStyle = FlatStyle.Flat;
                    b.Top = yPoint;
                    b.Left = xPoint;
                    b.Height = 50;
                    b.Width = 50;
                    b.Tag = i + "," + j;
                    b.Click += btnDuvar_Click;
                    pnlIcerik.Controls.Add(b);

                    if (j == y - 1)
                    {
                        xPoint = 0;
                        yPoint += 50;
                    }
                    else
                    {
                        xPoint += 50;
                    }
                }
            }
        }
    }
}
