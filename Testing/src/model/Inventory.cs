using System;
using System.Collections.Generic;

class Inventory 
{
    private List<Armor> armors;
    private List<Weapon> weapons;

    public Inventory()
    {
        armors = new List<Armor>();
        weapons = new List<Weapon>();
    }

    public void AddArmor(Armor armor)
    {
        armors.Add(armor);
    }

    public void AddWeapon(Weapon weapon)
    {
        weapons.Add(weapon);
    }

    public void RemoveArmor(Armor armor)
    {
        armors.Remove(armor);
    }

    public void RemoveWeapon(Weapon weapon)
    {
        weapons.Remove(weapon);
    }

    public void DisplayInventory()
    {
        Console.WriteLine("\n=== Inventory ===");
        Console.WriteLine("Armors:");
        for (int i = 0; i < armors.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {armors[i].Nama} - Health Buff: {armors[i].HealthBuff} - {armors[i].Deskripsi}");
        }

        Console.WriteLine("\nWeapons:");
        for (int i = 0; i < weapons.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weapons[i].Nama} - Attack Power Buff: {weapons[i].AttackPowerBuff} - {weapons[i].Deskripsi}");
        }
    }

    public Armor GetArmor(int index)
    {
        if (index >= 0 && index < armors.Count)
        {
            return armors[index];
        }
        return null;
    }

    public Weapon GetWeapon(int index)
    {
        if (index >= 0 && index < weapons.Count)
        {
            return weapons[index];
        }
        return null;
    }
}
