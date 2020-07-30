using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_KEL._2
{
    class Program
    {
        static void Main(string[] args)
        {
              int num, n; // variable

            
            Akun bank = new Akun(); // membuat objek baru dari kelas akun
                                    
            Console.ForegroundColor = ConsoleColor.DarkYellow; // syntax untun mengubah warna text pada program
            Console.Clear(); // method untuk menghapus konsol sebelum menjalan loop
            System.Console.WriteLine("\n\n\n\t\t//Sistem manajemen bank");
            Console.Write("\n\n\n\t\t//Final project pemograman");
            

            do // menggunakan perulangan do - while 
            {
                Console.Write("\n\n\n\tMain Menu");
                Console.Write("\n\t01. Buat Akun Baru");
                Console.Write("\n\t02. Deposit");
                Console.Write("\n\t03. Penarikan");
                Console.Write("\n\t04. Total deposit");
                Console.Write("\n\t05. Akun yang ada di list");
                Console.Write("\n\t06. Modifikasi akun");
                Console.Write("\n\t07. EXIT");
                Console.Write("\n\tMasukkan pilihan(1-7)");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:  // case 1 - case 7 untuk memilih menu yang di inginkan
                        {
                            Console.Clear(); //// method untuk menghapus konsol sebelum menjalan loop
                            bank.Buat_Akun();
                            
                            break; // statment pernyataan  mengakhiri pada kasus loop/ untuk melompat keluar dari pilihan
                        }
                    case 2:
                        {
                            Console.Clear();
                            
                            bank.accountdep();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            
                            bank.accountdraw();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            
                            bank.accountreport();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            
                            bank.accountreport();
                            break;

                        }
                    case 6:
                        {
                            Console.Clear();
                            
                            Console.Write("\n\n\tMasukkan nomor akun : ");
                            num = int.Parse(Console.ReadLine());
                            bank.modifyaccount();
                            break;
                        } System.Console.ReadKey();
                }




            } while (n != 7);///end of while loop
        }
    }
}
