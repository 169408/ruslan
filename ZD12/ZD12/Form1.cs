using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD12
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
            Krawedz krawedz11 = new Krawedz(3, e2, e1);
            Krawedz krawedz2 = new Krawedz(3, e1, e5);
            Krawedz krawedz12 = new Krawedz(3, e5, e1);
            Krawedz krawedz3 = new Krawedz(6, e1, e6);
            Krawedz krawedz13 = new Krawedz(6, e6, e1);
            Krawedz krawedz4 = new Krawedz(2, e5, e6);
            Krawedz krawedz14 = new Krawedz(2, e6, e5);
            Krawedz krawedz5 = new Krawedz(1, e2, e3);
            Krawedz krawedz15 = new Krawedz(1, e3, e2);
            Krawedz krawedz6 = new Krawedz(4, e2, e4);
            Krawedz krawedz16 = new Krawedz(4, e4, e2);
            Krawedz krawedz7 = new Krawedz(1, e6, e3);
            Krawedz krawedz17 = new Krawedz(1, e3, e6);
            Krawedz krawedz8 = new Krawedz(1, e6, e4);
            Krawedz krawedz18 = new Krawedz(1, e4, e6);
            Krawedz krawedz9 = new Krawedz(3, e3, e4);
            Krawedz krawedz19 = new Krawedz(3, e4, e3);

            graf1.addWezel(e1);
            graf1.addWezel(e2);
            graf1.addWezel(e3);
            graf1.addWezel(e4);
            graf1.addWezel(e5);
            graf1.addWezel(e6);

            graf1.addKrawedz(krawedz1);
            graf1.addKrawedz(krawedz11);
            graf1.addKrawedz(krawedz2);
            graf1.addKrawedz(krawedz12);
            graf1.addKrawedz(krawedz3);
            graf1.addKrawedz(krawedz13);
            graf1.addKrawedz(krawedz4);
            graf1.addKrawedz(krawedz14);
            graf1.addKrawedz(krawedz5);
            graf1.addKrawedz(krawedz15);
            graf1.addKrawedz(krawedz6);
            graf1.addKrawedz(krawedz16);
            graf1.addKrawedz(krawedz7);
            graf1.addKrawedz(krawedz17);
            graf1.addKrawedz(krawedz8);
            graf1.addKrawedz(krawedz18);
            graf1.addKrawedz(krawedz9);
            graf1.addKrawedz(krawedz19);

            graf1.startGame(e2);

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

        public string ToString()
        {
            return "Waga: " + this.waga + " Poczatek: " + this.poczatek.wartosc + " Koniec: " + this.koniec.wartosc;
        }
    }

    public class Graf
    {
        public List<Wezel4> wezly = new List<Wezel4>();
        public List<Krawedz> krawedzi = new List<Krawedz>();
        public List<element> wynniki = new List<element>();
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
            for (int i = 0; i < this.krawedzi.Count(); i++)
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

        public int znajdzDlugosc(Wezel4 poczatek, Wezel4 koniec)
        {
            //Krawedz new_krawedz = new Krawedz(poczatek, koniec);
            if (this.wezly.Contains(poczatek) && this.wezly.Contains(koniec))
            {
                for(int i = 0; i < krawedzi.Count; i++)
                {
                    if(krawedzi[i].poczatek == poczatek && krawedzi[i].koniec == koniec)
                    {
                        return krawedzi[i].waga;
                    }
                }
            }
            return 0;
        }
        /*public Wezel4 znajdzPoprzednika(Wezel4 e)
        {

        }*/

        public void startGame(Wezel4 poczatek)
        {
            List<Wezel4> zbiorQ = this.wezly.ToList();
            List<Wezel4> zbiorS = new List<Wezel4>();

            for(int k = 0; k < zbiorQ.Count; k++)
            {
                int dlugosc = int.MaxValue;
                Wezel4 poprzednik = poczatek;
                if (zbiorQ[k] == poczatek)
                {
                    dlugosc = 0;
                    poprzednik = null;
                }
                wynniki.Add(new element(zbiorQ[k], dlugosc, poprzednik));
            }
            while(zbiorQ.Count != 0)
            {
                Wezel4 jakis = wynniki[0].e;
                int jakas_dlugosc = int.MaxValue;
                for(int i = 0; i < wynniki.Count; i++)
                {
                    if(zbiorQ.Contains(wynniki[i].e) && wynniki[i].dlugosc < jakas_dlugosc)
                    {
                        jakas_dlugosc = wynniki[i].dlugosc;
                        jakis = wynniki[i].e;
                    }
                }
                oblicz(jakis);
                int index = 0;
                for (int i = 0; i < zbiorQ.Count; i++)
                {
                    if (zbiorQ[i] == jakis)
                    {
                        index = i;
                    }
                }
                zbiorS.Add(zbiorQ[index]);
                zbiorQ.RemoveAt(index);
            }
            for(int k = 0; k < zbiorS.Count; k++)
            {
                MessageBox.Show(zbiorS[k].wartosc.ToString());
            }
            for(int k = 0; k < wynniki.Count; k++)
            {
                MessageBox.Show(wynniki[k].ToString());
            }
        }

        public void oblicz(Wezel4 e)
        {
            List<Wezel4> sasiedzi = znajdzSasiadow(e);
            int dodatkowa_dlugosc = 0;
            for (int i = 0; i < wynniki.Count; i++)
            {
                if (wynniki[i].e == e)
                {
                    dodatkowa_dlugosc = wynniki[i].dlugosc;
                }
            }
            for (int k = 0; k < wynniki.Count; k++)
            {
                if(sasiedzi.Contains(wynniki[k].e))
                {
                    int czyMniejsza = 0;
                    /*if (wynniki[k].dlugosc == int.MaxValue)
                    {
                        czyMniejsza = 0;
                    }*/
                    czyMniejsza += znajdzDlugosc(e, wynniki[k].e) + dodatkowa_dlugosc;

                    if(czyMniejsza < wynniki[k].dlugosc)
                    {
                        wynniki[k].dlugosc = czyMniejsza;
                        wynniki[k].poprzednik = e;
                    }
                }
            }
            
        }



        /*public List<Wezel4> wspolna(List<Wezel4> zbiorQ, List<Wezel4> sasiedzi)
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
        }*/

        /*public void wynik(Wezel4 poczatek)
        {
            var zbiorQ = this.wezly.ToList();
            List<Wezel4> zbiorS = new List<Wezel4>();
            List<element> wynniki = new List<element>();
            for(int i = 0; i < zbiorQ.Count; i++)
            {
                wynniki.Add(new element(poczatek.wartosc, znajdzDroge(poczatek, zbiorQ[i]), znajdzPoprzednika(zbiorQ[i])));
            }
            przesukiwanieNajkrotszej(poczatek, zbiorQ, zbiorS);
        }*/

        /*public void przesukiwanieNajkrotszej(Wezel4 poczatek, List<Wezel4> zbiorQ, List<Wezel4> zbiorS)
        {
            List<Wezel4> sasiedzi = znajdzSasiadow(poczatek);
            List<Wezel4> czescWspolna = wspolna(zbiorQ, sasiedzi);
            
            for (int i = 0; i < czescWspolna.Count; i++)
            {
                 new element(czescWspolna[i].wartosc, znajdzDroge(poczatek, czescWspolna[i]), znajdzPoprzednika(czescWspolna[i]));
            }

        }*/



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
        }*/

        /*public int znajdzDroge(Wezel4 poczatek, Wezel4 koniec)
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
        public Wezel4 e;
        public int dlugosc;
        public Wezel4 poprzednik;

        public element(Wezel4 e, int dlugosc, Wezel4 poprzednik)
        {
            this.e = e;
            this.dlugosc = dlugosc;
            this.poprzednik = poprzednik;
        }

        public string ToString()
        {
            string pop = poprzednik != null ? poprzednik.wartosc.ToString() : "null";
            return e.wartosc + " dlugosc: " + dlugosc + " poprzednik: " + pop;
        }
    }
}
