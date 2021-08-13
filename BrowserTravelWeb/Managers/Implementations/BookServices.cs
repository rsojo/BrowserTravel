using BrowserTravelWeb.Managers.Services;
using BrowserTravelWeb.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Managers.Implementations
{
    public class BookServices : IBookServices
    {
        private readonly IConfiguration _config;
        HttpClient client = new HttpClient();
        public BookServices(IConfiguration configuration)
        {
            _config = configuration;

        }
         
        public async Task<Response<Book>> GetAll()
        {
            var response = new Response<Book>();
            try
            {
                client.BaseAddress = new Uri("http://localhost:64159");
                var res = await client.GetAsync("api/Books");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    response.Lst = JsonConvert.DeserializeObject<List<Book>>(results);
                }
                else
                {
                    response.Error = true;
                }
            }
            catch (Exception ex)
            {
                response.Error = true;
            }
            return response;
        }

        public async Task<Response<Book>> GetDetails(int id)
        {
            var response = new Response<Book>();
            try
            {
                client.BaseAddress = new Uri("http://localhost:64159");
                var url = "api/Books" + id;
                var res = await client.GetAsync(url);
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    response.UnitResp = JsonConvert.DeserializeObject<Book>(results);
                }
                else
                {
                    response.Error = true;
                }
            }
            catch (Exception ex)
            {
                response.Error = true;
            }
            return response;
        }
    }
}
