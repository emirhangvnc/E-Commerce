﻿using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Categories.DTOs
{
    public class CategoryListDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}