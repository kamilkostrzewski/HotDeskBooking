namespace HotDeskBooking.Application.Auth.Commands.CreateUser
{
    public class CreateUserModel
    {
        public string Login { get; }
        public string Password { get; }

        public CreateUserModel(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}