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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<string> RefreshTokens { get; private set; }

        public User(string login, byte[] passwordHash, string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            Login = login;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
        }

        public static User Create(string login, string password, string firstName, string lastName)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var passwordHash = new SHA256Managed().ComputeHash(passwordBytes);

            return new User(login, passwordHash, firstName, lastName);
        }
    }
}