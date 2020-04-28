using System;
using System.Collections.Generic;
using System.Text;

namespace NoveritsPharamsLimited
{
    class Date
    {
        private int day;
        private int month;
        private int Year { get; set; }

        public Date(int theDay, int theMonth, int theYear)
        {
            Day = theDay;
            Month = theMonth;
            Year = theYear;
           
        }

        public int Month
        {
            get { return month; }
          private  set
            {
                if ((value > 0) && (value <= 12))
                {

                    month = value;
                  
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Out of range");
                }
            }
        }




        public int Day
        {
            get { return day; }
           private set
            {
                if (value > 0 && value <= 31)
                {
                    day = value;

                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Out of range");
                }
                /*
                if((Day >=1 && Day <=31) && (Month == 1 || Month == 2 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10|| Month == 12))
                {
                    day = value;
                }else if ((Day >= 1 && Day <= 30) && (Month == 4 || Month == 6 || Month == 9 || Month == 11))
                {
                    day = value;
                }else if (Day == 29 && Month == 2 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 !=0))) 
                {
                    day = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Out of range");
                }
                */


            }

        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
