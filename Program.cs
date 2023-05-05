using System;


namespace KategorizeProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] categories = new string[6];
            categories[0] = "Teknoloji>Bilgisayar";
            categories[1] = "Teknoloji>Televizyon";
            categories[2] = "Teknoloji>Bilgisayar>Laptop";
            categories[3] = "Giyim>Pantalon";
            categories[4] = "Giyim>Ayakkabı";
            categories[5] = "Mutfak>Meyve";
            Console.WriteLine("Kategori ismi giriniz");
            string aranan = Console.ReadLine();
            int sonuc = 0;
            Console.WriteLine("Sonuçlar:");
            for (int i = 0; i < categories.Length; i++)
            {
                for (int j = 0; j < categories[i].Split('>').Length; j++)
                {
                    if (categories[i].Split('>')[j].ToLower() == aranan.ToLower())
                    {
                        if (categories[i].Split('>').Length > j + 1)
                        {
                            Console.Write(categories[i].Split('>')[j + 1].ToString() + " ");
                            sonuc++;
                            Console.WriteLine();
                        }
                    }
                }
            }
            Console.WriteLine("------------");
            if (sonuc == 0)
            {
                Console.WriteLine("Sonuç bulunamadı.");
            }
            else
            {
                Console.WriteLine(sonuc + " sonuç bulundu.");
            }
            Console.ReadKey();
        }
    }
}
