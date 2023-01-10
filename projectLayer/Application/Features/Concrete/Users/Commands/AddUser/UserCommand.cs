using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Users.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Users.Commands.AddUser
{
    public class UserCommand : IRequest<IDataResult<Domain.Entities.User>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public class UserCommandHandler : IRequestHandler<UserCommand, IDataResult<Domain.Entities.User>>
        {
            private readonly IUserBusinessRules _userBusinessRules;
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public UserCommandHandler(IUserBusinessRules authBusinessRules, IUserRepository userRepository, IMapper mapper)
            {
                _userBusinessRules = authBusinessRules;
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Domain.Entities.User>> Handle(UserCommand request, CancellationToken cancellationToken)
            {
                var result = await _userBusinessRules.EmailExists(request.Email);
                if (!result.Success)
                    return new ErrorDataResult<Domain.Entities.User>(result.Message);

                Domain.Entities.User mappedUser = _mapper.Map<Domain.Entities.User>(request);
                mappedUser.Status = true;
                mappedUser.CreatedDate = DateTime.Now;
                mappedUser.UpdatedDate = DateTime.Now;
                await _userRepository.AddAsync(mappedUser);
                return new SuccessDataResult<Domain.Entities.User>(mappedUser);

            }
        }
    }
}