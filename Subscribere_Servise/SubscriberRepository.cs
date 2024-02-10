using Azure;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;
using Subscribere_Data;
using Subscribere_Data.models;

namespace Subscribere_Servise
{

    public class SubscriberRepository : ISubscriberRepository
    {
        readonly Weight_WatchersContext _SubscriberContext;
        public SubscriberRepository(Weight_WatchersContext subscriberContext)
        {
            _SubscriberContext = subscriberContext;
        }
          
        //public Task<BaseResponseGeneral<bool>> GetSubscriber(string firstName, string lastName, string email, string password)
        //{
        //    var existMail = _SubscriberContext.Subscriber.Where(s => s.Email == email).FirstOrDefault();
        //    Subscriber subscriber = new Subscriber(){ First_name = firstName, Last_name = lastName,Email = email,Password = password};
        //    if (Equals(existMail, null))
        //        return true;
        //}

        public Task<BaseResponseGeneral<bool>> GetSubscriber(Subscriber subscriber, double height)
        {
            throw new NotImplementedException();
        }

        //public Task<BaseResponseGeneral<bool>> GetSubscriber(Subscriber subscriber, double height)
        //{
        //    throw new NotImplementedException();
        //}
        //public Task<BaseResponseGeneral<bool>> GetSubscriber(string firstName, string lastName, string email, string password, double height)
        //{
        //   //var response = new BaseResponseGeneral<bool>();
        //   // var existMail = _SubscriberContext.Subscriber.Where(s => s.Email == email).FirstOrDefault().Id;
        //}
    }
}