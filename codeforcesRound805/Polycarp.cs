using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeforcesRound805
{
    /// <summary>
    /// Polycarp Writes a String from Memory
    /// </summary>
    public static class Polycarp
    {
        /// <summary>
        /// Polycarp Writes a String from Memory
        /// </summary>
        /// <param name="val">lollipops</param>
        /// <returns>2</returns>
        public static int PolycarpMemory(string val)
        {
            int count = 0;
            int returnCount = 0;
            char[] valCharArray = val.ToCharArray();
            //valCharArray= valCharArray.Distinct().ToArray();
            List<string> memory = new List<string>();


            for (int i = 0; i < valCharArray.Length; i++)
            {
                if (!memory.Contains(valCharArray[i].ToString()))
                {
                    memory.Add(valCharArray[i].ToString());
                    count += 1;
                }
                if (count == 3)
                {
                    returnCount++;
                    count = 0;
                }
            }
            return returnCount;
        }
    }
}
