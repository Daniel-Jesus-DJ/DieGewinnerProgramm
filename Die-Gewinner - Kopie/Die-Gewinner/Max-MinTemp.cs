using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Gewinner
{
    internal class MaxTemp
    {
        public string[] Lines;

        public MaxTemp()
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
            Console.WriteLine("Messfühler SD hat eine MaxTemp von: " + MaxMinTemp(listSD));
            List<string> SD = Datum(listSD);
            Console.WriteLine("Die MaxTemp  wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < SD.Count; i++)
            {
                Console.Write(SD[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler SB hat eine MaxTemp von: " + MaxMinTemp(listSB));
            List<string> SB = Datum(listSB);
            Console.WriteLine("Die MaxTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < SD.Count; i++)
            {
                Console.Write(SD[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S4 hat eine MaxTemp von: " + MaxMinTemp(listS4));
            List<string> S4 = Datum(listS4);
            Console.WriteLine("Die MaxTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < S4.Count; i++)
            {
                Console.Write(S4[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S3 hat eine MaxTemp von: " + MaxMinTemp(listS3));
            List<string> S3 = Datum(listS3);
            Console.WriteLine("Die MaxTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < S3.Count; i++)
            {
                Console.Write(S3[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S2 hat eine MaxTemp von: " + MaxMinTemp(listS2));
            List<string> S2 = Datum(listS2);
            Console.WriteLine("Die MaxTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < S2.Count; i++)
            {
                Console.Write(S2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S1 hat eine MaxTemp von: " + MaxMinTemp(listS1));
            List<string> S1 = Datum(listS1);
            Console.WriteLine("Die MaxTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < S1.Count; i++)
            {
                Console.Write(S1[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Messfühler SD hat eine MinTemp von: " + MinMaxTemp(listSD));
            List<string> MinSD = Datum(listSD);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < MinSD.Count; i++)
            {
                Console.Write(MinSD[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler SB hat eine MinTemp von: " + MinMaxTemp(listSB));
            List<string> MinSB = Datum(listSD);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < MinSB.Count; i++)
            {
                Console.Write(MinSB[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S4 hat eine MinTemp von: " + MinMaxTemp(listS4));
            List<string> arr = Datum(listSD);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S3 hat eine MinTemp von: " + MinMaxTemp(listS3));
            List<string> MinS3 = Datum(listS3);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < MinS3.Count; i++)
            {
                Console.Write(MinS3[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S2 hat eine MinTemp von: " + MinMaxTemp(listS2));
            List<string> MinS2 = Datum(listS2);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < MinS2.Count; i++)
            {
                Console.Write(MinS2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Messfühler S1 hat eine MinTemp von: " + MinMaxTemp(listS1));
            List<string> MinS1 = Datum(listS1);
            Console.WriteLine("Die MinTemp wurde an folgenden Daten erreicht: ");
            for (int i = 0; i < MinS1.Count; i++)
            {
                Console.Write(MinS1[i] + ", ");
            }
            Console.WriteLine();
        }

        static double MaxMinTemp(List<string> list)
        {
            double result = 0;
            double list2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int index = list[i].LastIndexOf(",");
                string list1 = list[i].Substring(index + 1);
                double zwischenergebnis = double.Parse(list1, CultureInfo.InvariantCulture.NumberFormat);
                if (zwischenergebnis > result)
                {
                    result = zwischenergebnis;
                }
            }
            return result;
        }

        static double MinMaxTemp(List<string> list)
        {
            double result = 0;
            double list2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int index = list[i].LastIndexOf(",");
                string list1 = list[i].Substring(index + 1);
                double zwischenergebnis = double.Parse(list1, CultureInfo.InvariantCulture.NumberFormat);
                if (i == 0)
                {
                    result = zwischenergebnis;
                }
                if (zwischenergebnis < result)
                {
                    result = zwischenergebnis;
                }
            }
            return result;
        }

        static List<string> Datum(List<string> list)
        {

            List<string> result = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                int index = list[i].LastIndexOf(",");
                string list1 = list[i].Substring(index + 1);
                double zwischenergebnis = double.Parse(list1, CultureInfo.InvariantCulture.NumberFormat);

                if (zwischenergebnis == 30)
                {
                    int indexWhite = list[i].IndexOf(" ");
                    string delete = list[i].Remove(indexWhite);
                    int indexDelimiter = delete.IndexOf(",");
                    string sub = delete.Substring(indexDelimiter + 1);
                    result.Add(sub);
                }

                if (zwischenergebnis == 65)
                {
                    int indexWhite = list[i].IndexOf(" ");
                    string delete = list[i].Remove(indexWhite);
                    int indexDelimiter = delete.IndexOf(",");
                    string sub = delete.Substring(indexDelimiter + 1);
                    result.Add(sub);
                }
            }
            return result;
        }
    }
}
