using System;
using System.Collections.Generic;

class Store 
{
    private List<Weapon> weapons;
    private List<Armor> armors;

    public Store()
    {
        weapons = new List<Weapon>();
        armors = new List<Armor>();
        InitializeStoreItems();
    }

    private void InitializeStoreItems() 
    {
        // enambahkan 5 weapons
        weapons.Add(new Weapon("W001", "Sword of Dawn", "A shining sword with immense power.", 20, 100));
        weapons.Add(new Weapon("W002", "Axe of Fury", "An axe that increases attack speed.", 25, 150));
        weapons.Add(new Weapon("W003", "Bow of Eternity", "A bow with never-ending arrows.", 15, 80));
        weapons.Add(new Weapon("W004", "Dagger of Shadows", "A dagger that enhances stealth.", 10, 50));
        weapons.Add(new Weapon("W005", "Mace of Destruction", "A mace that causes massive damage.", 30, 200));

        // menambahkan 5 armors
        armors.Add(new Armor("A001", "Leather Armor", "Basic armor made of leather.", 10, 50));
        armors.Add(new Armor("A002", "Chainmail Armor", "Armor made of interlocking metal rings.", 20, 100));
        armors.Add(new Armor("A003", "Plate Armor", "Heavy armor made of metal plates.", 30, 150));
        armors.Add(new Armor("A004", "Robe of the Magi", "A robe that enhances magical abilities.", 5, 70));
        armors.Add(new Armor("A005", "Helmet of Valor", "A helmet that provides extra protection.", 15, 80));
    }

    public int DisplayStoreItems() 
    {
        Console.WriteLine("\n=== Store ===");
        Console.WriteLine("Weapons:");
        for (int i = 0; i < weapons.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weapons[i].Nama} - Attack Power: {weapons[i].AttackPowerBuff}, Price: {weapons[i].Harga} - {weapons[i].Deskripsi}");
        }

        Console.WriteLine("\nArmors:");
        for (int i = 0; i < armors.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {armors[i].Nama} - Health Buff: {armors[i].HealthBuff}, Price: {armors[i].Harga} - {armors[i].Deskripsi}");
        }

        Console.WriteLine("\nMenu :");
        Console.WriteLine("1. Beli Weapons");
        Console.WriteLine("2. Beli Armors");
        Console.WriteLine("3. Keluar");
        Console.Write("Masukkan pilihan anda : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        return pilihan;
    }

    public void BuyWeapon(Player player, int index) 
    {
        if (index >= 1 && index <= weapons.Count) 
        {
            Weapon weapon = weapons[index - 1];
            if (player.Points >= weapon.Harga)
            {
                player.AddWeapon(weapon);
                player.SubtractPoints(weapon.Harga);
                Console.WriteLine($"{weapon.Nama} berhasil ditambahkan kedalam inventory.");
            }
            else
            {
                Console.WriteLine("Poin anda tidak cukup.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid.");
        }
    }

    public void BuyArmor(Player player, int index) 
    {
        if (index >= 1 && index <= armors.Count)
        {
            Armor armor = armors[index - 1];
            if (player.Points >= armor.Harga)
            {
                player.AddArmor(armor);
                player.SubtractPoints(armor.Harga);
                Console.WriteLine($"{armor.Nama} berhasil ditambahkan kedalam inventory.");
            }
            else
            {
                Console.WriteLine("Poin anda tidak cukup.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid.");
        }
    }
}
