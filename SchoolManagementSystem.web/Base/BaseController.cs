using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.IServer;

namespace SchoolManagementSystem.web.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AnyOrigin")]
    [ApiController]
    public class BaseController : ControllerBase
    {
       
    }
}
