using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceProject.Web.Controllers.Apis
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

    }
}
