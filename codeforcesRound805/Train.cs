using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeforcesRound805
{
    public static class Train
    {
        /// <summary>
        /// Train and Queries
        /// </summary>
        /// <param name="route">2 1 1 1 2 4 4</param>
        /// <param name="query">1 3</param>
        /// <returns>NO</returns>
        public static string TrainandQueries(string route,string query)
        {
            string[] splitRoute = route.Split(" ");
            string[] splitQuery = query.Split(" ");

            bool returnValue = splitRoute.Any(x => x.Contains(splitQuery[0]) && x.Contains(splitQuery[1]));

            return returnValue ? "YES" : "NO";
        }
    }
}