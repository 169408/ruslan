using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD8
{
    public partial class Form1 : Form
    {

        public string napis = "";
        public List<Wezel2> odwiedzone = new List<Wezel2>();
        public Form1()
        {
            InitializeComponent();
        }

        public void A(Wezel2 wezel)
        {
            odwiedzone.Add(wezel);
            napis += " " + wezel.wartosc.ToString();
            foreach (var sasiad in wezel.sasiedzi)
            {
                if (!odwiedzone.Contains(sasiad))
                {
                    A(sasiad);
                }

            }
        }

        public void wyswietlenieDzieci(Wezel3 w)
        {
            if (w == null)
            {
                return;
            }
            if (w.lewe_dz != null && w.prawe_dz != null)
            {
                MessageBox.Show(w.lewe_dz.wart.ToString() + " " + w.prawe_dz.wart.ToString());
            }
            else if (w.lewe_dz != null)
            {
                MessageBox.Show(w.lewe_dz.wart.ToString());
            }
            else if (w.prawe_dz != null)
            {
                MessageBox.Show(w.prawe_dz.wart.ToString());
            }
            else
            {
                MessageBox.Show("wtf");
            }
        }

        public void wyswietleniePoprzednika(Wezel3 w)
        {
            if (w == null)
            {
                return;
            }

            MessageBox.Show(w.wart.ToString());
        }

        public void A2(Wezel3 w)
        {

        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            /*Wezel2 wezel1 = new Wezel2(5);
            Wezel2 wezel2 = new Wezel2(2);
            Wezel2 wezel3 = new Wezel2(7);
            Wezel2 wezel4 = new Wezel2(3);
            Wezel2 wezel5 = new Wezel2(1);
            Wezel2 wezel6 = new Wezel2(4);
            wezel1.sasiedzi.Add(wezel2);
            wezel1.sasiedzi.Add(wezel5);
            wezel2.sasiedzi.Add(wezel3);
            wezel2.sasiedzi.Add(wezel4);
            wezel5.sasiedzi.Add(wezel6);
            odwiedzone.Clear();
            napis = "";
            A(wezel1);
            MessageBox.Show(napis);*/

            /*Wezel3 w1 = new Wezel3(1);
            Wezel3 w2 = new Wezel3(2);
            Wezel3 w3 = new Wezel3(3);
            Wezel3 w4 = new Wezel3(4);
            Wezel3 w5 = new Wezel3(5);
            Wezel3 w6 = new Wezel3(6);
            Wezel3 w7 = new Wezel3(7);
            Wezel3 w8 = new Wezel3(8);

            w1.lewe_dz = w2;
            w1.prawe_dz = w3;
            
            w2.lewe_dz = w4;
            w2.prawe_dz = w5;

            w3.lewe_dz = w6;
            w3.prawe_dz = w7;

            w5.lewe_dz = w8;*/

            Wezel3 w1 = new Wezel3(5);
            Wezel3 w2 = new Wezel3(4);
            Wezel3 w3 = new Wezel3(4);
            Wezel3 w4 = new Wezel3(8);
            Wezel3 w5 = new Wezel3(2);
            Wezel3 w6 = new Wezel3(3);
            Wezel3 w7 = new Wezel3(11);
            Wezel3 w8 = new Wezel3(10);

            DrzewoBinarne drzewo = new DrzewoBinarne(w1);
            drzewo.Add(w2);
            drzewo.Add(w3);
            drzewo.Add(w4);
            drzewo.Add(w5);
            drzewo.Add(w6);
            drzewo.Add(w7);
            drzewo.Add(w8);

            //wyswietlenieDzieci(w2);
            //wyswietlenieDzieci(drzewo.znajdz(4));
            //wyswietleniePoprzednika(drzewo.znajdz_poprzednika(w6));
            //MessageBox.Show(drzewo.znajdz_najmniejsze().wart.ToString());
            //MessageBox.Show(drzewo.znajdz_najwieksze().wart.ToString());
            MessageBox.Show(drzewo.nastepnik(w6).wart.ToString());
            MessageBox.Show(drzewo.nastepnik(w7).wart.ToString());
            MessageBox.Show(drzewo.nastepnik(w1).wart.ToString());

        }
    }

    public class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }

    public class Wezel2
    {
        public int wartosc;
        public List<Wezel2> sasiedzi = new List<Wezel2>();

        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
        }

        public void Add(Wezel2 s)
        {
            if (this == s)
            {
                return;
            }

            if (!this.sasiedzi.Contains(s))
            {
                this.sasiedzi.Add(s);
            }
            if (!s.sasiedzi.Contains(this))
            {
                s.sasiedzi.Add(this);
            }
        }
    }

    public class Wezel3
    {
        public int wart;
        public Wezel3 rodzic;
        public Wezel3 prawe_dz;
        public Wezel3 lewe_dz;

        public Wezel3(int wart)
        {
            this.wart = wart;
        }
        public void Add(Wezel3 w)
        {
            w.rodzic = this;
            if (w.wart < this.wart)
            {
                this.lewe_dz = w;
            }
            else if (w.wart >= this.wart)
            {
                this.prawe_dz = w;
            }
        }

        /*public Wezel3 znajdz_rodzica()
        {
            Wezel3 rodzic = 
        }*/

    }

    public class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int liczba_wezlow = 0;

        public DrzewoBinarne(Wezel3 korzen)
        {
            this.korzen = korzen;
        }

        public void Add(Wezel3 w)
        {
            Wezel3 rodzic = this.znajdzRodzica(w);
            rodzic.Add(w);
            //w.rodzic = rodzic;
        }

        public Wezel3 znajdzRodzica(Wezel3 w)
        {
            Wezel3 ko = this.korzen;
            while (true)
            {
                if (w.wart < ko.wart)
                {
                    if (ko.lewe_dz != null)
                    {
                        ko = ko.lewe_dz;
                    }
                    else
                    {
                        return ko;
                    }
                }
                else if (w.wart >= ko.wart)
                {
                    if (ko.prawe_dz != null)
                    {
                        ko = ko.prawe_dz;
                    }
                    else
                    {
                        return ko;
                    }
                }
            }
        }

        public Wezel3 znajdz(int liczba)
        {
            Wezel3 ko = this.korzen;
            while (true)
            {
                if (liczba != ko.wart)
                {
                    if (liczba < ko.wart)
                    {
                        if (ko.lewe_dz != null)
                        {
                            ko = ko.lewe_dz;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else if (liczba >= ko.wart)
                    {
                        if (ko.prawe_dz != null)
                        {
                            ko = ko.prawe_dz;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return ko;
                }
            }
        }

        public Wezel3 znajdz_poprzednika(Wezel3 w)
        {
            Wezel3 temp_rodzic = w.rodzic;
            if(temp_rodzic == null)
            {
                return null;
            }
            if (temp_rodzic.prawe_dz == w)
            {
                return temp_rodzic;
            } else
            {
                return znajdz_poprzednika(temp_rodzic);
            }
        }

        public Wezel3 znajdz_najmniejsze()
        {
            Wezel3 najmn = korzen;
            while(najmn.lewe_dz != null)
            {
                najmn = najmn.lewe_dz;
            }
            return najmn;
        }

        public Wezel3 znajdz_najwieksze()
        {
            Wezel3 najw = korzen;
            while (najw.prawe_dz != null)
            {
                najw = najw.prawe_dz;
            }
            return najw;
        }

        public Wezel3 nastepnik(Wezel3 w)
        {
            if(w == null)
            {
                return null;
            }
            if(w.prawe_dz != null)
            {
                Wezel3 nast = w.prawe_dz;
                while(nast.lewe_dz != null)
                {
                    nast = nast.lewe_dz;
                }
                return nast;
            } else if(w.rodzic != null)
            {
                Wezel3 nast = w.rodzic;
                if(nast.lewe_dz == w)
                {
                    return nast;
                }
                while(nast.wart <= w.wart)
                {
                    if(nast.rodzic != null)
                    {
                        nast = nast.rodzic;
                    } else
                    {
                        return w;
                    }
                }
                return nast;
            }

            return w;
        }

    }

}
