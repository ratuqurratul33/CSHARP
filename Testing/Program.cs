using System;
using System.Collections.Generic;
namespace Testing
{
    
class Program
{
    public static void Main(string[] args)
    {
        Controller ct = new Controller();
        Inventory inv = new Inventory();
        Store st = new Store();

        ct.InitEnemies();
        while(true){
            int pilihanAwal = ct.MenuAwal(); 
            switch (pilihanAwal)
            {
                case 1:
                    String nama = ct.SetNama(); 
                    int poin = 0;
                    Player player = new Player("P01", nama, 100, 30, poin);  

                    bool inGame = true; 
                    while (inGame)
                    {
                        int pilihanGame = ct.MenuGame(); 
                        switch (pilihanGame)
                        {
                            case 1:
                                poin = ct.GrindingPoin(poin);
                                player.AddPoints(poin); 
                                break;
                            case 2:
                                ct.ShowStats(player);
                                break;
                            case 3:
                                int pilihanInventory = player.DisplayInventory(); 
                                {
                                    Console.WriteLine("Mau pakai apa : ");
                                    Console.WriteLine("1. Armor");
                                    Console.WriteLine("2. Weapon");
                                    Console.Write("Pilihan : ");

                                    int pilihanPakai = Convert.ToInt32(Console.ReadLine());
                                    if (pilihanPakai == 1)  
                                    {
                                        Console.Write("Pilihan armor nomor berapa : ");
                                        int pilihanArmor = Convert.ToInt32(Console.ReadLine());
                                        player.EquipArmor(pilihanArmor);
                                    }
                                    else if (pilihanPakai == 2)
                                    {
                                        Console.Write("Pilihan weapon nomor berapa : ");
                                        int pilihanWeapon = Convert.ToInt32(Console.ReadLine());
                                        player.EquipWeapon(pilihanWeapon);
                                    }
                                }
                                break;
                            case 4:
                                int pilihanStore = st.DisplayStoreItems(); 
                                switch (pilihanStore)
                                {
                                    case 1:
                                        Console.Write("Beli weapon nomor berapa : ");
                                        int indexWeapon = Convert.ToInt32(Console.ReadLine()); 
                                        st.BuyWeapon(player, indexWeapon);
                                        break;
                                    case 2:
                                        Console.Write("Beli armor nomor berapa : ");
                                        int indexArmor = Convert.ToInt32(Console.ReadLine());
                                        st.BuyArmor(player, indexArmor);
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        Console.WriteLine("Input tidak valid");
                                        break;
                                }
                                break;
                            case 5:
                                ct.BattleMenu(player);
                                break;
                            case 6:
                                inGame = false;
                                Console.WriteLine("Terima kasih telah bermain !");
                                break;
                            default:
                                Console.WriteLine("Pilihan tidak valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    ct.Credits(); 
                    break;
                case 3:
                    Console.WriteLine("Keluar dari game.");
                    Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
}


