using Subscribere_Core.DTO;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;

namespace Subscribere_Service_Bl
{
    public class SubscriberService : ISubscriberService
    {
        readonly ISubscriberRepository _Subscriber;
        public SubscriberService(ISubscriberRepository subscriber)
        {
            _Subscriber = subscriber;
        }

        public Task<BaseResponseGeneral<bool>> GetSubscriber(SubscriberDto subscriberDTO, double height)
        {
            throw new NotImplementedException();
        }

        //Task<bool> ISubscriberService.GetSubscriber(string firstName, string lastName, string email, string password, double height)
        //{
        //    throw new NotImplementedException();
        //}
    }
}