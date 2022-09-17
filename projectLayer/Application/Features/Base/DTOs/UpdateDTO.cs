namespace eCommerceLayer.Application.Features.Base.DTOs
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