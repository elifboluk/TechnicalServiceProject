using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceProject.Web.Controllers.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestApiController : BaseApiController
    {
        private readonly IMapper _mapper;
    }
}
