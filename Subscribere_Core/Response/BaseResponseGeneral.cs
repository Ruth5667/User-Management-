using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Response
{
    public class BaseResponseGeneral<T> : BaseResponse
    {
        public T Response { get; set; }
       
    }
}
