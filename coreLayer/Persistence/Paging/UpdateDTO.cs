using coreLayer.Permanency.Repositories;

namespace coreLayer.Permanency.Paging
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