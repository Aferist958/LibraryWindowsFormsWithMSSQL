using dotenv.net;
using Microsoft.EntityFrameworkCore;
using Library.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotEnv.Load(options: new DotEnvOptions(
                envFilePaths: new[] { "../.env" }
            ));
            var con = Environment.GetEnvironmentVariable("DB_CONNECTION");
            optionsBuilder.UseSqlServer(con);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books", "library");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()")
                .HasComment("Индефикатор для книг");
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(255)
                .HasComment("Название книг");
            builder.Property(x => x.Author)
                .IsRequired()
                .HasMaxLength(255)
                .HasComment("Автор книги");
            builder.Property(x => x.YearOfPublucation)
                .HasComment("Год издания");
            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasComment("Количество книг");
        }
    }
}
