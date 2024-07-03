using System;
class Armor 
{
    private string idArmor;
    private string nama;
    private string deskripsi;
    private int healthBuff;
    private int harga; 

    public Armor(string idArmor, string nama, string deskripsi, int healthBuff, int harga) 
    {
        this.idArmor = idArmor;
        this.nama = nama;
        this.deskripsi = deskripsi;
        this.healthBuff = healthBuff;
        this.harga = harga;
    }

    public string IdArmor
    {
        get { return idArmor; }
        set { idArmor = value; }
    }

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string Deskripsi
    {
        get { return deskripsi; }
        set { deskripsi = value; }
    }

    public int HealthBuff
    {
        get { return healthBuff; }
        set { healthBuff = value; }
    }

    public int Harga 
    {
        get { return harga; }
        set { harga = value; }
    }

    public static explicit operator Armor(Item v)
    {
        throw new NotImplementedException();
    }
}

