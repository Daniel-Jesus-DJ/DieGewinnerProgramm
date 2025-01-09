//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Die_Gewinner
//{
//    internal class Hottest
//    {
//        public string[] _lines;

//        public Hottest()
//        {
//        }

//        public void Main()
//        {

//            List<string> listS1 = new();
//            //List<string> listS2 = new();
//            //List<string> listS3 = new();
//            //List<string> listS4 = new();
//            //List<string> listSB = new();
//            //List<string> listSD = new();
//            for (int i = 0; i < _lines.Length; i++)
//            {
//                listS1.Clear();
//                for (int j = 2021; j <= 2037; j++)
//                {
//                    listS1.Add(_lines[i]);
//                }
//                Durchschnittt(listS1);
//                Console.WriteLine(j + " war der Hitze-Jahresdurchschnitt: " + z);
//                Console.WriteLine();
//            }

//            Console.WriteLine("Das heißeste Jahr ist somit: " + y);





//        //        if (_lines[i].Contains("2021")) 
//        //        {
//        //            listS1.Add(_lines[i]);
//        //        }
//        //        if (_lines[i].Contains("2022"))
//        //        {
//        //            listS2.Add(_lines[i]);
//        //        }
//        //        if (_lines[i].Contains("S3"))
//        //        {
//        //            listS3.Add(_lines[i]);
//        //        }
//        //        if (_lines[i].Contains("S4"))
//        //        {
//        //            listS4.Add(_lines[i]);
//        //        }
//        //        if (_lines[i].Contains("SB"))
//        //        {
//        //            listSB.Add(_lines[i]);
//        //        }
//        //        if (_lines[i].Contains("SD"))
//        //        {
//        //            listSD.Add(_lines[i]);
//        //        }

//        //    }
//        //    Console.WriteLine();
//        //    Console.WriteLine();
//        //    Console.WriteLine($"Messfühler SD hat eine Durchschnittstemperatur von: {Durchschnittt(listSD):0.00}");
//        //    Console.WriteLine($"Messfühler SB hat eine Durchschnittstemperatur von: {Durchschnittt(listSB):0.00}");
//        //    Console.WriteLine($"Messfühler S4 hat eine Durchschnittstemperatur von: {Durchschnittt(listS4):0.00}");
//        //    Console.WriteLine($"Messfühler S3 hat eine Durchschnittstemperatur von: {Durchschnittt(listS3):0.00}");
//        //    Console.WriteLine($"Messfühler S2 hat eine Durchschnittstemperatur von: {Durchschnittt(listS2):0.00}");
//        //    Console.WriteLine($"Messfühler S1 hat eine Durchschnittstemperatur von: {Durchschnittt(listS1):0.00}");
//        //}

//        static double Durchschnittt(List<string> list)
//        {
//            double list2 = 0;
//            for (int i = 0; i < list.Count; i++)
//            {
//                int index = list[i].LastIndexOf(",");
//                string list1 = list[i].Substring(index + 1);
//                list2 += double.Parse(list1, CultureInfo.InvariantCulture.NumberFormat);


//                list1 = "";
//            }
//            double result = Math.Round(list2, 2);
//            return result / list.Count;
//        }
//    }
//}

