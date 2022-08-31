using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }

        public User(string firstName, string lastName, string email, byte[] passwordSalt, byte[] passwordHash,bool status)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            Status = status;
        }

        public User(int id, string FirstName, string LastName, string Email, byte[] PasswordSalt, byte[] PasswordHash, bool Status) : this(FirstName, LastName, Email, PasswordSalt, PasswordHash, Status)
        {
            Id = id;
        }
    }
}