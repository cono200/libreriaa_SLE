using libreriaa_SLE.Data.ViewModels;
using libreriaa_SLE.Data.Models;
using libreriaa_SLE.Data.Services;
using System;

namespace libreriaa_SLE.Data.Services
{
    public class BooksServicecs
    {
        private AppDbContext _context;
        public BooksServicecs(AppDbContext context)
        {

            _context = context;

        }


        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };

            _context.Books.Add(_book);
            _context.SaveChanges();
        }



    }
}
