using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Welcome.Model;
using Welcome.Others;

namespace DataLayer.Model
{
    public class DatabaseUser : User
    {
        public DatabaseUser(string name, string password, string email, UserRolesEnum role) : base(name, password, email, role)
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
    }
}
