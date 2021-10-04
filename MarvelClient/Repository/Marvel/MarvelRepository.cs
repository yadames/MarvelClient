using MarvelClient.Models;
using MarvelClient.Repository.Contract;
using MarvelClient.Repository.Marvel.Model;
using MarvelClient.Utils;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MarvelClient.Repository.Marvel
{
    public class MarvelRepository : IRepository
    {
        private readonly IMarvelApi _marvelApi;

        public MarvelRepository(IMarvelApi marvelApi) {
            _marvelApi = marvelApi;
        }

        public async Task<Hero> FindHeroByIdAsync(int heroId)
        {
            Request request = CreateRequest();
            ApiResponse<Hero> response = await _marvelApi.FindCharacterById(heroId, request);
            if (response.IsSuccessStatusCode && response.Content is Hero hero)
            {
                return hero;
            }
            else {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(response.Error.Content);
                throw new Exception(error.Message != null ? error.Message : error.Status);
            }
        }

        private Request CreateRequest()
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");

            return new Request()
            {
                TimeStamp = timeStamp,
                ApiKey = Constant.MARVEL_PUBLIC_KEY,
                Hash = CreateMD5Hash(timeStamp + Constant.MARVEL_PRIVATE_KEY + Constant.MARVEL_PUBLIC_KEY).ToLower()
            };
        }

        private string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
