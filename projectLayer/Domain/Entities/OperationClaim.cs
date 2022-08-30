using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class OperationClaim : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OperationClaim(string name)
        {
            Name = name;
        }

        public OperationClaim(int id,string name) : this(name)
        {
            Id = id;
        }
    }
}