using BrowserTravelWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Managers.Services
{
    public interface IBookServices
    {
        public Task<Response<Book>> GetAll();
        public Task<Response<Book>> GetDetails(int id);
    }
}
