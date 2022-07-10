using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeforcesRound805
{
    /// <summary>
    /// Round Down the Price
    /// </summary>
    public static class codeforces
    {
        /// <summary>
        /// 178−78=10^2
        /// </summary>
        /// <param name="price">178</param>
        /// <returns>72</returns>
        public static int RoundDownthePrice(int price)
        {
            int value = 10;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Math.Pow(value, i) > price)
                {
                    count = i;
                    break;
                }
            }
            return price-Convert.ToInt32(Math.Pow(value, count-1));
        }
    }
}
