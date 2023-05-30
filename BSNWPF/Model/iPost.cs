namespace BSNWPF.Model
{
    public interface iPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public int DataStatus { get; set; }
    }
}
