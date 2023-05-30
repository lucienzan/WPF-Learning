using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSNWPF.Back.DataAccess.Data
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string FirstName { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string LastName { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string Address { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Mobile { get; set; }
        public DateTime? Dob { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Role { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string CreateUserId { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string DeletedUserId { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
