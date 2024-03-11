using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.DTOs.ContactDTO;
using RealEstate.Repositories.ContactRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Last4MessagesList()
        {
            var values = await _contactRepository.GetLast4Messages();
            return Ok(values);
        }

        //[HttpGet]
        //public async Task<IActionResult> ContactList()
        //{
        //    var values = await _contactRepository.GetAllContactAsync();
        //    return Ok(values);
        //}


        //[HttpPost]
        //public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        //{
        //    _contactRepository.CreateContact(createContactDto);
        //    return Ok("New data has been added successfully");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteContact(int id)
        //{
        //    _contactRepository.DeleteContact(id);
        //    return Ok("Data has been deleted successfully");
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetByIdContact(int id)
        //{
        //    var values = await _contactRepository.GetByIdContact(id);
        //    return Ok(values);
        //}
    }
}
