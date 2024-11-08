using MCTG.Models;
using MCTG.Models.Card;

namespace MCTG.Services
{
    public interface IUserService
    {
        void RegisterUser(User user);
        void LoginUser(User user);
        void Battle(User u1, User u2);
        void BuyPackage(User user);
        void Trade(User fromUser, User toUser, CardModel cardFromfromUser);
    }
}