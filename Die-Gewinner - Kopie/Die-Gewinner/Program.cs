using Die_Gewinner;

MaxTemp maxTemp = new MaxTemp();
maxTemp.Lines = File.ReadAllLines("D:\\Schule\\Jahr 1\\Herr Baldes\\VS Zeugs\\Die-Gewinner\\Die-Gewinner\\Die-Gewinner\\Input.csv");
maxTemp.Main();
Durchschnitt durchschnitt = new Durchschnitt();
durchschnitt.Lines = File.ReadAllLines("D:\\Schule\\Jahr 1\\Herr Baldes\\VS Zeugs\\Die-Gewinner\\Die-Gewinner\\Die-Gewinner\\Input.csv");
durchschnitt.Main();
Hottest hottest = new Hottest();
hottest.Lines = File.ReadAllLines("D:\\Schule\\Jahr 1\\Herr Baldes\\VS Zeugs\\Die-Gewinner\\Die-Gewinner\\Die-Gewinner\\Input.csv");
hottest.Main();