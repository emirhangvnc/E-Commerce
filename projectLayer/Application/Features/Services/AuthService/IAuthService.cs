using Core.Security.Entities;
using Core.Security.JWT;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Services.AuthService
{
    public interface IAuthService
    {
        Task<IDataResult<AccessToken>> CreateAccessToken(Domain.Entities.User user);
        Task<IDataResult<RefreshToken>> CreateRefreshToken(Domain.Entities.User user, string ipAddress);
        Task<IDataResult<RefreshToken>> AddRefreshToken(RefreshToken refreshToken);
    }
}