using Core.Persistence.Paging;
using Core.Security.Entities;
using Core.Security.JWT;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eCommerceLayer.Application.Features.Services.AuthService
{
    public class AuthManager : IAuthService
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly ITokenHelper _tokenHelper;
        private readonly IRefreshTokenRepository _refreshTokenRepository;

        public AuthManager(IUserOperationClaimRepository userOperationClaimRepository, ITokenHelper tokenHelper, IRefreshTokenRepository refreshTokenRepository)
        {
            _userOperationClaimRepository = userOperationClaimRepository;
            _tokenHelper = tokenHelper;
            _refreshTokenRepository = refreshTokenRepository;
        }

        public async Task<IDataResult<RefreshToken>> AddRefreshToken(RefreshToken refreshToken)
        {
            RefreshToken addedRefreshToken = await _refreshTokenRepository.AddAsync((Domain.Entities.RefreshToken)refreshToken);
            return new SuccessDataResult<RefreshToken>(addedRefreshToken);
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            IPaginate<UserOperationClaim> userOperationClaims =
               (IPaginate<UserOperationClaim>)await _userOperationClaimRepository.GetListAsync(u => u.UserId == user.Id,
                                                                include: u =>
                                                                    u.Include(u => u.OperationClaim)
               );
            IList<OperationClaim> operationClaims =
                userOperationClaims.Items.Select(u => new OperationClaim
                { Id = u.OperationClaim.Id, Name = u.OperationClaim.Name }).ToList();

            AccessToken accessToken = _tokenHelper.CreateToken(user, operationClaims);
            return new SuccessDataResult<AccessToken>(accessToken);
        }

        public async Task<IDataResult<RefreshToken>> CreateRefreshToken(User user, string ipAddress)
        {
            RefreshToken refreshToken = _tokenHelper.CreateRefreshToken(user, ipAddress);
            return new SuccessDataResult<RefreshToken>(refreshToken);
        }
    }
}