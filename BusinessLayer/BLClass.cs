using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLClass
    {
        public int Divide(string Numerator,string Denominator)
        {
            int r = 0, r1 = 0;
            bool n = int.TryParse(Numerator,out r);
            bool n1 = int.TryParse(Denominator, out r1);
            if (n && n1)
            {
                if (r1 != 0)
                    return r / r1;
                else
                    throw new DivideByZeroException("Cannot divide by zero");
            }
            else
                throw new FormatException("Only Numbers");
        }
        public string Age(DateTime Dob)
        {
            int age=(int)DateTime.Now.Subtract(Dob).TotalDays/365;
            if (age <= 16)
                throw new CustomException("Age should be greater than 16");
            else if (age >= 60)
                throw new CustomException("Age should be less than 60");
            else
                return age.ToString();


        }

    }
}
