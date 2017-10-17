using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApplication
{
    public static class Utility
    {
        public static string convertDecimal(decimal amt)
        {
            return amt.ToString("#.00");
        }
    }
}
