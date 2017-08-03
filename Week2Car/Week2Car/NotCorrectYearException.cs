//Exception class for choosing the incorrect year


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Car
{
    class NotCorrectYearException : Exception
    {

    public NotCorrectYearException()
            

        : base("Please enter the correct year")
        {
            
        }
    }
}
