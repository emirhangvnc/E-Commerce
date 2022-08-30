﻿using AutoMapper;
using projectLayer.Persistence.Contexts;

namespace projectLayer.Application.Features.Base.Rules
{
    public class ManagerBase
    {
        public BaseDbContext DbContext { get; }
        public IMapper Mapper { get; }

        public ManagerBase(IMapper mapper)
        {
            Mapper = mapper;
        }

        public ManagerBase(IMapper mapper, BaseDbContext context)
        {
            Mapper = mapper;
            DbContext = context;
        }
        public ManagerBase(BaseDbContext context)
        {
            DbContext = context;
        }
    }
}