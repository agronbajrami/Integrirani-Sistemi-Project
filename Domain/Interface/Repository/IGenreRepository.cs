using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IGenreRepository
    {
        public Task<List<GenreClass>> GetAll();
        public Task<GenreClass> GetGenre(int id);
        public Task Create(GenreClass genreClass);
    }
}
