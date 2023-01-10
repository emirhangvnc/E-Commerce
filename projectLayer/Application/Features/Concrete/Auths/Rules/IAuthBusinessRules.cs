using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Auths.Rules
{
    public interface IAuthBusinessRules
    {
        Task EmailCanNotBeDuplicatedWhenRegistered(string email);
    }
}