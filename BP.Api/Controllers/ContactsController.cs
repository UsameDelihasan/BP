using BP.Api.Models;
using BP.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IContactService _contactService;

        public ContactsController(IConfiguration configuration,IContactService contactService)
        {
            _configuration = configuration;
            _contactService = contactService;
        }


        [HttpGet]

        public string get()
        {
            return _configuration["ReadMe"].ToString();
        }

        [HttpGet("{Id}")]

        public ContactDVO GetContactDVOById(int id)
        {
            return _contactService.GetContactDVOById(id);
        }
    }
}
