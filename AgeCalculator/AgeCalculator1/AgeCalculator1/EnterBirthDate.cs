using System;
using System.Collections.Generic;
using System.Text;

namespace AgeCalculator1
{
    class EnterBirthDate
    {
        public DateTime inputDate;
        public void InputBirthDate()
        {
            Console.WriteLine("Pleas input date of birth. (DD/MM/YYYY) ");
            inputDate = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
