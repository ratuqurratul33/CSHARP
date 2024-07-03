using System;
using System.Collections.Generic;

class Controller
{
    Inventory inv = new Inventory(); 
    Store store = new Store();
    List<Enemy> enemies = new List<Enemy>();

    public int MenuAwal() 
    {
        Console.WriteLine(
        "                      █░░░█ █▀▀ █░░ █▀▀ █▀▀█ █▀▄▀█ █▀▀ 　 ▀▀█▀▀ █▀▀█" +
        "\n                      █▄█▄█ █▀▀ █░░ █░░ █░░█ █░▀░█ █▀▀ 　 ░░█░░ █░░█" +
        "\n                      ░▀░▀░ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀░░░▀ ▀▀▀ 　 ░░▀░░ ▀▀▀▀");
        Console.WriteLine(
        "\n\n░██████╗░█████╗░██╗░░░░░░█████╗░  ██╗░░░░░███████╗██╗░░░██╗███████╗██╗░░░░░██╗███╗░░██╗░██████╗░" +
        "\n██╔════╝██╔══██╗██║░░░░░██╔══██╗  ██║░░░░░██╔════╝██║░░░██║██╔════╝██║░░░░░██║████╗░██║██╔════╝░" +
        "\n╚█████╗░██║░░██║██║░░░░░██║░░██║  ██║░░░░░█████╗░░╚██╗░██╔╝█████╗░░██║░░░░░██║██╔██╗██║██║░░██╗░" +
        "\n░╚═══██╗██║░░██║██║░░░░░██║░░██║  ██║░░░░░██╔══╝░░░╚████╔╝░██╔══╝░░██║░░░░░██║██║╚████║██║░░╚██╗" +
        "\n██████╔╝╚█████╔╝███████╗╚█████╔╝  ███████╗███████╗░░╚██╔╝░░███████╗███████╗██║██║░╚███║╚██████╔╝" +
        "\n╚═════╝░░╚════╝░╚══════╝░╚════╝░  ╚══════╝╚══════╝░░░╚═╝░░░╚══════╝╚══════╝╚═╝╚═╝░░╚══╝░╚═════╝░");

        Console.WriteLine("\n\t\t\t\t\t1. Start Game");
        Console.WriteLine("\t\t\t\t\t2. Credits");
        Console.WriteLine("\t\t\t\t\t3. Exit Game");

        Console.Write("\n\n\t\t\t\t   Masukkan Pilihan Anda : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        return pilihan;
    }

    public void Credits(){
        Console.WriteLine("\n");
        Console.WriteLine("\t\t\t================== Credits ===================");
        Console.WriteLine("\t\t\t          Game Title : Solo Leveling");
        Console.WriteLine("\t\t\t         Developed by : Ratu ");
        Console.WriteLine("\t\t\t               Contributors :");
        Console.WriteLine("\t\t\t               - Fore nangor");
        Console.WriteLine("\t\t\t              Special Thanks :");
        Console.WriteLine("\t\t\t                - Tuhan YME");
        Console.WriteLine("\t\t\t              - Mamah & Papah");
        Console.WriteLine("\t\t\t              - kating 24/7ku");
        Console.WriteLine("\t\t\t            - Persib juara berisik");
        Console.WriteLine("\t\t\t  © 2024 Ratu'sCorp. All rights reserved.");
        Console.WriteLine("\t\t\t==============================================\n\n");

    }

    public String SetNama() 
    {
        Console.WriteLine("\n\nHi Selamat datang !");
        Console.Write("Siapa nama anda : ");

        String nama = Convert.ToString(Console.ReadLine());
        return nama;
    }

    public int MenuGame()
    {
        Console.WriteLine("\n1. Grinding/Farming");
        Console.WriteLine("2. Show Stats");
        Console.WriteLine("3. Inventory");
        Console.WriteLine("4. Store");
        Console.WriteLine("5. Battle");
        Console.WriteLine("6. Exit");

        Console.Write("Masukkan Pilihan Anda : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        return pilihan;
    }

    public int GrindingPoin(int poin) 
    {
        int hasil = 0; 
        bool gameProgram = true; 

        Console.WriteLine("\nSelamat datang di tebak tebakan !");
        Console.WriteLine("Tebak angka (1 - 10) jika benar anda mendapatkan 10 poin !");

        do
        {
            Random rand = new Random();
            int angkaRandom = rand.Next(1, 11);

            Console.Write("Masukkan angka tebakan anda : ");

            int angkaTebakan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAngka Random : " + angkaRandom);
            Console.WriteLine("Angka Tebakan : " + angkaTebakan);

            if (angkaTebakan == angkaRandom)
            {
                Console.WriteLine("\nSelamat tebakan anda benar, anda mendapatkan poin 10");
                hasil += 10;
            }
            else
            {
                Console.WriteLine("\nYah tebakan anda salah, better luck next time !");
            }

            Console.WriteLine("\nPoin yang berhasil anda kumpulkan : " + hasil);
            Console.Write("Apakah anda akan bermain lagi ? (y/n) : ");

            String pilihan = Convert.ToString(Console.ReadLine());

            if (!pilihan.Equals("y")) 
            {
                gameProgram = false;
            }
        } while (gameProgram);

        Console.WriteLine("\nTerima kasih telah bermain, poin yang telah anda kumpulkan : " + hasil);
        return poin += hasil;
    }

    public void ShowStats(Player player) 
    {
        Console.WriteLine("\n=== Statistik Pemain ===");
        Console.WriteLine($"Nama : {player.Nama}");
        Console.WriteLine($"Health : {player.Health}");
        Console.WriteLine($"Attack Power : {player.AttackPower}"); 
        Console.WriteLine($"Points : {player.Points}");
        if (player.Armor != null) 
        {
            Console.WriteLine($"Armor: {player.Armor.Nama} (Health Buff: {player.Armor.HealthBuff})");
        }
        if (player.Weapon != null)
        {
            Console.WriteLine($"Weapon: {player.Weapon.Nama} (Attack Power Buff: {player.Weapon.AttackPowerBuff})");
        }
        Console.WriteLine("=========================");
    }

    public void InitEnemies() 
    {
        enemies = new List<Enemy>
        {
            new Enemy("E001", "Goblin", 30, 5), 
            new Enemy("E002", "Orc", 50, 10),
            new Enemy("E003", "Troll", 80, 15),
            new Enemy("E004", "Dragon", 120, 20),
            new Enemy("E005", "Demon Lord", 150, 25)
        }; 
    }

    public void BattleMenu(Player player)
    {
        Console.WriteLine("\nPilih musuh untuk bertarung : ");
        for (int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {enemies[i].Nama} (Health: {enemies[i].Health}, Attack Power: {enemies[i].AttackPower})");
        }
        Console.Write("Pilih musuh (1-5) : ");
        int enemyIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (enemyIndex >= 0 && enemyIndex < enemies.Count) 
        {
            Battle(player, enemies[enemyIndex]);
        }
        else
        {
            Console.WriteLine("Musuh tidak valid.");
        }
    }

    public void Battle(Player player, Enemy enemy)
    {
        Console.WriteLine($"\nAnda bertarung dengan {enemy.Nama}!");

        while (player.Health > 0 && enemy.Health > 0) 
        {
            enemy.Health -= player.AttackPower; 
            Console.WriteLine($"Anda menyerang {enemy.Nama} dan menyebabkan {player.AttackPower} damage.");

            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{enemy.Nama} telah dikalahkan!");
                player.AddPoints(20);
                Console.WriteLine("Anda mendapatkan 20 poin."); 
                break;
            }

            player.Health -= enemy.AttackPower; 
            Console.WriteLine($"{enemy.Nama} menyerang Anda dan menyebabkan {enemy.AttackPower} damage.");

            if (player.Health <= 0) 
            {
                Console.WriteLine("Anda telah dikalahkan!");
                break;
            }

            Console.WriteLine($"Health Anda: {player.Health}, Health {enemy.Nama}: {enemy.Health}");
        }
    }
}
