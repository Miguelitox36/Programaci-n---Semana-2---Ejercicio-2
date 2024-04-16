using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Semana_2___Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> inventory = new List<Weapon>();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add weapon");
                Console.WriteLine("2. View inventory");
                Console.WriteLine("3. Delete weapon");
                Console.WriteLine("4. Exit");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddWeapon(inventory);
                        break;
                    case "2":
                        ViewInventory(inventory);
                        break;
                    case "3":
                        RemoveWeapon(inventory);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddWeapon(List<Weapon> inventory)
        {
            Console.WriteLine("Enter the weapon name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter weapon damage:");
            int damage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the weapon's attack speed:");
            double speedAttack = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price of the weapon:");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is it a ranged weapon? (Y/N)");
            string isDistance = Console.ReadLine().ToLower();

            if (isDistance == "Y")
            {
                Console.WriteLine("Enter projectile name:");
                string nameProjectil = Console.ReadLine();
                Console.WriteLine("Enter projectile damage:");
                int damageProjectil = Convert.ToInt32(Console.ReadLine());

                Projectile projectile = new Projectile(nameProjectil, damageProjectil);
                WeaponRange newWeapon = new WeaponRange(name, damage, speedAttack, price, projectile);
                inventory.Add(newWeapon);
            }
            else
            {
                Weapon newWeapon = new Weapon(name, damage, speedAttack, price);
                inventory.Add(newWeapon);
            }

            Console.WriteLine("Weapon added to inventory.");
        }

        static void ViewInventory(List<Weapon> inventory)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                Console.WriteLine("Inventary:");
                foreach (Weapon weapon in inventory)
                {
                    Console.WriteLine($"Name: {weapon.Name}, Damage per second: {weapon.DamagePerSecond()}, Price: {weapon.Price}");
                }
            }
        }

        static void RemoveWeapon(List<Weapon> inventory)
        {
            Console.WriteLine("Enter the index of the weapon you want to delete:");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice >= 0 && indice < inventory.Count)
            {
                inventory.RemoveAt(indice);
                Console.WriteLine("Weapon removed from inventory.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

    }
}
