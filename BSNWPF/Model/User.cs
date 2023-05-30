namespace BSNWPF.Model
{
    public class User : iUser, iCommonProperty
    {
        public User()
        {
            this.Id = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.NPass = string.Empty;
            this.Address = string.Empty;
            this.Mobile = string.Empty;
            this.Dob = null;
            this.SDob = string.Empty;
            this.Role = 1;
            this.SRole = string.Empty;
            this.CreatedDate = DateTime.Now;
            this.CreatedUserId = string.Empty;
            this.CreatedUser = string.Empty;
            this.UpdatedDate = null;
            this.UpdatedUserId = string.Empty;
            this.DeletedDate = null;
            this.DeletedUserId = string.Empty;
            this.IsActive = true;
            this.SActive = string.Empty;
            this.IsDeleted = false;
            this.Keyword = string.Empty;
            
        }
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Email { get ; set ; }
        public string Password { get ; set ; }
        public string Address { get ; set ; }
        public string Mobile { get ; set ; }
        public int Role { get ; set ; }
        public DateTime? Dob { get ; set ; }
        public bool IsActive { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public int DataStatus { get ; set ; }
        public string CreatedUserId { get ; set ; }
        public string? UpdatedUserId { get ; set ; }
        public string? DeletedUserId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public DateTime? DeletedDate { get ; set ; }
        public string? FullName { get; set; }
        public string? SRole { get; set; }
        public string? SDob { get; set; }
        public string? CreatedUser { get; set; }
        public string? Keyword { get; set; }
        public string? SActive { get; set; }
        public string? NPass { get; set; }
    }
}
