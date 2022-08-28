using coreLayer.Persistence.Repositories;

namespace coreLayer.Persistence.Paging
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