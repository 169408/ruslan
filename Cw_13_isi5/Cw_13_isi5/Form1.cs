using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_13_isi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            String i_wiersz = "fabaabbaaa";
            String j_kolumna = "fbabab";
            int n = i_wiersz.Length;
            int m = j_kolumna.Length;
            int[,] tab = new int[m + 1, n + 1];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[0, i] = 0;
            }
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                tab[j, 0] = 0;
            }
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (i_wiersz[i - 1] == j_kolumna[j - 1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    if(i_wiersz[i - 1] != j_kolumna[j - 1])
                    {
                        tab[i, j] = maksymum(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }

            String wynnik = "";

            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    wynnik += tab[i, j] + " ";
                }
                wynnik += "\n";
            }
            MessageBox.Show(wynnik);
        }

        public int maksymum(int a, int b)
        {
            if(a >= b)
            {
                return a;
            }
            return b;
        }

        public void najdluzszyWspolnyPodciag(int n, int m)
        {
            
        }
    }
}
