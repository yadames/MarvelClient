using MarvelClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Repository.Contract
{
    public interface IRepository
    {
        Task<Hero> FindHeroByIdAsync(int heroId);
    }
}
