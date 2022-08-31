﻿using Core.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {

    }
}