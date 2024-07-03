using System;

class Player 
{
    private string idPlayer;
    private string nama;
    private int health;
    private int attackPower;
    private Armor armor;
    private Weapon weapon;
    private Inventory inventory;
    private int points;

    public Player(string idPlayer, string nama, int health, int attackPower, int poin)
    {
        this.idPlayer = idPlayer;
        this.nama = nama;
        this.health = health;
        this.attackPower = attackPower;
        this.inventory = new Inventory();
        this.points = poin;
    }

    public string IdPlayer
    {
        get { return idPlayer; }
        set { idPlayer = value; }
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

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public Armor Armor
    {
        get { return armor; }
        set { armor = value; }
    }

    public Weapon Weapon
    {
        get { return weapon; }
        set { weapon = value; }
    }

    public void AddArmor(Armor newArmor)
    {
        inventory.AddArmor(newArmor);
    }

    public void AddWeapon(Weapon newWeapon)
    {
        inventory.AddWeapon(newWeapon);
    }

    public void RemoveArmor(Armor armorToRemove)
    {
        inventory.RemoveArmor(armorToRemove);
    }

    public void RemoveWeapon(Weapon weaponToRemove)
    {
        inventory.RemoveWeapon(weaponToRemove);
    }

    public int DisplayInventory()
    {
        inventory.DisplayInventory();
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Pakai item");
        Console.WriteLine("2. Keluar");
        Console.Write("Pilihan : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        return pilihan;
    }

    public void AddPoints(int additionalPoints)
    {
        points += additionalPoints;
    }

    public void SubtractPoints(int pointsToSubtract)
    {
        points -= pointsToSubtract;
    }

   public void EquipArmor(int index)
    {
        Armor newArmor = inventory.GetArmor(index - 1);
        if (newArmor != null)
        {
            if (armor != null)
            {  // ini kalo misal pas armonya ganti otomatis kan buff yang sebelumnya tuh gaada, diganti sama buff armor yang baru, jadi gabisa pake 2 atau lebih armor sekaligus
                health -= armor.HealthBuff;
                Console.WriteLine($"Unequipped {armor.Nama}");
            } // nah ini buat pake armor yang baru
            armor = newArmor;
            health += armor.HealthBuff;
            Console.WriteLine($"Equipped {armor.Nama}");
        }
        else
        {
            Console.WriteLine("Invalid armor index.");
        }
    }

    public void EquipWeapon(int index) //ini sama aja teknis nya sama method yang atas
    {
        Weapon newWeapon = inventory.GetWeapon(index - 1);
        if (newWeapon != null)
        {
            if (weapon != null)
            {
                attackPower -= weapon.AttackPowerBuff;
                Console.WriteLine($"Unequipped {weapon.Nama}");
            }
            weapon = newWeapon;
            attackPower += weapon.AttackPowerBuff;
            Console.WriteLine($"Equipped {weapon.Nama}");
        }
        else
        {
            Console.WriteLine("Invalid weapon index.");
        }
    }
}
