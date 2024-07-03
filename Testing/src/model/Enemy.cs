using System;
class Enemy{ 
    private string idEnemy;
    private string nama;
    private int health;
    private int attackPower;

    public Enemy(string idEnemy, string nama, int health, int attackPower)
    {
        this.idEnemy = idEnemy;
        this.nama = nama;
        this.health = health;
        this.attackPower = attackPower;
    }

    public string IdEnemy
    {
        get { return idEnemy; }
        set { idEnemy = value; }
    }

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int AttackPower
    {
        get { return attackPower; }
        set { attackPower = value; }
    }
}

