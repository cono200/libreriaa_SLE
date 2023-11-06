using libreriaa_SLE.Data.Models;
using libreriaa_SLE.Data.ViewModels;
using System;

namespace libreriaa_SLE.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {

            _context = context;

        }

        //METODO QUE NOS PERMITE AGREGAR UN NUEVO EDITORA  EN LA BD


        public void AddPublishers(PublisherVM publisher)
        {
            var _Publishers = new Publisher()
            {
                Name = publisher.Name
            };

            _context.Publishers.Add(_Publishers);
            _context.SaveChanges();
        }






    }
}
