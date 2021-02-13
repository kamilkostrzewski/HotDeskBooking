using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HotDeskBooking.Domain.Auth;
using HotDeskBooking.Persistence.Repositories.Abstract;

namespace HotDeskBooking.Application.Auth.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IAuthRepository _authRepository;

        public CreateUserCommandHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = User.Create(request.Login, request.Password);
            _authRepository.Add(user);

            return Unit.Task;
        }
    }
}