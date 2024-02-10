using Subscribere_Core.DTO;
using Subscribere_Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Interfaces
{
    public interface ISubscriberService
    {
       public Task<BaseResponseGeneral<bool>> GetSubscriber(SubscriberDto subscriberDTO, double height);

    }
}
