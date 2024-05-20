using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using RESTFulSense.Models.Attributes;

namespace REST3DemoAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpCustom("CUSTOM")]
        public ActionResult<Student> Get() => Ok(new Student
        {
            Id = 1
        });
    }

    public class Student
    {
        public int Id { get; set; }
    }
}
