namespace BSNWPF.Model
{
    public class Post : iPost, iCommonProperty
    {
        public Post()
        {
            this.Id = 0;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.CreatedUserId = string.Empty;
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = null;
            this.UpdatedUserId = null;
            this.DeletedDate = null;
            this.DeletedUserId = null;
            this.CreatedAt = null;
            this.CreatedBy = null;
            this.IsPublished = true;
            this.IsDeleted = false;
            this.SPublished = null;
            this.Keyword = string.Empty;
        }
        public int Id { get ; set ; }
        public string Title { get ; set ; }
        public string Description { get ; set ; }
        public bool IsPublished { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public int DataStatus { get ; set ; }
        public string CreatedUserId { get ; set ; }
        public string? UpdatedUserId { get ; set ; }
        public string? DeletedUserId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public DateTime? DeletedDate { get ; set ; }
        public string? CreatedBy { get; set; }
        public string? CreatedAt { get; set; }
        public string? SPublished { get; set; }
        public string? Keyword { get; set; }
    }
}
