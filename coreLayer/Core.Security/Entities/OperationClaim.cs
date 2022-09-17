using Core.Persistence.Repositories;
using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class OperationClaim : IdBaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}