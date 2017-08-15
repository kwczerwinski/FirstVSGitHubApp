using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDnD5
{
    class Weapon
    {
        public string Name { get; set; }
        public string Rarity { get; set; }
        public bool ImprovisedMelee { get; set; }
        public int MeleeDamage { get; set; }
        public string MeleeDamageType { get; set; }
        public int Reach { get; set; }
        public bool ImprovisedThrown { get; set; }
        public int ThrownDamage { get; set; }
        public string ThrownDamageType { get; set; }
        public int ThrownShortRange { get; set; }
        public int ThrownLongRange { get; set; }
        public Object[] Properties { get; set; }
        public int Cost { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
    }
}
