using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09Program01
{
    class clsDates
    {
        //Symbolic constanst
        //static members
        private static int[] daysIntMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //instance members (Properties)
        private int day;
        private int month;
        private int year;
        private int leapYear; //ano bisexto

        private DateTime current;

        //constructor(s)
        public clsDates()
        {
            current = DateTime.Now; //Sets DateTime to right now
        }

        //property methods
        //helper methods
        //general methods

        public int getLeapYear(int year)
        {
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return 1;
            }
            return 0;
        }

        public string getEaster(int year)
        {
            int offset;
            int leap;
            int day;
            int temp1;
            int temp2;
            int total;

            offset = year % 19;
            leap = year % 4;
            day = year % 7;
            temp1 = (19 * offset + 24) % 30;
            temp2 = (2 * leap + 4 * day + 6 * temp1 + 5) % 7;
            total = (22 + temp1 + temp2);
            if(total > 31)
            {
                month = 4; //Easter is in April
                day = total - 31; //...on this day
            }
            else
            {
                month = 3; //Easter is in March
                day = total; //...on this day
            }

            DateTime myDT = new DateTime(year, month, day);
            return myDT.ToLongDateString();
        }

    }
}
