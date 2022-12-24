﻿using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Services.Repositories
{
    public interface IAddressRepository : IAsyncRepository<Address>, IRepository<Address>
    {
    }
}