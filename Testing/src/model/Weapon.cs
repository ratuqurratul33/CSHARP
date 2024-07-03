using System;
class Weapon 
{
    private string idWeapon;
    private string nama;
    private string deskripsi;
    private int attackPowerBuff;
    private int harga; 

    public Weapon(string idWeapon, string nama, string deskripsi, int attackPowerBuff, int harga) 
    {
        this.idWeapon = idWeapon;
        this.nama = nama;
        this.deskripsi = deskripsi;
        this.attackPowerBuff = attackPowerBuff;
        this.harga = harga; 
    }

    public string IdWeapon
    {
        get { return idWeapon; }
        set { idWeapon = value; }
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

    public int AttackPowerBuff
    {
        get { return attackPowerBuff; }
        set { attackPowerBuff = value; }
    }

    public int Harga
    {
        get { return harga; }
        set { harga = value; }
    }

    public static explicit operator Weapon(Item v)
    {
        throw new NotImplementedException();
    }
}