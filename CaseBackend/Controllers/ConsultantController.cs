using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ConsultantController : Controller
    {
        private readonly ConsultantContex _context;

        public ConsultantController(ConsultantContex context)
        {
            _context = context;

            if (!_context.Consultants.Any())
            {
                _context.Consultants.Add(new Consultant
                {
                    Name = "Linus Back",
                    Age = 30,
                    Email = "linus.a.back@gmail.com"
                });
                _context.SaveChanges();
            }
            
        }

        [HttpGet]
        public IEnumerable<Consultant> GetAll()
        {
            return _context.Consultants.ToList();
        }

        [HttpGet("{id}", Name = "GetConsultant")]
        public IActionResult GetById(long id)
        {
            var item = _context.Consultants.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }


    }
}