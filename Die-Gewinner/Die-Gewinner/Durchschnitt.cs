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
        private string[] _lines;

        public Durchschnitt(string[] lines)
        {
            _lines = lines;
        }

        public void Main()
        {

            foreach (string messStelle in InputHelper.GetMesstellen())
            {
                List<string> liste = InputHelper.ReadData(_lines, messStelle);
                Console.WriteLine($"Messfühler {messStelle} hat eine Durchschnittstemperatur von: {Durchschnittt(liste):0.00}");
            }

            return;

            List<string> listS1 = InputHelper.ReadData(_lines, "S1");
            List<string> listS2 = InputHelper.ReadData(_lines, "S2");
            List<string> listS3 = InputHelper.ReadData(_lines, "S3");
            List<string> listS4 = InputHelper.ReadData(_lines, "S4");
            List<string> listSB = InputHelper.ReadData(_lines, "SB");
            List<string> listSD = InputHelper.ReadData(_lines, "SD");

            //for (int i = 0; i < _lines.Length; i++)
            //{
            //    if (_lines[i].Contains("S1"))
            //    {
            //        listS1.Add(_lines[i]);
            //    }
            //    if (_lines[i].Contains("S2"))
            //    {
            //        listS2.Add(_lines[i]);
            //    }
            //    if (_lines[i].Contains("S3"))
            //    {
            //        listS3.Add(_lines[i]);
            //    }
            //    if (_lines[i].Contains("S4"))
            //    {
            //        listS4.Add(_lines[i]);
            //    }
            //    if (_lines[i].Contains("SB"))
            //    {
            //        listSB.Add(_lines[i]);
            //    }
            //    if (_lines[i].Contains("SD"))
            //    {
            //        listSD.Add(_lines[i]);
            //    }

            //}
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

