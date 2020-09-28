using System;
using System.Collections.Generic;
using System.Text;

namespace AgeCalculator1
{
    class AgeCalc
    {
        public DateTime current;
        public DateTime birth;

        int AgeYear = 0;
        int AgeMonth = 0;
        int AgeDay = 0;



        public AgeCalc(DateTime Current, DateTime Birth)
        {
            current = Current;
            birth = Birth;
            AgeYear = Current.Year - Birth.Year;
            AgeMonth = Current.Month - Birth.Month;
            AgeDay = Current.Day - Birth.Day;
            if ( AgeMonth == 0)
            {
                if(AgeDay == 0)
                {
                    AgeYear++;
                }
            }

        }


        public static void Calculating()
        {

        }
    }
}
