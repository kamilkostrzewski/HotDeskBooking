using HotDeskBooking.Domain.Abstract;

namespace HotDeskBooking.Domain
{
    public class User : Entity
    {
        public string Login { get; private set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }
    }
}