namespace MCTG
{
    public class Card
    {
        public Card(string name, int damage, ElementTypes elementType, CardTypes cardType)
        {
            Name = name;
            Damage = damage;
            ElementType = elementType;
            CardType = cardType;
        }

        public string Name { get; set; }
        public int Damage { get; }
        public ElementTypes ElementType { get; set; }
        public CardTypes CardType { get; set; }
    }

    public enum ElementTypes
    {
        None = 0,
    }
#warning besser vererbung einbauen...?
    public enum CardTypes
    {
        SpellCard,
        MonsterCard
    }
}
