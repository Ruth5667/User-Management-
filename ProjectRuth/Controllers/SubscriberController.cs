using Microsoft.AspNetCore.Mvc;
using Subscribere_Core.DTO;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;

namespace ProjectRuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriberController : ControllerBase
    {
        readonly ISubscriberService _subscriberService;
        public SubscriberController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }
        //[HttpPost]
        //public async Task<ActionResult<BaseResponseGeneral<bool>>> GetSubscriber([FromBody] SubscriberDto subscriber, double height)
        //{
        //    var response = await _subscriberService.GetSubscriber(subscriber, height);
        //    if (response.Succeeded == false)
        //    {
        //        return NotFound(response);
        //    }
        //    return Ok(response);

        //    return await _subscriberService.GetSubscriber(subscriber.FirstName, subscriber.LastName, subscriber.Email, subscriber.Password,);
        //}



    }
    
}
