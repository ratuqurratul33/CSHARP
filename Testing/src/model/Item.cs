using System;
class Item{ 
    public string Nama { get; set; }
    public string Deskripsi { get; set; }
    public int Harga { get; set; }

    public Item(string nama, string deskripsi, int harga)
    {
        this.Nama = nama;
        this.Deskripsi = deskripsi;
        this.Harga = harga;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Deskripsi: {Deskripsi}");
        Console.WriteLine($"Harga: {Harga} coins");
    }
}
