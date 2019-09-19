using System;

namespace QUIZ090920191
{
	class BangunDatar
    {
        public void Luas_Persegi()
        {
		Console.WriteLine("Menghitung Luas Persegi");
		Console.WriteLine("-----------------------");

        int sisi;
		Console.Write("Masukan Nilai sisi : ");
		sisi = Convert.ToInt32(Console.ReadLine());

		int luas = sisi * sisi;
		
		Console.WriteLine("Luas Persegi adalah = "+luas);
        }

        public void Luas_Segitiga()
        {
        int alas,tinggi,a,b,lu,luas;

		Console.WriteLine("Menghitung Luas Segitiga");
		Console.WriteLine("------------------------");

		Console.Write("Masukan alas : ");
		alas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukan tinggi : ");
		tinggi = Convert.ToInt32(Console.ReadLine());

		a = 1;
		b = 2;

	    lu = a * alas * tinggi;
		luas = lu / b;

		Console.WriteLine("Luas Segitiga adalah = "+luas);
         }

		 public void luas_lingkaran()
		 {
			 Console.WriteLine("Menghitung Luas Lingkaran");
			 Console.WriteLine("-------------------------");
                
			int e,f,g,ruas,luas;

			e = 22;
			f = 7;
			Console.WriteLine("masukan nilai ruas : ");
			ruas = Convert.ToInt32(Console.ReadLine());

			g = e * ruas * ruas;
			luas = g / f;

			Console.WriteLine("Luas Lingkaran Adalah "+luas);
		 }
    }
 }
