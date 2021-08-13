using BrowserTravelWeb.Managers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelWeb.Controllers
{
    public class BooksController : Controller
    {
        IBookServices _serv;
        public BooksController(IBookServices service) {
            _serv = service;
        }
        // GET: BooksController
        public async Task<ActionResult> Index()
        {
            var data = await _serv.GetAll();
            if (data.Error)
            {
                return RedirectToAction("Error", "Home");

            }
            return View(data.Lst);
        }

        // GET: BooksController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var data = await _serv.GetDetails(id);
            if (data.Error)
            {
                return RedirectToAction("Error", "Home");

            }
            return View(data.UnitResp);
        }
    }
}
