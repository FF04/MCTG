
using MCTG.Models.Card;

namespace MCTG.Models
{
    public class User
    {
        #region CONSTANTS
        private const int START_COINS = 20;
        private const int DECK_SIZE = 4;
        #endregion


        public User(string email, string password)
        {
            Email = email;
            Password = password;

            Deck = new CardModel[DECK_SIZE];
            CardStack = new();
            Coins = START_COINS;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public List<CardModel> CardStack { get; set; }
        public CardModel[] Deck { get; set; }
        public int Coins { get; set; }

        public override string ToString()
        {
            return @$"
{nameof(Email)}:{Email}
{nameof(Password)}:{Password}
{nameof(CardStack)}:{CardStack.Count()}
{nameof(Coins)}:{Coins}
";
        }

    }
}
