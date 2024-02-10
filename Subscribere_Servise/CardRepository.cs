using Microsoft.EntityFrameworkCore;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;
using Subscribere_Data;
using Subscribere_Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Servise_Dal
{
    public class CardRepository : ICardRepository
    {
        readonly Weight_WatchersContext _CardContext;
        public CardRepository(Weight_WatchersContext CardContext)
        {
            _CardContext = CardContext;
        }
        #region /login
        public async Task<BaseResponseGeneral<CardTable>> CheckLogin(string password, string email)
        {
            try
            {
                Subscriber subscriber = _CardContext.Subscriber.Where(s => s.Password == password && s.Email == email).FirstOrDefault();
                BaseResponseGeneral<CardTable> response = new BaseResponseGeneral<CardTable>();
                response.Response = _CardContext.CardTable.Where(c => c.Id == subscriber.Id).FirstOrDefault();
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:code 401 ");
            }
        }

        #endregion
        #region GetById

        public async Task<BaseResponseGeneral<SubscriptionDetailsResponse>> GetCardById(int id)
        {
            try
            {
                Subscriber subscriber = _CardContext.Subscriber.Where(s => s.Id == id).FirstOrDefault();
                CardTable cardTable = _CardContext.CardTable.Where(c => c.Id == id).FirstOrDefault();
                BaseResponseGeneral<SubscriptionDetailsResponse> res = new BaseResponseGeneral<SubscriptionDetailsResponse>();
                if (subscriber != null && cardTable != null)
                {
                    res.Succssed = true;
                    res.Response = new SubscriptionDetailsResponse();
                    res.Response.FirstName = subscriber.First_name;
                    res.Response.LastName = subscriber.Last_name;
                    res.Response.Weight = cardTable.Weight;
                    res.Response.Height = cardTable.Height;
                    res.Response.BMI = cardTable.BMI;
                    return res;

                }
                else
                {
                    res.Succssed = false;
                    throw new Exception("error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: id doesnt exist");
            }
        }
        #endregion

    }
}
