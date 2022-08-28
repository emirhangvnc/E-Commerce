using coreLayer.Persistence.Repositories;

namespace coreLayer.Persistence.Paging
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