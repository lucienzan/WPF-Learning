namespace BSNWPF.Model
{
    public interface iCommonProperty
    {
        public string CreatedUserId { get; set; }
        public string ? UpdatedUserId { get; set; }
        public string ? DeletedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}