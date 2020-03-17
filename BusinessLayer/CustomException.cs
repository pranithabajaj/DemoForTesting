using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomException:Exception
    {
        public CustomException(string S) : base(S)
        {

        }
    }
}
