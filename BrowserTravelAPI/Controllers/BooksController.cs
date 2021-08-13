using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrowserTravelAPI.Data.Entities;
using BrowserTravelAPI.Services;

namespace BrowserTravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BrowserTravelDbcontext _context;

        public BooksController(BrowserTravelDbcontext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.SingleOrDefaultAsync(i => i.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
    }
}
