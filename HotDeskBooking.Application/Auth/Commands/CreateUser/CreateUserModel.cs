namespace HotDeskBooking.Application.Auth.Commands.CreateUser
{
    public class CreateUserModel
    {
        public string Login { get; }
        public string Password { get; }
        public string FirstName { get; }
        public string LastName { get; }


        public CreateUserModel(string login, string password, string firstName, string lastName)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}