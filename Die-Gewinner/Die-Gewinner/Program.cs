using Die_Gewinner;


var data = File.ReadAllLines("Input.csv");

MaxTemp maxTemp = new MaxTemp();
maxTemp.Lines = data;
maxTemp.Main();
Durchschnitt durchschnitt = new Durchschnitt(data);
durchschnitt.Main();
//Hottest hottest = new Hottest();
//hottest._lines = File.ReadAllLines("D:\\Schule\\Jahr 1\\Herr Baldes\\VS Zeugs\\Die-Gewinner\\Die-Gewinner\\Die-Gewinner\\Input.csv");
//hottest.Main();