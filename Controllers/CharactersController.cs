using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TibiaApi.Data;
using TibiaApi.Models;
using TibiaApi.Utils;


namespace TibiaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        //declarate database reference
        private readonly DataContext _context;
        public CharactersController(DataContext context){
            _context = context;
        }
        //end
    }
}