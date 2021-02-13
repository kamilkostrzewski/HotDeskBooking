using MediatR;

namespace HotDeskBooking.Application.Auth.Commands.CreateUser
{
    public class CreateUserCommand : IRequest
    {
        public string Login { get; }
        public string Password { get; }

        public CreateUserCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}