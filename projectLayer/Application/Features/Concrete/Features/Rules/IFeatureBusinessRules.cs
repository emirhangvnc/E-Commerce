using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Features.Rules
{
    public interface IFeatureBusinessRules
    {
        Task<IDataResult<Feature>> IsIDExists(int id);
        Task<IResult> FeatureNameExists(string name);
    }
}