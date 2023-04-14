using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrants
{
    public class Validator
    {
        public static bool IsName(string n)
        {

            if (!String.IsNullOrWhiteSpace(n) && n.Length > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        


    }
}
