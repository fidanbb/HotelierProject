using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.SendMessageDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService sendMessageService, IMapper mapper)
        {
            _sendMessageService = sendMessageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SendMessageList()
        {
            return Ok(_mapper.Map<List<ResultSendMessageDto>>(await _sendMessageService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddSendMessage(CreateSendMessageDto createSendMessageDto)
        {
          
            var value = _mapper.Map<SendMessage>(createSendMessageDto);

            await _sendMessageService.TInsert(value);

            return Ok("SendMessage added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteSendMessage(int id)
        {
            var value = await _sendMessageService.TGetByID(id);

            await _sendMessageService.TDelete(value);

            return Ok("SendMessage deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSendMessage(SendMessage value)
        {
         
            await _sendMessageService.TUpdate(value);

            return Ok("SendMessage updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetSendMessage(int id)
        {
            return Ok(_mapper.Map<GetSendMessageDto>(await _sendMessageService.TGetByID(id)));
        }

        [HttpGet("GetSendMessageCount")]

        public async Task<IActionResult> GetSendMessageCount()
        {
            return Ok(await _sendMessageService.TGetSendMessageCount());
        }
    }
}
