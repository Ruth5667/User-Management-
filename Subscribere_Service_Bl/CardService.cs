using Subscribere_Core.DTO;
using Subscribere_Core.Interfaces;
using Subscribere_Core.Response;
using Subscribere_Data;
using Subscribere_Data.models;
using Subscribere_Servise_Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Service_Bl
{
    public class CardService :ICardService
    {
        readonly ICardRepository _Card;
        public CardService(ICardRepository cardRepository)  // Update the parameter name
        {
            _Card = cardRepository;
        }
        #region Login
        public async Task<BaseResponseGeneral<CardTable>> CheckLogin(string password, string email)
        {
            if (_Card.CheckLogin(password, email) == null)
                throw new Exception("Its null");
            return await _Card.CheckLogin(password, email);
        }
        #endregion
        #region GetById
        public async Task<BaseResponseGeneral<SubscriptionDetailsResponse>> GetCardById(int id)
        {
            var response = await _Card.GetCardById(id);
            if (response == null)
                throw new Exception("401 -- Error: id doesnt exist!");
            return response;
        }

        Task<BaseResponseGeneral<CardDto>> ICardService.CheckLogin(string password, string email)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
