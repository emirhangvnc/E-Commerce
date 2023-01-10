using AutoMapper;
using Core.Security.Hashing;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Auths.DTOs;
using eCommerceLayer.Application.Features.Concrete.Auths.Rules;
using eCommerceLayer.Application.Features.Concrete.Users.DTOs;
using eCommerceLayer.Application.Features.Services.AuthService;
using eCommerceLayer.Application.Features.Services.Repositories;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Auths.Commands.Register
{
    public class RegisterCommand : IRequest<IDataResult<RegisteredDto>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IpAddress { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, IDataResult<RegisteredDto>>
        {
            private readonly IAuthBusinessRules _authBusinessRules;
            private readonly IUserRepository _userRepository;
            private readonly IAuthService _authService;
            private readonly IMediator _mediator;
            private readonly IMapper _mapper;

            public RegisterCommandHandler(IAuthBusinessRules authBusinessRules, IUserRepository userRepository, IAuthService authService, IMediator mediator, IMapper mapper)
            {
                _authBusinessRules = authBusinessRules;
                _userRepository = userRepository;
                _authService = authService;
                _mediator = mediator;
                _mapper = mapper;
            }

            public async Task<IDataResult<RegisteredDto>> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                await _authBusinessRules.EmailCanNotBeDuplicatedWhenRegistered(request.Email);
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

                Domain.Entities.User newUser = new()
                {
                    Email = request.Email,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    CreatedDate= DateTime.UtcNow,
                    UpdatedDate= DateTime.UtcNow,
                    Status = true
                };

                var mappedAddUser = _mapper.Map<UserAddDTO>(newUser);
                var createdUser = _mediator.Send(mappedAddUser);
                var mappedUser = _mapper.Map<Domain.Entities.User>(createdUser);

                var createdAccessToken = await _authService.CreateAccessToken(mappedUser);
                var createdRefreshToken = await _authService.CreateRefreshToken(mappedUser, request.IpAddress);
                var addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken.Data);

                RegisteredDto registeredDto = new()
                {
                    RefreshToken = addedRefreshToken.Data,
                    AccessToken = createdAccessToken.Data,
                };
                return new SuccessDataResult<RegisteredDto>(registeredDto);

            }
        }
    }
}