﻿using Core.Persistence.Repositories;

namespace Core.Persistence.Paging
{
    public class UpdateDTO
    {
        public int Id { get; set; }
        public UpdateDTO()
        {

        }
        public UpdateDTO(int id)
        {
            Id = id;
        }
    }
}