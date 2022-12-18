using System.ComponentModel.DataAnnotations;

namespace eCommerceLayer.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}