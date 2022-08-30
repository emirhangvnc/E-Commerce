﻿using coreLayer.Permanency.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IBrandImageRepository : IAsyncRepository<BrandImage>, IRepository<BrandImage>
    {

    }
}