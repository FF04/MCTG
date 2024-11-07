
namespace MCTG.Services
{
    public class MainService : IMainService
    {

        List<User> users = new();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void Trade(User fromUser, User toUser, Card cardFromfromUser)
        {

        }

        public void BuyPackage(User user)
        {
#warning Magic number
            if (user.Coins < 5)
                return;
            user.Coins -= 5;

            Card[] Package = new Card[5];
#warning cards definen
            user.CardStack.AddRange(Package);


        }


        public void Battle(User u1, User u2)
        {
            //   u1.Deck
            //     u2.Deck


        }

        internal void InitializeData()
        {
            throw new NotImplementedException();
        }
    }
}
