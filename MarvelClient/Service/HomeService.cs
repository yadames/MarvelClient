using MarvelClient.Models;
using MarvelClient.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Service
{
    public interface IMarvelService
    {
        Task<Hero> FindHeroById(int heroId);
    }

    public class MarvelService : IMarvelService
    {
        private readonly IRepository _repository;

        public MarvelService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Hero> FindHeroById(int heroId) => await _repository.FindHeroByIdAsync(heroId);

    }
}
