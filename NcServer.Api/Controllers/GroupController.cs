using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NcServer.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NcServer.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class GroupController : ControllerBase
    {

        private ApplicationDbContext _dbContext;
        public GroupController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
