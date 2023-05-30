namespace BSNWPF.Model
{
    public interface iUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int Role { get; set; }
        public DateTime? Dob { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int DataStatus { get; set; }
    }
}
