
using MCTG.Models;
using MCTG.Models.Card;

namespace MCTG.Services
{
    public class UserService : IUserService
    {

        Random rnd = new Random();

        List<User> users = new();

        #region CONSTANTS
        private const int PACKAGE_PRICE = 5;
        private const int PACKAGE_SIZE = 5;
        #endregion

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void Trade(User fromUser, User toUser, CardModel cardFromfromUser)
        {

        }

        public CardModel[] BuyPackage(User user)
        {
            if (user.Coins < PACKAGE_PRICE)
                return null;

            user.Coins -= PACKAGE_PRICE;

            var Package = new CardModel[PACKAGE_SIZE];

            for (int i = 0; i < Package.Length; i++)
            {
                if (rnd.Next(2) == 0)
                    Package[i] = new MonsterCard("rnd name", 1, ElementTypes.Water);
                else
                    Package[i] = new SpellCard("rnd name", 1, ElementTypes.Water);
            }

            user.CardStack.AddRange(Package);

#warning gerade erhaltene karten sollen angezeigt werden...
            return Package;
        }


        public void Battle(User u1, User u2)
        {


        }

        internal void InitializeData()
        {
        }



        public void LoginUser(User user)
        {
            throw new NotImplementedException();
        }

        void IUserService.BuyPackage(User user)
        {
            throw new NotImplementedException();
        }
    }
}
