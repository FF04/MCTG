
using MCTG.Models;

namespace MCTG.Services
{
    public class UserService : IUserService
    {

        List<User> users = new();


        #region CONSTANTS
        private const int PACKAGE_PRICE = 5;
        #endregion

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void Trade(User fromUser, User toUser, Card cardFromfromUser)
        {

        }

        public Card[] BuyPackage(User user)
        {
            if (user.Coins < PACKAGE_PRICE)
                return null;

            user.Coins -= PACKAGE_PRICE;

            Card[] Package = new Card[5];
#warning cards definen
            user.CardStack.AddRange(Package);

            return Package;
        }


        public void Battle(User u1, User u2)
        {
            //   u1.Deck
            //     u2.Deck


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
