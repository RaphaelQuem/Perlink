using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosFelizesSortudos
{
    public static class Extension
    {
        public static bool isHappy(this int n)
        {
            for(int i =0;i<100;i++)
            {
                List<int> digits = n.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
                double squared = 0D;


                foreach (int digit in digits)
                {
                    squared += Math.Pow(digit, 2D);
                }

                if (squared.Equals(1D))
                {
                    return true;
                }
                   

                n = (int)squared;
            }
            return false;
        }
        public static bool isLucky(this int n)
        {

            List<int> luckyNumbers = Extension.GetintRange(1,n);
            
            for(int i=0; i<n;i++)
            {
                if (i.Equals(luckyNumbers.Count))
                    break;
                int mult = 0;
                if (i.Equals(0))
                    mult = 2;
                else
                    mult = luckyNumbers[i];


                List<int> unluckyNumbers = luckyNumbers.ExtractMultipleRange(mult);

                luckyNumbers = luckyNumbers.Where(x => !unluckyNumbers.Contains(x)).ToList();

            }

            if (luckyNumbers.Contains(n))
                return true;

            return false;
        }

        public static List<int> ExtractMultipleRange(this List<int> lst, int div)
        {
            List<int> ret = new List<int>();

            for (int i = 0; i < lst.Count; i++)
            {
                if (((i + 1) % div).Equals(0))
                    ret.Add(lst[i]);
            }

            return ret;
        }

        public static List<int> GetintRange(int start, int end)
        {
            List<int> ret = new List<int>();
            for(int i=start;i<=end;i++)
            {
                ret.Add(i);
            }

            return ret;
        }



    }
}
