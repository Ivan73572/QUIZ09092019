using System;

namespace QUIZ090920191
{
    class BangunRuang
    {
        public void Volume_Kubus()
        {
            Console.WriteLine("Menghitung Volume kubus");
		    Console.WriteLine("-----------------------");

            int sisi;
		    Console.Write("Masukan Nilai sisi : ");
		    sisi = Convert.ToInt32(Console.ReadLine());

		    int Volume = sisi * sisi * sisi;
		
		    Console.WriteLine("Volume Kubus adalah = "+Volume);
        }
            public void Volume_Balok()
        {
            int panjang,lebar,tinggi,volume;
		    Console.WriteLine("Menghitung Volume Balok");
		    Console.WriteLine("-----------------------");

		    Console.Write("Masukan panjang : ");
		    panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan lebar : ");
		    lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan tinggi : ");
		    tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

		    Console.WriteLine("Volume Balok adalah = "+volume);
        }
    }
}