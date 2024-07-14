// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// 1.	Конзолен конвертор: USD към BGN

double usd = double.Parse(Console.ReadLine());
double bgn = usd * 1.79549;
Console.WriteLine(bgn);


//**********************************************************************************************************************//


// 2.	Конзолен конвертор: от радиани в градуси

double radians  = double.Parse(Console.ReadLine());
double degrees = radians * 180 / Math.PI;
Console.WriteLine(degrees);


//********************************************************************************************************************************//


// 3.	Калкулатор депозити

double depositSum = double.Parse(Console.ReadLine());
double depositPeriod = double.Parse(Console.ReadLine()); 
double annualInterestRate = double.Parse(Console.ReadLine());

//сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
double sumAll = depositSum + depositPeriod * ((depositSum * annualInterestRate) / 100 / 12);

Console.WriteLine(sumAll);


//************************************************************************************************************************************//


// 4.	Задължителна литература


int pagesNumber = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine()); 
int deysR = int.Parse(Console.ReadLine());


int timeReadBook = pagesNumber / pages;

int clockTimeNeed = timeReadBook / deysR;

Console.WriteLine(clockTimeNeed);


//*************************************************************************************************************************************



// 5.	Учебни материали

int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pensFinalPrice = pens * 5.80;
double markerFinalPrice = markers * 7.20;
double litersFinalPrice = liters * 1.20;


//Цена за всички материали => 11.60 + 21.60 + 4.80 = 38.00 лв.
double finalPrice = litersFinalPrice + markerFinalPrice + pensFinalPrice;

//Цена с намаление = 38.00 – (38.00 * 0.25) = 28.50 лв.   // percent 25% = 0.25  (25 / 100 = 0.25)
double priceAfterDiscount = finalPrice - (finalPrice * discount / 100);

Console.WriteLine(priceAfterDiscount);


//*******************************************************************************************************************************************//




//6.	Пребоядисване

int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

//Сума за найлон: (10 + 2) * 1.50 = 18 лв.
double nylonFinalSum = (nylon + 2) * 1.50;

// Сума за боя: (11 + 10%) * 14.50 = 175.45 лв.   -- добавяме 10% --- *1.1
double pantiesFinalSum = (paint * 1.1) * 14.50;

//Сума за разредител: 4 * 5.00 = 20.00 лв
double thinnerFinalSum = thinner * 5;

// торбичка
double bagPrice = 0.40;


//Обща сума за материали: 18 + 175.45 + 20.00 + 0.40 = 213.85 лв.
double materialsFinalSum = nylonFinalSum + pantiesFinalSum + thinnerFinalSum + bagPrice;

//Сума за майстори: (213.85 * 30%) * 8 = 513.24 лв  -- взимаме 30% - * 0.3
double finalSum = (materialsFinalSum * 0.3) *  hours;

//Крайна сума: 213.85 + 513.24 = 727.09 лв.
double x = materialsFinalSum + finalSum;

Console.WriteLine(x);


//****************************************************************************************************************************************** 



//7.	Доставка на храна   // 07. Food Delivery


int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegiMenus = int.Parse(Console.ReadLine());

    //Цена за пилешките менюта: 2 броя * 10.35  = 20.70
    double checkenMenusPrice = chickenMenus * 10.35;

    //Цена за менютата с риба: 4 броя * 12.40 = 49.60
    double fishMenusPrice = fishMenus * 12.40;

    // Цена за вегетарианските менюта: 3 броя * 8.15 = 24.45
    double vegiMenusPrice = vegiMenus * 8.15;


    // Обща цена на менютата: 20.70 + 49.60 + 24.45 = 94.75s
    double allMenusPrice = checkenMenusPrice + fishMenusPrice + vegiMenusPrice;

    //Цена на десерта: 20% от 94.75 = 18.95
    double desertPrice = allMenusPrice * 0.20;

    //Обща цена на поръчката: 94.75 + 18.95 + 2.50 = 116.20
    double orederFinalPrice =  allMenusPrice + desertPrice + 2.50;

    Console.WriteLine(orederFinalPrice);



//******************************************************************************************************************************************
//




// 8.	Баскетболно оборудване /Basketball Equipment



   int tren = int.Parse(Console.ReadLine());

        // •	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
       double kez =  tren - (tren * 0.40);

   //•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
        double boxComplect = kez - (kez *0.20);


   //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
       double ballPrice = boxComplect / 4;


   //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
        double partsPlus = ballPrice / 5;

   //Обща цена за екипировката: 365 + 219 + 175.20 + 43.80 + 8.76 = 811.76
   double totalPriceForAll = tren + kez + boxComplect + ballPrice + partsPlus;


   Console.WriteLine(totalPriceForAll);


//**********************************************************************************************************************************************//




//       9.	Аквариум /09. Fish Tank


    // 1.	Дължина в см – цяло число в интервала [10 … 500]
       int daljina = int.Parse(Console.ReadLine());

    // 2.	Широчина в см – цяло число в интервала [10 … 300]
      int shirina = int.Parse(Console.ReadLine());

    // 3.	Височина в см – цяло число в интервала [10… 200]
       int visochina = int.Parse(Console.ReadLine());

    // 4.	Процент  – реално число в интервала [0.000 … 100.000]
       double prozent = double.Parse(Console.ReadLine());


    //обем на аквариумa: 85 * 75 * 47 = 299625 см3
       double obem = daljina * shirina * visochina;

    //обем в литри: 299625 * 0.001 или  299625 / 1000 => 299.625 литра
      double obemLiter = obem /1000 ;

    //заето пространство: 17% = 0.17
        double spaceUsed = prozent / 100;

    //нужни литри: 299.625 * (1 - 0.17) = 248.68875 литра //•	литрите вода, които ще събира аквариума.
        double FinalLiters  =  obemLiter * (1 - spaceUsed );

      Console.WriteLine(FinalLiters);


