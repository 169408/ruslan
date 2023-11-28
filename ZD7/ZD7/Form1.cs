using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD7
{
    public partial class Form1 : Form
    {

        public string napis = "";
        public List<Wezel2> odwiedzone = new List<Wezel2>();
        public List<Wezel3> odwiedzone_wszerz = new List<Wezel3>();
        public List<Wezel3> nastepne = new List<Wezel3>();
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

        public void A2(DrzewoBinarne w)
        {
            odwiedzone_wszerz.Add(w.korzen);
            napis += " " + w.korzen.ToString();
            for (int i = 0; i < w.liczba_wezlow; i++)
            {
                if (w.korzen.lewe_dz != null && odwiedzone_wszerz.Contains(w.korzen.lewe_dz))
                {
                    w.korzen = w.korzen.lewe_dz;
                    A2(w);
                }
                if(w.korzen.prawe_dz != null && odwiedzone_wszerz.Contains(w.korzen.prawe_dz))
                {
                    w.korzen = w.korzen.prawe_dz;
                    A2(w);
                }

            }
        }

        public void A3(Wezel3 w)
        {
            bool temp = false;
            int counter = 1;
            if (!odwiedzone_wszerz.Contains(w))
            {
                odwiedzone_wszerz.Add(w);
                napis += " " + w.wart.ToString();
            }
            if (nastepne.Count != 0)
            {
                //MessageBox.Show(nastepne[0].wart.ToString());
                odwiedzone_wszerz.Add(nastepne[0]);
                nastepne.RemoveAt(0);
            }
            if (w.lewe_dz != null && !odwiedzone_wszerz.Contains(w.lewe_dz))
            {
                nastepne.Add(w.lewe_dz);
            }
            if (w.prawe_dz != null && !odwiedzone_wszerz.Contains(w.prawe_dz))
            {
                nastepne.Add(w.prawe_dz);
            }
            if(nastepne.Count != 0)
            {
                A3(nastepne[0]);
            }
        }

        public void A4(Wezel3 w)
        {
            bool temp = false;
            int counter = 1;
            if (!odwiedzone_wszerz.Contains(w))
            {
                odwiedzone_wszerz.Add(w);
                napis += " " + w.wart.ToString();
            }
            if (w.lewe_dz != null && !odwiedzone_wszerz.Contains(w.lewe_dz))
            {
                odwiedzone_wszerz.Add(w.lewe_dz);
                napis += " " + w.lewe_dz.wart.ToString();
                if (w.prawe_dz != null && !odwiedzone_wszerz.Contains(w.prawe_dz))
                {
                    temp = true;
                    odwiedzone_wszerz.Add(w.prawe_dz);
                    napis += " " + w.prawe_dz.wart.ToString();
                }
                if(counter % 2 == 0)
                {
                    if (temp) A4(w.prawe_dz);
                    A4(w.lewe_dz);
                } else if(counter % 2 != 0)
                {
                    A4(w.lewe_dz);
                    if (temp) A4(w.prawe_dz);
                }
                counter++;
            } else if (w.prawe_dz != null && !odwiedzone_wszerz.Contains(w.prawe_dz))
            {
                temp = true;
                odwiedzone_wszerz.Add(w.prawe_dz);
                napis += " " + w.prawe_dz.wart.ToString();
            }
        }

        public void B(Wezel3 w)
        {
            if(w.lewe_dz != null && w.prawe_dz != null){
                MessageBox.Show(w.lewe_dz.wart.ToString() + w.prawe_dz.wart.ToString());
            }
            if (w.lewe_dz != null && w.prawe_dz == null){
                MessageBox.Show(w.lewe_dz.wart.ToString());
            }
            if (w.lewe_dz == null && w.prawe_dz != null){
                MessageBox.Show(w.prawe_dz.wart.ToString());
            }
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

            Wezel3 w1 = new Wezel3(8);
            Wezel3 w2 = new Wezel3(5);
            Wezel3 w3 = new Wezel3(9);
            Wezel3 w4 = new Wezel3(4);
            Wezel3 w5 = new Wezel3(6);
            Wezel3 w6 = new Wezel3(8);
            Wezel3 w7 = new Wezel3(11);
            Wezel3 w8 = new Wezel3(5);

            /*w1.lewe_dz = w2;
            w1.prawe_dz = w3;

            w2.lewe_dz = w4;
            w2.prawe_dz = w5;

            w3.lewe_dz = w6;
            w3.prawe_dz = w7;

            w5.lewe_dz = w8;*/

            DrzewoBinarne drzewo = new DrzewoBinarne();
            drzewo.Add(w1);
            drzewo.Add(w2);
            drzewo.Add(w3);
            //B(w1);
            drzewo.Add(w4);
            drzewo.Add(w5);
            drzewo.Add(w6);
            drzewo.Add(w7);
            drzewo.Add(w8);
            //B(w5);

            napis = "";
            odwiedzone_wszerz.Clear();
            A3(w1);
            MessageBox.Show(napis);
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
    }

    public class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int liczba_wezlow = 0;
        public Wezel3 temp;

        public void Add(Wezel3 w)
        {
            if(liczba_wezlow == 0)
            {
                korzen = w;
                liczba_wezlow++;
                return;
            }
            /*if(temp != null)
            {
                MessageBox.Show(temp.wart.ToString());
            }*/
            if (w.wart < korzen.wart)
            {
                if (temp != null && w.wart < temp.wart)
                {
                    if (temp.lewe_dz != null)
                    {
                        temp = temp.lewe_dz;
                        Add(w);
                    } else
                    {
                        temp.lewe_dz = w;
                        liczba_wezlow++;
                        temp = null;
                    }
                   
                } else if (temp != null && w.wart >= temp.wart) {
                    if (temp.prawe_dz != null)
                    {
                        temp = temp.prawe_dz;
                        Add(w);
                    } else
                    {
                        temp.prawe_dz = w;
                        liczba_wezlow++;
                        temp = null;
                    }
                    
                } else
                {
                    if (korzen.lewe_dz != null)
                    {
                        temp = korzen.lewe_dz;
                        Add(w);
                    } else
                    {
                        korzen.lewe_dz = w;
                        liczba_wezlow++;
                    }
                   

                } 
            }
            if (w.wart >= korzen.wart)
            {
                if(temp != null && w.wart < temp.wart)
                {
                    if (temp.lewe_dz != null)
                    {
                        temp = temp.lewe_dz;
                        Add(w);
                    } else
                    {
                        temp.lewe_dz = w;
                        liczba_wezlow++;
                        temp = null;
                    }
                    
                } else if(temp != null && w.wart >= temp.wart)
                {
                    if (temp.prawe_dz != null)
                    {
                        temp = temp.prawe_dz;
                        Add(w);
                    } else
                    {
                        temp.prawe_dz = w;
                        liczba_wezlow++;
                        temp = null;
                    }
                    
                }
                else
                {
                    if (korzen.prawe_dz != null)
                    {
                        temp = korzen.prawe_dz;
                        Add(w);
                    } else
                    {
                        korzen.prawe_dz = w;
                        liczba_wezlow++;
                    }
                   
                }
            }
        }

        public void toString(Wezel3 korzen)
        {
            this.korzen = korzen;
            
        }
    }
}
