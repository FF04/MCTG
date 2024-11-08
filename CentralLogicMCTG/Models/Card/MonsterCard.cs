using System;

namespace MCTG.Models.Card
{
    public class MonsterCard : CardModel
    {
        Random rnd = new Random();
        string[] MonsterNames = new string[]
  {
    "Fire Drake",
    "Shadow Stalker",
    "Iron Golem",
    "Vampire Lord",
    "Bone Crusher",
    "Frost Wraith",
    "Nightmare Beast",
    "Toxic Serpent",
    "Ancient Wyvern",
    "Doom Bringer",
    "Stone Guardian",
    "Dark Phoenix",
    "Grim Reaper",
    "Venomous Hydra",
    "Spectral Wolf",
    "Thunder Titan",
    "Cursed Minotaur",
    "Chaos Elemental",
    "Blood Fiend",
    "Celestial Griffin"
  };



        public MonsterCard(string name, int damage, ElementTypes elementType) : base(name, damage, elementType)
        {
            Name = name;
            Damage = damage;
            ElementType = elementType;
        }

        public MonsterCard()
        {
#warning name hat nichts mit damage und fähigkeit zu tun... (dictionary?)
            Name = MonsterNames[rnd.Next(0, MonsterNames.Length)];
            Damage = rnd.Next(1,100);
            ElementType = (ElementTypes)rnd.Next(0, Enum.GetNames(typeof(ElementTypes)).Length);
        }




    }


}
