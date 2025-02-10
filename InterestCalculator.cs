using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management
{
    public static class InterestCalculator
    {
        public static int CreditRatingThreshold = 20;
        public static int MaximumLoadValue = 10000;
        public static float CalculateInterestRate(int creditRating, int duration)
        {
            if(creditRating < 20) 
            {
                return -1;
            }
            else if(creditRating >= 20 && creditRating < 50)
            {
                switch (duration)
                {
                    case 1:
                        return 20;
                    case 3:
                        return 15;
                    case 5:
                        return 10;
                    default:
                        return -1;
                }
            }
            else
            {
                switch (duration)
                {
                    case 1:
                        return 12;
                    case 2:
                        return 8;
                    case 3:
                        return 5;
                    default:
                        return -1;
                }
            }
        }
    }
}
