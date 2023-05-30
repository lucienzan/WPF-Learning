namespace BSNWPF.Model
{
    public class Role : iRole
    {
        public Role()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public int DataStatus { get ; set ; }

    }
}
