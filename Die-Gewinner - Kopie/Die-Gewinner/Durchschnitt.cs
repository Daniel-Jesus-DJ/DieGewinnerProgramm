using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Gewinner
{
    internal class Durchschnitt
    {
        public string[] Lines;

        public Durchschnitt()
        {
        }

        public void Main()
        {

            List<string> listS1 = new();
            List<string> listS2 = new();
            List<string> listS3 = new();
            List<string> listS4 = new();
            List<string> listSB = new();
            List<string> listSD = new();
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i].Contains("S1"))
                {
                    listS1.Add(Lines[i]);
                }
                if (Lines[i].Contains("S2"))
                {
                    listS2.Add(Lines[i]);
                }
                if (Lines[i].Contains("S3"))
                {
                    listS3.Add(Lines[i]);
                }
                if (Lines[i].Contains("S4"))
                {
                    listS4.Add(Lines[i]);
                }
                if (Lines[i].Contains("SB"))
                {
                    listSB.Add(Lines[i]);
                }
                if (Lines[i].Contains("SD"))
                {
                    listSD.Add(Lines[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Messfühler SD hat eine Durchschnittstemperatur von: {Durchschnittt(listSD):0.00}");
            Console.WriteLine($"Messfühler SB hat eine Durchschnittstemperatur von: {Durchschnittt(listSB):0.00}");
            Console.WriteLine($"Messfühler S4 hat eine Durchschnittstemperatur von: {Durchschnittt(listS4):0.00}");
            Console.WriteLine($"Messfühler S3 hat eine Durchschnittstemperatur von: {Durchschnittt(listS3):0.00}");
            Console.WriteLine($"Messfühler S2 hat eine Durchschnittstemperatur von: {Durchschnittt(listS2):0.00}");
            Console.WriteLine($"Messfühler S1 hat eine Durchschnittstemperatur von: {Durchschnittt(listS1):0.00}");
        }

        static double Durchschnittt(List<string> list)
        {
            double list2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int index = list[i].LastIndexOf(",");
                string list1 = list[i].Substring(index + 1);
                list2 += double.Parse(list1, CultureInfo.InvariantCulture.NumberFormat);


                list1 = "";
            }
            double result = Math.Round(list2, 2);
            return result / list.Count;
        }
    }
}

