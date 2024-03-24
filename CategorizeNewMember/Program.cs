using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNewMember
{
    internal class Program
    {
        public static List<string> OpenOrSenior(int[][] data)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && data[i][1] > 7)
                {
                    result.Add("Senior");
                }
                else
                {
                    result.Add("Open");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[][] data = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
            List<string> result = OpenOrSenior(data);
        }
    }
}

/*public class Kata           //крутое решение чела
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data.Select(x => x[0] >= 55 && x[1] > 7 ? "Senior" : "Open");
    }
}*/