using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PraUAS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("===== Welcome to LeleOS =====");
            Console.WriteLine("Type 'menu' to display all command\n\n");

        }

        protected override void Run()
        {
            //Initial
            string menu =
                "----------------------------------------\n" +
                "|-nama          -nim        -tgllahir  |\n" +
                "|-alamat        -nohp       -citacita  |\n" +
                "|-tanggal       -jam        -kalkulator|\n" +
                "|-helpkalkulator                       |\n" +
                "----------------------------------------\n"+
                "-shutdown      (Turn off computer)";
            string nama = "Ilham Ilyas Rasyid";
            string nim = "A11.2019.11744";
            string tgllahir = "11/9/2001";
            string alamat = "Jl.Taman Puri 2";
            string nohp = "085641560600";
            string citacita = "Entrepreneur";

            // Input Command
            Console.Write("Command : ");
            string command = Console.ReadLine();

            //Main()
            if (command == "menu")
            {
                Console.WriteLine(menu);
            }
            else if (command == "nama")
            {
                Console.Write("Nama : ");
                Console.WriteLine(nama);
            }
            else if (command == "nim")
            {
                Console.Write("NIM : ");
                Console.WriteLine(nim);
            }
            else if (command == "tgllahir")
            {
                Console.Write("Tanggal Lahir : ");
                Console.WriteLine(tgllahir);
            }
            else if (command == "alamat")
            {
                Console.Write("Alamat : ");
                Console.WriteLine(alamat);
            }
            else if (command == "nohp")
            {
                Console.Write("No HP : ");
                Console.WriteLine(nohp);
            }
            else if (command == "citacita")
            {
                Console.Write("Cita Cita : ");
                Console.WriteLine(citacita);
            }
            else if (command == "shutdown")
            {
                Cosmos.System.Power.Shutdown();
            }
            else if (command == "jam")
            {
                DateTime time = DateTime.Now;
                Console.WriteLine(time.ToLongTimeString());
            }
            else if (command == "tanggal")
            {
                DateTime time = DateTime.Now;
                Console.WriteLine(time.ToLongDateString());
            }
            else if (command == "helpkalkulator")
            {
                Console.WriteLine(
                    "Type = -tambah\n" +
                    "       -kurang");
            }
            else if (command == "kalkulator")
            {
                Console.Write("Type : ");
                string cmd = Console.ReadLine();
                if (cmd == "tambah")
                {
                    Console.Write("First Number : ");
                    string input = Console.ReadLine();
                    int a = Int32.Parse(input);
                    Console.Write("Second Number : ");
                    string input2 = Console.ReadLine();
                    int b = Int32.Parse(input2);
                    int c = a + b;
                    Console.WriteLine("Hasil : " + c);
                }
                else if (cmd == "kurang")
                {
                    Console.Write("First Number : ");
                    string input = Console.ReadLine();
                    int a = Int32.Parse(input);
                    Console.Write("Second Number : ");
                    string input2 = Console.ReadLine();
                    int b = Int32.Parse(input2);
                    int c = a - b;
                    Console.WriteLine("Hasil : " + c);
                }
                else
                {
                    Console.WriteLine("Command not available");
                    Console.WriteLine("'helpkalkulator' for kalkulator instructions");
                }
            }
            else
            {
                Console.WriteLine("Command not available");
                Console.WriteLine("'menu' to show available command");
            }

        }
    }
}
