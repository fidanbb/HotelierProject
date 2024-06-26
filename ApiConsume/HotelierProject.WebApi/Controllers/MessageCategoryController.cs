using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.MessageCategoryDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;
        private readonly IMapper _mapper;

        public MessageCategoryController(IMessageCategoryService messageCategoryService, IMapper mapper)
        {
            _messageCategoryService = messageCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> MessageCategoryList()
        {
            return Ok(_mapper.Map<List<ResultMessageCategoryDto>>(await _messageCategoryService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddMessageCategory(CreateMessageCategoryDto createMessageCategoryDto)
        {
         
            var value = _mapper.Map<MessageCategory>(createMessageCategoryDto);

            await _messageCategoryService.TInsert(value);

            return Ok("MessageCategory added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteMessageCategory(int id)
        {
            var value = await _messageCategoryService.TGetByID(id);

            await _messageCategoryService.TDelete(value);

            return Ok("MessageCategory deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessageCategory(UpdateMessageCategoryDto updateMessageCategoryDto)
        {
            var value = _mapper.Map<MessageCategory>(updateMessageCategoryDto);

            await _messageCategoryService.TUpdate(value);

            return Ok("MessageCategory updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetMessageCategory(int id)
        {
            return Ok(_mapper.Map<GetMessageCategoryDto>(await _messageCategoryService.TGetByID(id)));
        }
    }
}
