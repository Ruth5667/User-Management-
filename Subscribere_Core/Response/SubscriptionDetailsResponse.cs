using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Core.Response
{
    public class SubscriptionDetailsResponse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double BMI { get; set; } = 0;

        public double Height { get; set; }

        public double Weight { get; set; }

    }
}
