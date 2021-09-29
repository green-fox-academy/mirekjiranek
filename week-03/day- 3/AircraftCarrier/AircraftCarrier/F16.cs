using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F16
    {
        private int BaseDamage;
        private int maxAmmo;
        private int ammo;
        public int Ammo 
        {
            get { return ammo; }
            set { ammo = value; }
        }

        public F16()
        {
            this.BaseDamage = 30;
            this.maxAmmo = 8;
            this.Ammo = 0;
        }
        public int Fight()
        {
            Console.WriteLine($"Damge: {ammo*BaseDamage}");
            return ammo = 0;
        }
        public int RefilAmmo(int ammunation)
        {
            if (ammo >= maxAmmo)
            {
                Console.WriteLine($"Too much ammunation. Maximum ammo is {maxAmmo}");
                return ammunation;
            }
            else
            {
                
                ammunation = maxAmmo - ammo;
                return ammunation;
            }
            

        }


        

        
    }
}
