using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDnD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature aarakocra = new Creature();
            //aarakocra.ChallengeRating = "1/4";
            //aarakocra.Strength = 10;
            aarakocra.Dexterity = 14;
            aarakocra.Condition = 10;
            //aarakocra.Intellect = 11;
            //aarakocra.Wisdom = 12;
            //aarakocra.Charisma = 11;
            aarakocra.ArmorClass = 10 + (aarakocra.Dexterity - 10) / 2;
            //aarakocra.Size = 'M';
            //aarakocra.Alignment = "neutral good";
            //aarakocra.Type = "humanoid";
            //aarakocra.Tags = new string[] { "aarakocra" };
            aarakocra.HitDieQty = 3;
            aarakocra.HitDie = 8;
            aarakocra.HitPoints = aarakocra.HitDieQty * (aarakocra.HitDie + aarakocra.Condition - 9) / 2;
            //aarakocra.WalkSpeed = 20;
            //aarakocra.FlySpeed = 50;

            Console.WriteLine(aarakocra.ArmorClass);
            Console.ReadKey();

        }
    }
}
