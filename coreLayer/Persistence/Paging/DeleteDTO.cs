using Core.Persistence.Repositories;

namespace Core.Persistence.Paging
{
    public class DeleteDTO
    {
        public int Id { get; set; }
        public DeleteDTO()
        {
                
        }
        public DeleteDTO(int id)
        {
            Id = id;
        }
    }
}