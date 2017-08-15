using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDnD5
{
    class Creature
    {
        public bool Legendary { get; set; }
        public string ChallengeRating { get; set; } //0, 1/8, 1/4, 1/2, 1-30
        public int ProficiencyBonus { get; set; } // = (CR - 1) / 2 [min 2]
        public char Size   { get; set; }
            //Tiny (2.5x2.5 ft), Small (5x5 ft), Medium (5x5 ft), Large (10x10 ft), Huge (15x15 ft), Gargantuan (min 20x20 ft)
        public string Type { get; set; }
            //Aberration, Beast, Celestial, Construct, Dragon, Elemental, Fey, Fiend, Giant, Humanoid, Monstrosity, Ooze, Plant, Undead
        public string[] Tags { get; set; }
            //example: Humanoid (Orc)
        public string Alignment { get; set; }
            //Good, Evil, Law, Chaos, Neutral, Unaligned

        //Ability Scores
        public int Strength  { get; set; }
        public int Dexterity { get; set; }
        public int Condition { get; set; }
        public int Intellect { get; set; }
        public int Wisdom    { get; set; }
        public int Charisma  { get; set; }

        //Saving Throws
        public bool StrengthSave  { get; set; }
        public bool DexteritySave { get; set; }
        public bool ConditionSave { get; set; }
        public bool IntellectSave { get; set; }
        public bool WisdomSave    { get; set; }
        public bool CharismaSave  { get; set; }

        public int HitDie     { get; set; }
            //Tiny - d4, Small - d6, Medium - d8, Large - d10, Huge - d12, Gargantuan - d20
        public int HitDieQty  { get; set; }
        public int HitPoints  { get; set; }
        public int ArmorClass { get; set; }

        //Speed
        public int WalkSpeed    { get; set; }
        public int FlySpeed     { get; set; }
            public bool Hover           { get; set; }
        public int SwimSpeed    { get; set; }
        public int ClimbSpeed   { get; set; }
        public int BurrowSpeed  { get; set; }
            public bool SolidRockBurrow { get; set; }

        //Skills
        public int Perception { get; set; }

        //Vulnerability, Resistance, Immunity
        public bool FireVul { get; set; }
        public bool FireRes { get; set; }
        public bool FireImm { get; set; }

        //Senses
        public int Blindsight  { get; set; }
        public int Darkvision  { get; set; }
        public int Tremorsense { get; set; }
        public int Truesight   { get; set; }

        public string[] Languages { get; set; }
        public int Telepathy { get; set; }
        public Object[] SpecialTraits { get; set; }
        public Object[] Equipment { get; set; }
        public Object[] Actions { get; set; }
    }
}
