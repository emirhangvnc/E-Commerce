namespace eCommerceLayer.Application.Features.Base.DTOs
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