using System;
using System.Collections.Generic;

class KodeProduk {
    private static Dictionary<string, string> KodeProdukMap = new Dictionary<string, string>
    {
        {"Laptop", "E100" },
        {"SmartPhone", "E101" },
        {"Tablet", "E102" },
        {"Headset", "E103" },
        {"Keyboard", "E104" },
        {"Mouse", "E105" },
        {"Printer", "E106" },
        {"Monitor", "E107" },
        {"SmartWatch", "E108" },
        {"Kamera", "E109" }
    };

    public static string GetKodeProduk(string produk) 
    {
        return KodeProdukMap.TryGetValue(produk, out string KodeProduk) ? KodeProduk : "Kode produk tidak ditemukan";
    }
}

class Program {
    static void Main()
    {
        Console.WriteLine("Daftar kode Produk : ");
        Console.WriteLine("----------------------");

        foreach (var entry in new List<string>
        {
            "Laptop", "SmartPhone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"

        })
        {
            Console.WriteLine($"{entry}: {KodeProduk.GetKodeProduk(entry)}");
        }

        Console.WriteLine("\nMasukan Produk: ");
        string input = Console.ReadLine();
        Console.WriteLine($"Kode pos {input}: {KodeProduk.GetKodeProduk(input)}");
    }
}