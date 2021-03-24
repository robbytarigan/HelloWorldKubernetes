using System;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        public DateTime Get()
        {
            return DateTime.UtcNow;
        }
    }
}
