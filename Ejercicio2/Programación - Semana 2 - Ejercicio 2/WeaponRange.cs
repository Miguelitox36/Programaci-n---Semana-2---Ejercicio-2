using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Semana_2___Ejercicio_2
{
    class WeaponRange: Weapon
    {
        public Projectile projectile { get; set; }

        public WeaponRange(string name, int damage, double speedAttack, int price, Projectile projectile)
            : base(name, damage, velocidadAtaque, price)
            {
               Projectile = projectile;
             }

        public override double DamagePerSecond()
        {
        return base.DamagePerSecond() + projectile.Damage;
        }
    }
}

