using Subscribere_Core.Response;
using Subscribere_Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Interfaces
{
    public interface ICardRepository
    {
        Task<BaseResponseGeneral<SubscriptionDetailsResponse>> GetCardById(int id);
        Task<BaseResponseGeneral<CardTable>> CheckLogin(string password, string email);
        //Task<bool> IsEmailUnique(string email);
        //Task<BaseResponseGeneral<bool>> GetDetailsSubscriber(Subscriber subscriber);
        //Task<Subscriber> GetSubscriberByEmailAndPassword(string email, string password);
        //Task<Subscriber> GetSubscriberInfo(int cardId);
    }
}
