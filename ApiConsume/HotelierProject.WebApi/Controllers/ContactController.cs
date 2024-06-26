using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.ContactDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            return Ok(_mapper.Map<List<ResultContactDto>>(await _contactService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddContact(CreateContactDto createContactDto)
        {
           
            var value = _mapper.Map<Contact>(createContactDto);

            value.Date=Convert.ToDateTime(DateTime.Now.ToString());

            await _contactService.TInsert(value);

            return Ok("Contact added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteContact(int id)
        {
            var value = await _contactService.TGetByID(id);

            await _contactService.TDelete(value);

            return Ok("Contact deleted successfully");
        }

        //[HttpPut]
        //public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        //{
         
        //    var value = _mapper.Map<Contact>(updateContactDto);

        //    await _contactService.TUpdate(value);

        //    return Ok("Contact updated successfully");
        //}

        [HttpGet("{id}")]

        public async Task<IActionResult> GetContact(int id)
        {
            return Ok(_mapper.Map<GetContactDto>(await _contactService.TGetByID(id)));
        }

        [HttpGet("GetContactCount")]

        public async Task<IActionResult> GetContactCount()
        {
            return Ok(await _contactService.TGetCountCount());
        }

    }
}
