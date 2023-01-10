using Core.Security.Entities;
using Core.Security.JWT;

namespace eCommerceLayer.Application.Features.Concrete.Auths.DTOs
{
    public class RefreshedTokenDto
    {
        public AccessToken AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}