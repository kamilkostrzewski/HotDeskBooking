using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using HotDeskBooking.Domain.Abstract;

namespace HotDeskBooking.Domain.Auth
{
    public class User : Entity
    {
        public string Login { get; private set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }
        public List<string> RefreshToken { get; set; }

        public User(string login, byte[] passwordHash)
        {
            Id = Guid.NewGuid();
            Login = login;
            PasswordHash = passwordHash;
        }

        public static User Create(string login, string password)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var passwordHash = new SHA256Managed().ComputeHash(passwordBytes);

            return new User(login, passwordHash);
        }
    }
}