namespace MCTG.Services
{
    public interface IMainService
    {
        void AddUser(User user);
        void Battle(User u1, User u2);
        void BuyPackage(User user);
        void Trade(User fromUser, User toUser, Card cardFromfromUser);
    }
}