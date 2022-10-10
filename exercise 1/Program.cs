using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Program
    {
        private int[] a = new int[56];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 56)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 56 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukan elemen pada array
            for (int rafi = 0; rafi < n; rafi++)
            {
                Console.Write("<" + (rafi + 1) + "> ");
                string s1 = Console.ReadLine();
                a[rafi] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int rf = 0; rf < n; rf++)
            {
                Console.WriteLine(a[rf]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int rafi = 1; rafi < n; rafi++) // for n - 1 passes
            {
                // Pada pass i,bandingkan n - i elemen pertama dengan elemen
                for (int rf = 0; rf < n - rafi; rf++)
                {
                    if (a[rf] < a[rf + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[rf];
                        a[rf] = a[rf + 1];
                        a[rf + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program mylist = new Program();

            // Pemanggilan funsi untuk menerima elemen array
            mylist.read();

            // Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();

            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
        }
    }
}
