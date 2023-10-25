using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_4_isi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            tbInput.Text += "-4 10 3 2 0";
        }

        public int[] bublesort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] convert(string text)
        {
            var arr = text.Trim().Split(' ');
            int[] new_arr = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                new_arr[i] = num;
            }
            return new_arr;
        }

        private void btnbuble_Click(object sender, EventArgs e)
        {
            string text_input = tbInput.Text;
            int[] arr = convert(text_input);
            //int[] arr = { 1, 10, 3, 4, -2 };
            int[] sorted_tab = bublesort(arr);
            string wynik = "";
            for (int i = 0; i < sorted_tab.Length; i++)
            {
                wynik += sorted_tab[i] + " ";
                lbwynik.Text += " " + sorted_tab[i] + " ";
            }
        }
    }
}
