using coreLayer.Permanency.Repositories;

namespace coreLayer.Permanency.Paging
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