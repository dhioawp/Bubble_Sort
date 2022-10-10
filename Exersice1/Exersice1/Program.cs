using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1
{
    class program
    {
        private int[] a = new int[62];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.WriteLine(" Masukkan banyak elemen pada Array ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 62)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 62 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen Array ");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for (int DA = 0; DA < n; DA++)
            {
                Console.WriteLine(a[DA]);
            }
            Console.WriteLine("");
        }
        public void ExerciseSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int DA = 0; DA < n - i; DA++)
                {
                    if (a[DA] > a[DA + 1])
                    {
                        int temp;
                        temp = a[DA];
                        a[DA] = a[DA + 1];
                        a[DA + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            program mylist = new program();

            mylist.read();

            mylist.ExerciseSortArray();

            mylist.display();

            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}