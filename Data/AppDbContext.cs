using libreriaa_SLE.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreriaa_SLE.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Books)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Books)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.AuthorId);


        }


        //UTILIZAREMOS ESTE METODO PARA OBTENER Y ENVIAR DATOS A LA DB
        public DbSet<Books> Books { get; set; }

        public DbSet<Author> Authors {  get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }





    }
}
