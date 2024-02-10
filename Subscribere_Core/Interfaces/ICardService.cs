using Subscribere_Core.DTO;
using Subscribere_Core.Response;
using Subscribere_Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Interfaces
{
    public interface ICardService
    {
      public  Task<BaseResponseGeneral<SubscriptionDetailsResponse>> GetCardById(int id);
       public Task<BaseResponseGeneral<CardDto>> CheckLogin(string password, string email);
    }
}
