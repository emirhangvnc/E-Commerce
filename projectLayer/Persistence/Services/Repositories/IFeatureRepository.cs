﻿using Core.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IFeatureRepository : IAsyncRepository<Feature>, IRepository<Feature>
    {

    }
}