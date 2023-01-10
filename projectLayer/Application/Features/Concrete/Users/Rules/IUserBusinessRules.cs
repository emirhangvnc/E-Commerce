using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Concrete.Users.Rules
{
    public interface IUserBusinessRules
    {
        Task<IResult> EmailExists(string name);
    }
}