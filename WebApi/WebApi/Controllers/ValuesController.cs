using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.AppDbContext;
using WebApi.Models;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AuthDbContext _context;

        public ValuesController(AuthDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> Index()
        {
            return _context.Students.ToList();
        }
    }
}
