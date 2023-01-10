using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Users.Rules
{
    public class UserBusinessRules : ManagerBase, IUserBusinessRules
    {
        IUserRepository _userRepository;
        public UserBusinessRules(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            _userRepository = userRepository;
        }

        public async Task<IResult> EmailExists(string email)
        {
            var result = await _userRepository.GetAsync(v => v.Email == email);
            if (result != null && result.Status == true)
                return new ErrorResult($"Email Address Already Added");
            return new SuccessResult();
        }
    }
}