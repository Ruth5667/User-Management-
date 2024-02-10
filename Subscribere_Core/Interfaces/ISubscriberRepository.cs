using Subscribere_Core.Response;
using Subscribere_Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Interfaces
{
    public interface ISubscriberRepository
    {
        public Task<BaseResponseGeneral<bool>> GetSubscriber(Subscriber subscriber, double height);


    }
}
