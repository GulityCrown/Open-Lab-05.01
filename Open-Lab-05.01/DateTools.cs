using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Threading;


namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int mYear = year;
            int digits = 0;
            while (mYear > 0)
            {
                mYear = mYear / 10;
                digits++;
            }
            int century = 0;
            while (digits != 2)
            {
                mYear = year;
                if (digits < 2 && mYear > 0)
                {
                    mYear = 1;
                    break;
                }
                else if (digits > 2)
                {
                    mYear = mYear / 10;
                    digits--;
                }
                else
                {
                    mYear = 0;
                } 
            }
            if (digits == 2 && mYear * 10 !> 990)
            {
                mYear = mYear;
            }
            else if (digits == 2 && mYear * 100 %100 == 00)
            {
                mYear = mYear;
                
            }
            if (year % 100 == 0)
            {
                century = year / 100;
            }
            else
            {
                century = mYear / 10 + 1;
            }
            string s;
            if(century % 10 == 1 && century % 100 != 11) {
                
                 s = String.Format("{0}st century", century);
            }
            else if(century %10 == 2 && century % 100 != 12)
            {
                s = String.Format("{0}nd century", century); 
            }
            else if(century % 10 == 3 && century % 100 != 13) {
                s = String.Format("{0}rd century", century); 
            }
            else if (century >= 10)
            {
                s = String.Format("{0}th century", century);
            }
            else {
                s = String.Format("{0}th century", century); 
            }
            
            return s;
        }
    }
}
