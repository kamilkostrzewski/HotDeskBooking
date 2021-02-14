using HotDeskBooking.Domain.Auth;
using HotDeskBooking.Persistence.Repositories.Abstract;

namespace HotDeskBooking.Persistence.Repositories.Base
{
    public class AuthRepository : IAuthRepository
    {
        protected readonly DatabaseContext DatabaseContext;

        public AuthRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public void Add(User user)
        {
            DatabaseContext.Users.Add(user);
            DatabaseContext.SaveChanges();
        }
    }
}