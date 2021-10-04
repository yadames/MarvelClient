
using MarvelClient.Models;
using MarvelClient.Repository.Marvel.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelClient.Repository.Marvel
{
    public interface IMarvelApi
    {
        [Get("/characters/{id}")]
        Task<ApiResponse<Hero>> FindCharacterById([AliasAs("id")] int id, Request query);
    }
}
