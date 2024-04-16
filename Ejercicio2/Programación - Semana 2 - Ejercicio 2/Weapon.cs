using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Semana_2___Ejercicio_2
{
    class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public double SpeedAttack { get; set; }
        public int Price { get; set; }

        public Weapon(string name, int damage, double speedAttack, int price)
        {
            Name = name;
            Damage = damage;
            SpeedAttack = speedAttack;
            Price = price;
        }
                
        public virtual double DamagePerSecond()
        {
            return Damage / SpeedAttack;
        }
    }
}
