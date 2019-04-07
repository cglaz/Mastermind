using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
	public partial class Form1 : Form
	{

		Button[,] pole;
		Button wybranyKolor;
		Color[] klucz;
		int rzadNumer;

		public Form1()
		{
			InitializeComponent();
			pole = new Button[10, 4];
			klucz = new Color[4];
			PokazPrzyciski();
			WylosujKlucz();
			wybranyKolor = button1;
			rzadNumer = 9;
		}

		private void WylosujKlucz()
		{
			Random random = new Random();
			for (int i = 0; i < 4; i++)
			{
				int los = random.Next(4);
				switch (los)
				{
					case 0:
						klucz[i] = button1.BackColor;
						break;
					case 1:
						klucz[i] = button2.BackColor;
						break;
					case 2:
						klucz[i] = button3.BackColor;
						break;
					case 3:
						klucz[i] = button4.BackColor;
						break;
				}
			}
		}

		private void PokazPrzyciski()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Button przycisk = new Button();
					przycisk.Top = i * 45 + 80;
					przycisk.Left = j * 45 + 10;
					przycisk.Size = new Size(40, 40);

					przycisk.Click += new EventHandler(this.Klik);

					Controls.Add(przycisk);
					pole[i, j] = przycisk;
				}
			}
		}

		private void Klik(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.BackColor = wybranyKolor.BackColor;
			btn.Text = "*";
		}


		private void button1_Click(object sender, EventArgs e)
		{
			wybranyKolor.Text = "";
			Button btn = sender as Button;
			wybranyKolor = btn;
			wybranyKolor.Text = "*";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			wybranyKolor.Text = "";
			Button btn = sender as Button;
			wybranyKolor = btn;
			wybranyKolor.Text = "*";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			wybranyKolor.Text = "";
			Button btn = sender as Button;
			wybranyKolor = btn;
			wybranyKolor.Text = "*";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			wybranyKolor.Text = "";
			Button btn = sender as Button;
			wybranyKolor = btn;
			wybranyKolor.Text = "*";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				if(pole[rzadNumer, i].Text != "*")
				{
					MessageBox.Show("pomaluj wszystkie przyciski w rzędzie nr " + (10 - rzadNumer).ToString());
					return;
				}
			}

			int czarne = 0;
			int biale = 0;

			for (int i = 0; i < 4; i++)
			{
				if (pole[rzadNumer, i].BackColor == klucz[i])
				{
					czarne += 1;
					continue;
				}
				for (int j = 0; j < 4; j++)
				{
					if (pole[rzadNumer, j].BackColor == klucz[i])
					{
						biale += 1;
						break;
					}
				}
			}

			Label wynik2 = new Label();
			wynik2.Top = rzadNumer * 45 + 90;
			wynik2.Left = 220;
			wynik2.Text = czarne.ToString();
			wynik2.BackColor = Color.BlueViolet;
			Controls.Add(wynik2);

			Label wynik1 = new Label();
			wynik1.Top = rzadNumer * 45 + 90;
			wynik1.Left = 200;
			wynik1.Text = biale.ToString();
			wynik1.ForeColor = Color.White;
			wynik1.BackColor = Color.BlueViolet;
			Controls.Add(wynik1);

			rzadNumer -= 1;

			if(czarne == 4)
			{
				button5.BackColor = klucz[0];
				button6.BackColor = klucz[1];
				button7.BackColor = klucz[2];
				button8.BackColor = klucz[3];
				button9.Enabled = false;
				MessageBox.Show("Wygrałeś!!!");
				return;
			}

			if (rzadNumer < 0)
			{
				button9.Enabled = false;
				MessageBox.Show("Przegrałeś!!!");
				return;
			}
		}
	}
}
