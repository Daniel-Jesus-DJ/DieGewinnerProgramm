using Die_Gewinner;


var data = File.ReadAllLines("Input.csv");

MaxTemp maxTemp = new MaxTemp();
maxTemp.Lines = data;
maxTemp.Main();
Durchschnitt durchschnitt = new Durchschnitt(data);
durchschnitt.Main();
Hottest hottest = new Hottest();
hottest._lines = File.ReadAllLines("Input.csv");
hottest.Main();