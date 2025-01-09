using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Gewinner
{
    public static class InputHelper
    {
        public static List<string> ReadData(string[] data, string contains)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains(contains))
                {
                    output.Add(data[i]);
                }
            }

            return output;
        }

        //todo: Löschen
        //public static List<string> ReadData(string[] data, string contains) => data.Where(x => x.Contains(contains)).ToList();

        public static string[] GetMesstellen() => ["S1", "S2", "S3", "S4", "SB", "SD"];
    }
}
