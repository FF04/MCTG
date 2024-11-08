namespace MCTG.Models.Card
{
    public abstract class CardModel
    {
        public CardModel(string name, int damage, ElementTypes elementType)
        {
            Name = name;
            Damage = damage;
            ElementType = elementType;
        }
        public CardModel()
        {
                
        }
        public string Name { get; set; }
        public int Damage { get; init; } // init, damit auch über vererbungen im ctor zugewiesen werden kann
        public ElementTypes ElementType { get; set; }

    }

    public enum ElementTypes
    {
        Water,
        Fire,
        Air,
        earth
    }

}
