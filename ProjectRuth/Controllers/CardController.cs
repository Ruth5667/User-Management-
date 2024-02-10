using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Subscribere_Core.DTO;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;
using Subscribere_Data.models;

namespace ProjectRuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        readonly ICardService _cardService;
        readonly IMapper _mapper;

        public CardController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }
        #region GetById
        [HttpGet]
        [Route("GetCardById/{id}")]
        public async Task<ActionResult<BaseResponseGeneral<SubscriptionDetailsResponse>>> GetCardById([FromRoute] int id)
        {
            var response = await _cardService.GetCardById(id);
            if (response.Succssed == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        #endregion
        #region PostLogin
        [HttpPost("/Login")]
        public async Task<ActionResult<BaseResponseGeneral<CardDto>>> CheckLogin([FromBody] string email, string password)
        {
            //BaseResponseGeneral<CardTable> card = await _cardService.CheckLogin(loginDTO.Password,loginDTO.Email);
           
               var response= await _cardService.CheckLogin(password, email);
            if (response.Succssed == false)
            {
                return NotFound(response);
            }
            return Ok(response);
            //return _mapper.Map<BaseResponseGeneral<CardDto>>(card);
        }
  
        #endregion
    }
}
