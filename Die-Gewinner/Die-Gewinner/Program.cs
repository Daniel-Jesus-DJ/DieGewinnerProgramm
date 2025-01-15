using Die_Gewinner;

var data = File.ReadAllLines("../../../CSV/Input.csv");

MaxTemp maxTemp = new MaxTemp();
maxTemp.Lines = data;
maxTemp.Main();
Durchschnitt durchschnitt = new Durchschnitt(data);
durchschnitt.Main();
Hottest hottest = new Hottest();
hottest._lines = data;
hottest.Main();