using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Response
{
    public class BaseResponse
    {
        public bool Succssed { get; set; }
        public string Massage { get; set; }

        public BaseResponse()
        {
            Succssed = false;
        }
     
    }
}
