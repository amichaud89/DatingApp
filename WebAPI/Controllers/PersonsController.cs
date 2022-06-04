using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
   [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly DataContext _context;
        public PersonsController(DataContext context)
        {
            _context = context;
        }



        [HttpGet]

        public ActionResult<IEnumerable<Persons>> GetUsers()
        {
            var persons =  _context.Persons.ToList();
            return persons;
        }

        [HttpGet("{email}")]

        public ActionResult<Persons> GetUser(string email)
        {
            var person = _context.Persons.Find(email);
            return person;
        }
    }
}
