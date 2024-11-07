namespace MCTG
{
    public class User
    {

        public User()
        {

#warning magic number
            Coins = 20;
        }
        public string Email{ get; set; }
        public string Password{ get; set; }
        public int Coins { get; set; }
        public List<Card> CardStack { get; set; } = new();

#warning magic number
        public Card[] Deck { get; set; } = new Card[4];
    }
}
