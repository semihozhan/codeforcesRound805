using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeforcesRound805
{
    public static class NotCheapString
    {
        public static Dictionary<int, string> queries = FulledDictionary();


        /// <summary>
        /// Not a Cheap String
        /// </summary>
        /// <param name="letter">codeforces</param>
        /// <param name="values">10</param>
        /// <returns>cdc</returns>
        public static string NotCheapStringQueries(string letter,int values)
        {
            
            string res = "";
            modelResult modelResult = new modelResult();    

            for (int i = 0; i < letter.Length; i++)
            {
                modelResult = Calc(i, letter, values);
                if (modelResult.count==0) continue;
                if (modelResult.count == values) return modelResult.values;
            }
            return res;
        }


        public static modelResult Calc(int j,string letter,int stoppedCount)
        {
            modelResult modelResult = new modelResult();
            modelResult.count = 0;
            for (int i = j; i < letter.Length; i++)
            {
                int counts = queries.Where(x => x.Value.ToLower() == letter[i].ToString().ToLower()).Select(x => x.Key).FirstOrDefault();
                
                if (counts + modelResult.count < stoppedCount) {
                    modelResult.count = modelResult.count+ counts;
                    modelResult.values += letter[i].ToString();
                    continue;
                }else if (counts + modelResult.count == stoppedCount)
                {
                    modelResult.count += counts;
                    modelResult.values += letter[i].ToString();
                    return modelResult;
                }
                else
                {
                    continue;
                }   
                
            }
            return modelResult;
        }


        public static Dictionary<int, string> FulledDictionary()
        {
            Dictionary<int, string> queries = new Dictionary<int, string>();
            queries.Add(1, "A");
            queries.Add(2, "B");
            queries.Add(3, "C");
            queries.Add(4, "D");
            queries.Add(5, "E");
            queries.Add(6, "F");
            queries.Add(7, "G");
            queries.Add(8, "H");
            queries.Add(9, "I");
            queries.Add(10, "J");
            queries.Add(11, "K");
            queries.Add(12, "L");
            queries.Add(13, "M");
            queries.Add(14, "N");
            queries.Add(15, "O");
            queries.Add(16, "P");
            queries.Add(17, "Q");
            queries.Add(18, "R");
            queries.Add(19, "S");
            queries.Add(20, "T");
            queries.Add(21, "U");
            queries.Add(22, "V");
            queries.Add(23, "W");
            queries.Add(24, "X");
            queries.Add(25, "Y");
            queries.Add(26, "Z");
            return queries;
        }


    }

    public class modelResult
    {
        public int count { get; set; }
        public string values { get; set; }
    }
}

