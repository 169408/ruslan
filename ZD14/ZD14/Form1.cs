using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            Wezel5 w0 = new Wezel5(0);
            Wezel5 w1 = new Wezel5(1);
            Wezel5 w2 = new Wezel5(2);
            Wezel5 w3 = new Wezel5(3);
            Wezel5 w4 = new Wezel5(4);
            Wezel5 w5 = new Wezel5(5);
            Wezel5 w6 = new Wezel5(6);
            Wezel5 w7 = new Wezel5(7);
            //Wezel5 w8 = new Wezel5(8);
            //Wezel5 w9 = new Wezel5(9);

            Krawedz k1 = new Krawedz(5, w0, w1);
            Krawedz k2 = new Krawedz(3, w0, w6);
            Krawedz k3 = new Krawedz(9, w0, w3);
            Krawedz k4 = new Krawedz(9, w1, w2);
            Krawedz k5 = new Krawedz(6, w1, w5);
            Krawedz k6 = new Krawedz(7, w1, w7);
            Krawedz k7 = new Krawedz(8, w1, w4);
            Krawedz k8 = new Krawedz(9, w2, w3);
            Krawedz k9 = new Krawedz(4, w2, w4);
            Krawedz k10 = new Krawedz(5, w2, w6);
            Krawedz k11 = new Krawedz(3, w2, w7);
            Krawedz k12 = new Krawedz(8, w3, w6);
            Krawedz k13 = new Krawedz(2, w4, w5);
            Krawedz k14 = new Krawedz(1, w4, w6);
            Krawedz k15 = new Krawedz(6, w5, w6);
            Krawedz k16 = new Krawedz(9, w6, w7);
            //Krawedz k17 = new Krawedz(2, w8, w9);
            //Krawedz k18 = new Krawedz(12, w2, w8);

            Graf graf = new Graf();

            graf.addWezel(w0);
            graf.addWezel(w1);
            graf.addWezel(w2);
            graf.addWezel(w3);
            graf.addWezel(w4);
            graf.addWezel(w5);
            graf.addWezel(w6);
            graf.addWezel(w7);
            //graf.addWezel(w8);
            //graf.addWezel(w9);

            graf.addKrawedz(k1);
            graf.addKrawedz(k2);
            graf.addKrawedz(k3);
            graf.addKrawedz(k4);
            graf.addKrawedz(k5);
            graf.addKrawedz(k6);
            graf.addKrawedz(k7);
            graf.addKrawedz(k8);
            graf.addKrawedz(k9);
            graf.addKrawedz(k10);
            graf.addKrawedz(k11);
            graf.addKrawedz(k12);
            graf.addKrawedz(k13);
            graf.addKrawedz(k14);
            graf.addKrawedz(k15);
            graf.addKrawedz(k16);
            //graf.addKrawedz(k17);
            //graf.addKrawedz(k18);

            graf.stworzNowyGraf();

        }
    }

    public class Wezel5
    {
        public int wartosc;
        public List<Krawedz> krawedzi = new List<Krawedz>();

        public Wezel5(int wartosc)
        {
            this.wartosc = wartosc;
        }
    }

    public class Krawedz
    {
        int waga;
        Wezel5 poczatek;
        Wezel5 koniec;

        public Krawedz(int waga, Wezel5 poczatek, Wezel5 koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;

            poczatek.krawedzi.Add(this);
            koniec.krawedzi.Add(this);
        }

        public int getWaga()
        {
            return waga;
        }

        public Wezel5 getPoczatek()
        {
            return poczatek;
        }

        public Wezel5 getKoniec()
        {
            return koniec;
        }
    }

    public class Graf
    {
        public List<Wezel5> wezly = new List<Wezel5>();
        public List<Krawedz> krawedzi = new List<Krawedz>();

        public Graf()
        {

        }

        public void addWezel(Wezel5 w)
        {
            wezly.Add(w);
        }

        public void addKrawedz(Krawedz krawedz)
        {
            krawedzi.Add(krawedz);
            /*Krawedz new_krawedz = new Krawedz(krawedz.getWaga(), krawedz.getKoniec(), krawedz.getPoczatek());
            krawedzi.Add(new_krawedz);*/
        }

        public void sort_krawedzi()
        {
            for (int i = 0; i < krawedzi.Count; i++)
            {
                for (int j = 0; j < krawedzi.Count - i - 1; j++)
                {
                    if (krawedzi[j].getWaga() > krawedzi[j + 1].getWaga())
                    {
                        Krawedz temp = krawedzi[j];
                        krawedzi[j] = krawedzi[j + 1];
                        krawedzi[j + 1] = temp;
                    }
                }
            }
        }

        public void wyswietl_krawedzi(Graf graf)
        {
            String napis = "";
            for (int i = 0; i < graf.krawedzi.Count; i++)
            {
                napis += graf.krawedzi[i].getWaga() + " ";
            }

            MessageBox.Show(napis);
        }

        public List<Wezel5> znajdzWszystkieDrogi(Wezel5 w)
        {
            List<Wezel5> werzcholki = new List<Wezel5>();
            werzcholki.Add(w);
            for(int i = 0; i < werzcholki.Count; i++)
            {
                if(werzcholki[i].krawedzi.Count != 0)
                {
                    for(int j = 0; j < werzcholki[i].krawedzi.Count; j++)
                    {
                        if(!werzcholki.Contains(werzcholki[i].krawedzi[j].getPoczatek()))
                        {
                            werzcholki.Add(werzcholki[i].krawedzi[j].getPoczatek());
                        }
                        if (!werzcholki.Contains(werzcholki[i].krawedzi[j].getKoniec()))
                        {
                            werzcholki.Add(werzcholki[i].krawedzi[j].getKoniec());
                        }
                    }
                }
            }
            /*String wyswietlenie = "";
            for(int i = 0; i < werzcholki.Count; i++)
            {
                wyswietlenie += werzcholki[i].wartosc + " ";
            }
            MessageBox.Show(wyswietlenie);*/
            return werzcholki;
        }

        public Graf stworzNowyGraf()
        {
            Graf new_graf = new Graf();
            this.sort_krawedzi();
            wyswietl_krawedzi(this);

            dodajDrogi(new_graf);
            return new_graf;
        }

        public void dodajDrogi(Graf graf)
        {
            List<Wezel5> noweWezly = this.wezly;
            for (int i = 0; i < noweWezly.Count; i++)
            {
                noweWezly[i].krawedzi = new List<Krawedz>();
            }
            /*List<Wezel5> zbiorW = new List<Wezel5>();
            for (int i = 0; i < graf.wezly.Count; i++)
            {
                if (graf.wezly[i].krawedzi.Count == 0)
                {
                    zbiorW.Add(graf.wezly[i]);
                }
            }*/
            for(int i = 0; i < this.krawedzi.Count; i++)
            {
                if(!graf.wezly.Contains(this.krawedzi[i].getPoczatek()) || !graf.wezly.Contains(this.krawedzi[i].getKoniec()))
                {
                    Wezel5 w1 = new Wezel5(-1);
                    Wezel5 w2 = new Wezel5(-1);
                    for(int j = 0; j < noweWezly.Count; j++)
                    {
                        if(noweWezly[j].wartosc == krawedzi[i].getPoczatek().wartosc)
                        {
                            w1 = noweWezly[j];
                        }
                        if (noweWezly[j].wartosc == krawedzi[i].getKoniec().wartosc)
                        {
                            w2 = noweWezly[j];
                        }
                    }
                    Krawedz k = new Krawedz(krawedzi[i].getWaga(), w1, w2);
                    if(graf.wezly.Count == 0)
                    {
                        graf.addWezel(w1);
                    }
                    for(int q = 0; q < graf.wezly.Count; q++)
                    {
                        if(graf.wezly[q].wartosc != w1.wartosc && q == graf.wezly.Count - 1)
                        {
                            graf.addWezel(w1);
                        }
                        if(graf.wezly[q].wartosc == w1.wartosc)
                        {
                            break;
                        }
                    }
                    for (int q = 0; q < graf.wezly.Count; q++)
                    {
                        if (graf.wezly[q].wartosc != w2.wartosc && q == graf.wezly.Count - 1)
                        {
                            graf.addWezel(w2);
                        }
                        if (graf.wezly[q].wartosc == w2.wartosc)
                        {
                            break;
                        }
                    }

                    graf.addKrawedz(k);
                }
            }
            String a1 = " ";
            for(int i = 0; i < graf.wezly.Count; i++)
            {
                a1 += graf.wezly[i].wartosc + " ";
            }
            MessageBox.Show(a1);
            for (int i = 0; i < this.krawedzi.Count; i++)
            {
                if (!graf.krawedzi.Contains(krawedzi[i]))
                {
                    bool czyDodac = true;
                    for(int j = 0; j < znajdzWszystkieDrogi(krawedzi[i].getPoczatek()).Count; j++)
                    {
                        if(znajdzWszystkieDrogi(krawedzi[i].getKoniec()).Contains(znajdzWszystkieDrogi(krawedzi[i].getPoczatek())[j]))
                        {
                            czyDodac = false;
                            break;
                        }
                    }
                    if(czyDodac)
                    {
                        for (int q = 0; q < graf.wezly.Count; q++)
                        {
                            if (graf.wezly[q].wartosc == krawedzi[i].getPoczatek().wartosc)
                            {
                                graf.wezly[q].krawedzi.Add(krawedzi[i]);
                            }
                            if (graf.wezly[q].wartosc == krawedzi[i].getKoniec().wartosc)
                            {
                                graf.wezly[q].krawedzi.Add(krawedzi[i]);
                            }
                        }
                        graf.addKrawedz(krawedzi[i]);
                    }
                }
            }
            wyswietl_krawedzi(graf);

            String a2 = " ";
            for (int i = 0; i < graf.wezly.Count; i++)
            {
                for(int j = 0; j < graf.wezly[i].krawedzi.Count; j++)
                {
                    a2 += graf.wezly[i].wartosc + " : " + graf.wezly[i].krawedzi[j].getWaga() + " ";
                }
            }
            MessageBox.Show(a2);
        }

        

       

    }
}
