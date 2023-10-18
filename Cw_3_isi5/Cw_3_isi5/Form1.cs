using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_3_isi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] sort_buble(int[] tablica)
        {
            for(int i = 0; i < tablica.Length; i++)
            {
                for(int j = 0; j < tablica.Length - i - 1; j++)
                {
                    if (tablica[j] > tablica[j+1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }
            return tablica;
        }

        private int[] inny_sort(int[] tablica)
        {
            bool czyzamiana = false;
            do
            {
                czyzamiana = false;
                for (int i = 0; i < tablica.Length - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        czyzamiana = true;
                        int temp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = temp;
                    }
                }
            } while (czyzamiana);
            return tablica;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 4 7 2 1
            // 4 2 7 1
            // 4 2 1 7

            // 2 4 1 7
            // 2 1 4 7

            // 1 2 4 7
            int[] tab = { 1, 4, 2, 7, 0, 3 };
            for (int i = 0; i < tab.Length; i++)
            {
                lbl_tab.Text += " " + tab[i] + " ";
                Console.Write(tab[i] + " ");
            }
            int[] sorted_tab = inny_sort(tab);
            string wynik = "";
            for(int i = 0; i < sorted_tab.Length; i++)
            {
                wynik += sorted_tab[i] + " ";
                lable_wynik.Text += " " + sorted_tab[i] + " ";
                Console.Write(sorted_tab[i] + " ");
            }
            MessageBox.Show(wynik);
            Console.WriteLine("\n Koniec ");
        }
    }
}
