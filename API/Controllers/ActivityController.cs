using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Design;                  
namespace API.Controllers
{
    public class ActivityController: BaseApiController
    {
         private readonly DataContext _context;
        public ActivityController(DataContext context){
                 _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){

         return await _context.Activities.ToListAsync();
        }
      

  
    
}
}
