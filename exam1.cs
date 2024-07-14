// exam 1



//01. Tennis Equipment

//100/100

//•	Цена на една тенис ракета – реално число в интервала [0.00…100000.00]
double priceTenisRaketa = double.Parse(Console.ReadLine());

//•	Брой тенис ракети - цяло число в интервала [0…100]
int numberOfTenisRaketi = int.Parse(Console.ReadLine());

//•	Брой чифтове маратонки - цяло число в интервала [0…100]
int numberOfMaratonki = int.Parse(Console.ReadLine());


// Цената за ракетите 4 * 850 => 3400
double priceForAllRaketi = priceTenisRaketa * numberOfTenisRaketi;


//•	1 чифт маратонки = 1/6 от цената на една тенис ракета
//Цена за чифт маратонки 850 / 6 => 141.66
double priceForOneMaratonki = priceTenisRaketa / 6;

//Цена за всички маратонки 2 * 141.66 => 283.33
double forAllMaratonkiPrice = priceForOneMaratonki * numberOfMaratonki;


//Цена за останало оборудване (3400 + 283.33) * 0.2 = 736.66 
double diff = (priceForAllRaketi + forAllMaratonkiPrice) * 0.2;

// Обща цена = 3400 + 283.33 + 736.66 = 4420
double totalPriceAll = priceForAllRaketi + forAllMaratonkiPrice + diff;

//Цена за Джокович = 4420 / 8 = 552
double priceDjokovich = totalPriceAll / 8;

// Цена за спонсорите = 4420 * 7 / 8 = 3868
double priceSupport = totalPriceAll - priceDjokovich;


Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovich)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSupport)}");



//************************************************************************************************************************************



//01. Basketball Equipment


//•	Годишната такса за тренировки по баскетбол – цяло число в интервала [0… 9999]
//Цена на тренировките за година: 320
int taxForTreinYear = int.Parse(Console.ReadLine());

//Цена на баскетболните кецове: 320 – 40% = 192
double fortyPercent = taxForTreinYear * 0.40;
double kezovePrice = taxForTreinYear - fortyPercent;

//Цена на баскетболен екип: 192 – 20 % = 153.6
double twentyPercent = kezovePrice * 0.20;
double ekipBasketbol = kezovePrice - twentyPercent;


//Цена на баскетболна топка: 1 / 4 от 153.6 = 38.4
double topka = ekipBasketbol / 4;

// Цена на баскетболни аксесоари: 1 /  5 от 38.4 = 7.68
double staff = topka / 5;

// Обща цена за екипировката: 320 + 192 + 153.6 + 38.4 + 7.68 = 711.68
double totalSpend = taxForTreinYear + kezovePrice + ekipBasketbol + topka + staff;

Console.WriteLine($"{totalSpend:f2}");



//************************************************************************************************************************************


// 02. Football Results

//От конзолата се четат 3 реда:
//1.Резултат от първия мач – текст 
//2.	Резултат от втория мач – текст 
//3.	Резултат от третия мач – текст 
//Резултатите ще са в следния формат: "2:0", "0:1", "1:1" и т.н.

string firstGameResult = Console.ReadLine();
string secondGameResult = Console.ReadLine();
string thirdGameResult = Console.ReadLine();

// get letter char
char firstLetterFromFirstWord = firstGameResult[0];
char secondLetterFromFirstWord = firstGameResult[2];
char firstLetterFromSecondWord = secondGameResult[0];
char secondLetterFromSecondWord = secondGameResult[2];
char firstLetterFromThirdWord = thirdGameResult[0];
char secondLetterFromThirdWord = thirdGameResult[2];

int win = 0;
int lose = 0;
int draw = 0;

if (firstLetterFromFirstWord > secondLetterFromFirstWord)
{
    win++;

}
else if ((firstLetterFromFirstWord < secondLetterFromFirstWord))
{
    lose++;
}
else
{
    draw++;
}

