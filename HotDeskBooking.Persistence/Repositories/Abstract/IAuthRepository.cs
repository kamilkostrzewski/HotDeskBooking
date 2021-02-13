using HotDeskBooking.Domain.Auth;

namespace HotDeskBooking.Persistence.Repositories.Abstract
{
    public interface IAuthRepository
    {
        void Add(User user);
    }
}