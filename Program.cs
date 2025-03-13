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
/*
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
}*/

class FanLaptop {
    public enum State {Quiet, Balanced, Performance, Turbo};
    public enum Trigger {ModeUp, ModeDown, Turboshortcut};
    private State currentState;
    class changeMode
    {
        public State stateAwal;
        public Trigger trigger;
        public State stateAkhir;
        public changeMode(State stateAwal, Trigger trigger, State stateAkhir)
        {
            this.stateAwal = stateAwal;
            this.trigger = trigger;
            this.stateAkhir = stateAkhir;
        }
    }
        private changeMode[] changes =
        {
            new changeMode(State.Quiet, Trigger.ModeUp, State.Balanced),
            new changeMode(State.Balanced, Trigger.ModeUp, State.Performance),
            new changeMode(State.Performance, Trigger.ModeUp, State.Turbo),
            new changeMode(State.Turbo, Trigger.ModeDown, State.Performance),
            new changeMode(State.Performance, Trigger.ModeDown, State.Balanced),
            new changeMode(State.Balanced, Trigger.ModeDown, State.Quiet),
            new changeMode(State.Quiet, Trigger.Turboshortcut, State.Turbo),
            new changeMode(State.Balanced, Trigger.Turboshortcut, State.Turbo)
        };
    public String GetStaticState(State stateAwal, Trigger trigger)
    {
        for (int i = 0; i < changes.Length; i++) {
            if (stateAwal == changes[i].stateAwal && changes[i].trigger == trigger) {
                return "Fan" + stateAwal+ " Berubah menjadi" + changes[i];
            } 
        }
        return "Fan tetap" + stateAwal;
    }
}

class Program { 
    
}
