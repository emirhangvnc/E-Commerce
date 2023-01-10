﻿using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Favorites.DTOs
{
    public class FavoriteUpdateDTO : UpdateDTO, IDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}