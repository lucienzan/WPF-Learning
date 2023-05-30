
using Microsoft.EntityFrameworkCore;

namespace BSNWPF.Back.DataAccess.Data
{
    public partial class BSNBoardContext : DbContext
    {
        public BSNBoardContext() { }
        public BSNBoardContext(DbContextOptions<BSNBoardContext> options) : base(options)
        {
        }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=THEINZAN-PC;Database=BSNOJT;Trusted_Connection=False;User Id=Sa;Password=Password2254;TrustServerCertificate=True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