if (firstLetterFromSecondWord > secondLetterFromSecondWord)
{
    win++;

}
else if (firstLetterFromSecondWord < secondLetterFromSecondWord)
{
    lose++;
}
else
{
    draw++;
}

if (firstLetterFromThirdWord > secondLetterFromThirdWord)
{
    win++;

}
else if (firstLetterFromThirdWord < secondLetterFromThirdWord)
{
    lose++;
}
else
{
    draw++;
}

Console.WriteLine($"Team won {win} games.");
Console.WriteLine($"Team lost {lose} games.");
Console.WriteLine($"Drawn games: {draw}");



//**********************************************************************************************************************************





//02. Skeleton

// 100 /100

//Ред 1.	Минути на контролата – цяло число в интервала [0…59]


int minControla = int.Parse(Console.ReadLine()); // 2

//Ред 2.Секунди на контролата – цяло число в интервала [0…59]
int secControla = int.Parse(Console.ReadLine()); // 12

//Ред 3.Дължината на улея в метри – реално число в интервала [0.00…50000]
double pullLenghtInMeters = double.Parse(Console.ReadLine()); //1200

//Ред 4.Секунди за изминаване на 100 метра – цяло число в интервала [0…1000]
int secFor100Meters = int.Parse(Console.ReadLine()); // 10


// Изчисляване на контролата в секунди: 2 * 60 + 12 => 132 секунди
int totalTimeInSecControlas = (minControla * 60) + secControla;

//Изчисляване, колко пъти времето ще намалее: 1200 / 120 = 10
double timeDeley = pullLenghtInMeters / 120;

//Общо намалено време: 10 * 2.5 = 25 секунди
double totalDelayTime = timeDeley * 2.5;

//Времето на Марин: (1200 / 100) * 10 – 25 = 95 секунди
double timeMartin = (pullLenghtInMeters / 100) * secFor100Meters - totalDelayTime;


//Контролно време: 132 сек., времето на Марин -95 сек.
if (totalTimeInSecControlas >= timeMartin)
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {timeMartin:f3}.");
} else
{
    double resultMissingTime = timeMartin - totalTimeInSecControlas;
    Console.WriteLine($"No, Marin failed! He was {resultMissingTime:f3} second slower.");
}


//************************************************************************************************************************************



//03. Gymnastics

// 100/100

string X = Console.ReadLine();
string unit = Console.ReadLine();

    double difficultly = 0.0;
    double du = 0.0;

    if (X == "Bulgaria")
    {
        switch (unit)
        {
            case "ribbon": difficultly = 9.600; du = 9.400; break;
            case "hoop": difficultly = 9.550; du = 9.750; break;
            case "rope": difficultly = 9.500; du = 9.400; break;
        }

    }
    else if (X == "Russia")
    {
        switch (unit)
        {
            case "ribbon": difficultly = 9.100; du = 9.400; break;
            case "hoop": difficultly = 9.300; du = 9.800; break;
            case "rope": difficultly = 9.600; du = 9.000; break;
        }

    }
    else if (X == "Italy")
    {
        switch (unit)
        {
            case "ribbon": difficultly = 9.200; du = 9.500; break;
            case "hoop": difficultly = 9.450; du = 9.350; break;
            case "rope": difficultly = 9.700; du = 9.150; break;
        }
    }
    double totalScore = difficultly + du;

    //•	Първи ред: "The team of {държава} get {обща оценка} on {уред}."
    //•	Втори ред:  "{процентът, който не им достига до максималния брой точки}%"
    Console.WriteLine($"The team of {X} get {totalScore:f3} on {unit}.");

    //Остават: 20 – 19.000 = 1 точка до максималния брой 
    double diffMaxScore = 20 - totalScore;
    double percentDiffToMaxScore = (diffMaxScore / 20) * 100; //точки, което е: (1 / 20) * 100 = 5 % 
    Console.WriteLine($"{percentDiffToMaxScore:f2}%");


//***************************************************************************************************************************************



// 03. World Snooker Championship // Задача 3. Билети за снукър