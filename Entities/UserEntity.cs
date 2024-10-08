using System.ComponentModel.DataAnnotations;

namespace CodeFirstRelation.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<PostEntity> Posts { get; set; }
    }
}
