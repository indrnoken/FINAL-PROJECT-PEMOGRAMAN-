using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_KEL._2
{
   public class Akun
    {
        private int acco; // private : hanya dapa di akses oleh metode-metode dalam kelas itu sendiri

        public int useracco // barii 13-17 mendefinisikan dari method acco
        {
            get { return acco; }// propertis
            set { acco = value; }
        }

        protected string name, negara; // protected : variable instan dapat di akses pada kelas sendiri dan subkelasnya
        internal int deposit; //internal : pada dasarnya sama dengan public specifer 
        protected internal char tipe;
        //bari ke 11 dan 19-21 adalah definisi dari class yang akan di buat
        

        private void BuatAkun() // tampilan pada option nomor 1//method void
        {
            Console.Write("\nMasukkan nomor akun :");
            useracco = int.Parse(Console.ReadLine());
            Console.Write("\nMasukkan nama pengguna akun : ");
            name = Console.ReadLine();
            Console.Write("\nMasukkan tipe akun (C/S) : ");
            tipe = char.Parse(Console.ReadLine()); // di gunakan unutuk mengkonversi nilai string yang di tentukan ke karakter unicode yang setara
            Console.Write("\nMasukkan asal negara :");
            negara = Console.ReadLine();
            Console.Write("\nMASUKKAN NOMINAL (>=500 for saving and >=1000 for current) :");
            deposit = int.Parse(Console.ReadLine());
            Console.Write("\n\nAccount Created...");

        }
        public void Buat_Akun() //enkapsulation
        {
            BuatAkun();
        }

        protected void show_akun() // tampilan setelah kita memilih option 5 , tertera data dari pemilik akun
        {
            Console.Write("\nNomor Akun : {0}", useracco);
            Console.Write("Nama pemilik akun : {0}", name);
            Console.Write("Negara Asal : {0}", negara);
            Console.Write("Tipe Akun : {0}", tipe);
            Console.Write("Jumlah Saldo : {0}", deposit);

        }
        public void ShowAkun()// class method show akun bari ke 54-57
        {
            show_akun();
        }

        internal void modifyaccount() // method void
        {
            Console.Write("\nNo Akun. : {0}", useracco);
            Console.Write("Modifikasi Nama Pemilik Akun :");
            name = Console.ReadLine();
            Console.Write("Modifikasi Asal Negara : ");
            negara = Console.ReadLine();
;            Console.Write("Modifikasi Tipe Akun : ");
            tipe = char.Parse(Console.ReadLine());
            Console.Write("Modifikasi Jumlah Saldo: ");
            deposit = int.Parse(Console.ReadLine());

        }

        public void modify_akun()//class method modfyakun
        {
            modifyaccount();
        }
        public void accountdep()
        {
            int x;
            Console.Write("masukkan jumlah deposit :");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }

        public void accountdraw()
        {
            int x;
            Console.Write("masukkan jumlah penarikan :");
            x = int.Parse(Console.ReadLine());
            deposit -= x;
        }

        public void accountreport()
        {
            Console.Write("acco :: {0} \nName :: {1} \nTipe :: {2} \nNegara :: {3} \nDeposit :: {4}", acco, name, tipe, negara,deposit);
        }

        public int retAcco() // class method dari acco
        {
            return acco;
        }

        public int retDeposit()// class method dari deposit
        {
            return deposit;
        }

        public char retTipe()// class method dari tipe
        {
            return tipe;
        }


    }
}
