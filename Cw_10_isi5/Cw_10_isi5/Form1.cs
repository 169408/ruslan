using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_10_isi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            Graf graf1 = new Graf();

            Wezel4 e1 = new Wezel4(0);
            Wezel4 e2 = new Wezel4(1);
            Wezel4 e3 = new Wezel4(2);
            Wezel4 e4 = new Wezel4(3);
            Wezel4 e5 = new Wezel4(4);
            Wezel4 e6 = new Wezel4(5);

            Krawedz krawedz1 = new Krawedz(3, e1, e2);
            Krawedz krawedz2 = new Krawedz(3, e1, e5);
            Krawedz krawedz3 = new Krawedz(6, e1, e6);
            Krawedz krawedz4 = new Krawedz(2, e5, e6);
            Krawedz krawedz5 = new Krawedz(1, e2, e3);
            Krawedz krawedz6 = new Krawedz(4, e2, e4);
            Krawedz krawedz7 = new Krawedz(1, e6, e3);
            Krawedz krawedz8 = new Krawedz(1, e6, e4);
            Krawedz krawedz9 = new Krawedz(3, e3, e4);

            graf1.addWezel(e1);
            graf1.addWezel(e2);
            graf1.addWezel(e3);
            graf1.addWezel(e4);
            graf1.addWezel(e5);
            graf1.addWezel(e6);

            graf1.addKrawedz(krawedz1);
            graf1.addKrawedz(krawedz2);
            graf1.addKrawedz(krawedz3);
            graf1.addKrawedz(krawedz4);
            graf1.addKrawedz(krawedz5);
            graf1.addKrawedz(krawedz6);
            graf1.addKrawedz(krawedz7);
            graf1.addKrawedz(krawedz8);
            graf1.addKrawedz(krawedz9);

            /*Wezel4 e1 = new Wezel4(1);
            Wezel4 e2 = new Wezel4(2);
            Wezel4 e3 = new Wezel4(3);
            Wezel4 e4 = new Wezel4(4);
            Wezel4 e5 = new Wezel4(5);
            Wezel4 e6 = new Wezel4(6);

            Krawedz krawedz1 = new Krawedz(2, e1, e2);
            Krawedz krawedz2 = new Krawedz(2, e1, e4);
            Krawedz krawedz3 = new Krawedz(3, e1, e3);
            Krawedz krawedz4 = new Krawedz(2, e4, e3);
            Krawedz krawedz5 = new Krawedz(1, e2, e5);
            Krawedz krawedz6 = new Krawedz(1, e3, e5);
            Krawedz krawedz7 = new Krawedz(2, e5, e6);
            Krawedz krawedz8 = new Krawedz(3, e3, e6);

            graf1.addWezel(e1);
            graf1.addWezel(e2);
            graf1.addWezel(e3);
            graf1.addWezel(e4);
            graf1.addWezel(e5);
            graf1.addWezel(e6);

            graf1.addKrawedz(krawedz1);
            graf1.addKrawedz(krawedz2);
            graf1.addKrawedz(krawedz3);
            graf1.addKrawedz(krawedz4);
            graf1.addKrawedz(krawedz5);
            graf1.addKrawedz(krawedz6);
            graf1.addKrawedz(krawedz7);
            graf1.addKrawedz(krawedz8);

            graf1.znajdzDroge(e1, e3);*/
            graf1.przesukiwanieNajkrotszej(e1);

        }
    }

    public class Wezel4
    {
        public int wartosc;
        public List<Krawedz> krawedzi = new List<Krawedz>();

        public Wezel4(int wartosc)
        {
            this.wartosc = wartosc;
        }
    }

    public class Krawedz
    {
        public int waga;
        public Wezel4 poczatek;
        public Wezel4 koniec;

        public Krawedz(int waga, Wezel4 poczatek, Wezel4 koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;

            poczatek.krawedzi.Add(this);
            koniec.krawedzi.Add(this);

        }

        override
        public string ToString()
        {
            return "Waga: " + this.waga + " Poczatek: " + this.poczatek.wartosc + " Koniec: " + this.koniec.wartosc;
        }
    }

    public class Graf
    {
        public List<Wezel4> wezly = new List<Wezel4>();
        public List<Krawedz> krawedzi = new List<Krawedz>();
        //public List<Krawedz> wynniki = new List<Krawedz>();

        public Graf()
        {

        }

        public void addWezel(Wezel4 e)
        {
            this.wezly.Add(e);
        }

        public void addKrawedz(Krawedz krawedz)
        {
            this.krawedzi.Add(krawedz);
        }

        public List<Wezel4> znajdzSasiadow(Wezel4 w)
        {
            List<Wezel4> sasiedzi = new List<Wezel4>();
            for(int i = 0; i < this.krawedzi.Count(); i++)
            {
                if (krawedzi[i].poczatek == w)
                {
                    sasiedzi.Add(krawedzi[i].koniec);
                }
                if (krawedzi[i].koniec == w)
                {
                    sasiedzi.Add(krawedzi[i].poczatek);
                }
            }
            return sasiedzi;
        }

        public List<Wezel4> wspolna(List<Wezel4> zbiorQ, List<Wezel4> sasiedzi) 
        {
            List<Wezel4> wspolny = new List<Wezel4>();
            for (int i = 0; i < sasiedzi.Count; i++)
            {
                if (zbiorQ.Contains(sasiedzi[i]))
                {
                    wspolny.Add(sasiedzi[i]);
                }
            }
            return wspolny;
        }

        public void przesukiwanieNajkrotszej(Wezel4 poczatek)
        {
            var zbiorQ = this.wezly.ToList();
            List<Wezel4> sasiedzi = znajdzSasiadow(poczatek);
            List<Wezel4> czescWspolna = wspolna(zbiorQ, sasiedzi);
            List<Wezel4> zbiorS = new List<Wezel4>();
            for(int i = 0; i < czescWspolna.Count; i++)
            {

            }
            /*for(int i = 0; i < sasiedzi.Count; i++)
            {
                MessageBox.Show(sasiedzi[i].wartosc.ToString());
            }*/

        }

        /*public List<Krawedz> addMozliwe(Wezel4 poczatek, Wezel4 koniec)
        {
            List<Krawedz> mozliwe = new List<Krawedz>();
            for (int i = 0; i < krawedzi.Count; i++)
            {
                if (krawedzi[i].koniec == koniec)
                {
                    mozliwe.Add(krawedzi[i]);
                }
            }
            return mozliwe;
        }

        public int przechodzenieNazad(Wezel4 poczatek, Krawedz krawedz)
        {
            if (krawedz.poczatek == poczatek)
            {
                wynniki.Add(krawedz);
                return 1;
            }
            else
            {
                List<Krawedz> mozliwe = addMozliwe(poczatek, krawedz.poczatek);
                for (int i = 0; i < mozliwe.Count; i++)
                {
                    if (przechodzenieNazad(poczatek, mozliwe[i]) == 1)
                    {
                        wynniki.Add(krawedz);
                    };
                }
                return 0;
            }
        }

        public int znajdzDroge(Wezel4 poczatek, Wezel4 koniec)
        {
            int dlugosc = -1;
            if (this.wezly.Contains(poczatek) && this.wezly.Contains(koniec))
            {
                dlugosc = 0;
                List<Krawedz> mozliwe = addMozliwe(poczatek, koniec);
                for (int j = 0; j < mozliwe.Count; j++)
                {
                    przechodzenieNazad(poczatek, mozliwe[j]);
                }
                for (int j = 0; j < wynniki.Count; j++)
                {
                    MessageBox.Show(wynniki[j].ToString());
                }
            }
            return dlugosc;
        }*/
    }

    public class element
    {
        int dlugosc;
        Wezel4 poprzednik;

        public element()
        {

        }
    }
}
