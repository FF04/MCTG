namespace MCTG.Models.Card
{
    public class SpellCard : CardModel
    {
        public SpellCard(string name, int damage, ElementTypes elementType) : base(name, damage, elementType)
        {
            Name = name;
            Damage = damage;
            ElementType = elementType;
        }

    }


}
