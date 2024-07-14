
//EXAM 30.06.2024



//01. Excursion


//•	Нощувка - 20 лв.
//•	Карта за транспорт - 1.60 лв.
//•	Билет за музей - 6 лв.


//1.Броят на хората в групата – цяло число в интервала [0 … 50]
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

int numberOfPeople = int.Parse(Console.ReadLine()); //20

//2.Броят на нощувките – цяло число в интервала [0 … 2000]
int numberOfSleeps = int.Parse(Console.ReadLine()); //14

//3.Броят на картите за транспорт – цяло число в интервала [0… 2000]
int numberOfCarts = int.Parse(Console.ReadLine()); //30 

//4.Броят на билетите за музеи – цяло число в интервала [0 … 2000]
int numberOfTikets = int.Parse(Console.ReadLine()); //6


//Нощувки: 14 * 20 = 280 лв.
int priceSleeps = numberOfSleeps * 20;

//Карти за транспорт: 30 * 1.60 =  48 лв.
double priceAllCarts = numberOfCarts * 1.60;

//Билети за музеи: 6 * 6 = 36 лв.
int priceAllTikets = numberOfTikets * 6;

//Обща сума за един човек от групата: 280 + 48 + 36 =  364 лв.
double priceFor1Person = priceSleeps + priceAllCarts + priceAllTikets;

//Сума за цялата група: 364 * 20 = 7280 лв.
double priceForAllGroup = priceFor1Person * numberOfPeople;

//Сума след добавяне на непредвидените разходи: 7280 + 25% = 9100 лв.
double buff25 = priceForAllGroup * 0.25;

double extraPrice = priceForAllGroup + buff25;

Console.WriteLine("{0:f2}", extraPrice);



//****************************************************************************************************************************************



// 02. Deer of Santas



//•	Първи ред – брой дни, в които Дядо Коледа отсъства – цяло число в интервала [1…5000]
int deysLeftSanta = int.Parse(Console.ReadLine()); //2

//•	Втори ред – оставена храна в килограми – цяло число в интервала [0…100000]
int foodLeftInKG = int.Parse(Console.ReadLine()); //10

//•	Трети ред – храна на ден за първия елен в килограми – реално число в интервала [0.00…100.00]
double foodForFirstElenLeft = double.Parse(Console.ReadLine()); // 1

//•	Четвърти ред – храна на ден за втория елен в килограми– реално число в интервала [0.00…100.00]
double foodForSecondElenLeft = double.Parse(Console.ReadLine());// 1

//•	Пети ред – храна на ден за третия елен в килограми – реално число в интервала [0.00…100.00]
double foodForThertElenLeft = double.Parse(Console.ReadLine()); // 2


//първи елен => 2 дни * 1 кг = 2 кг
double calElen1 = deysLeftSanta * foodForFirstElenLeft;

//втори елен => 2 дни * 1 кг = 2 кг
double calElen2 = deysLeftSanta * foodForSecondElenLeft;

//трети елен => 2 дни * 2 кг = 4 кг
double calElen3 = deysLeftSanta * foodForThertElenLeft;

//Общо нужна храна => 2 + 2 + 4 = 8 кг
double totalNeedFood = calElen1 + calElen2 + calElen3;

//8 < 10 => количеството храна е достатъчно
if (totalNeedFood <= foodLeftInKG)
{
    //=> 10 - 8 = 2 кг. храна остават
    double kgLefts = totalNeedFood - foodLeftInKG;
    double result = Math.Abs(kgLefts);
    Console.WriteLine($"{Math.Floor(result)} kilos of food left.");
}
else if (totalNeedFood > foodLeftInKG)
{
    double kgNeeds = totalNeedFood - foodLeftInKG;
    Console.WriteLine($"{Math.Ceiling(kgNeeds)} more kilos of food are needed.");
}



//***************************************************************************************************************************************



// 03. Excursion Calculator

//1.Първи ред – брой хора – цяло число в интервала [1 … 20]
int numberOfPeopleInput = int.Parse(Console.ReadLine());

//2.Втори ред – сезон – текст с възможности - "spring", "summer", "autumn" или "winter" 
string seasonInput = Console.ReadLine();

double pricePerMan = 0.0;
double priceForAllMens = 0.0;

if (numberOfPeopleInput <= 5)
{
    switch (seasonInput)
    {
        case "spring": pricePerMan = 50.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "summer": pricePerMan = 48.50; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "autumn": pricePerMan = 60.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "winter": pricePerMan = 86.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
    }
}

if (numberOfPeopleInput > 5)
{
    switch (seasonInput)
    {
        case "spring": pricePerMan = 48.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "summer": pricePerMan = 45.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "autumn": pricePerMan = 49.50; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
        case "winter": pricePerMan = 85.00; priceForAllMens = pricePerMan * numberOfPeopleInput; break;
    }
}


if (seasonInput == "summer")
{
    //•	При "summer" -> 15% отстъпка
    double discount15 = priceForAllMens * 0.15;
    priceForAllMens = priceForAllMens - discount15;
    Console.WriteLine($"{priceForAllMens:f2} leva.");
}
else if (seasonInput == "winter")
{
    //•	При "winter" -> 8% оскъпяване
    double extra8 = priceForAllMens * 0.08;
    priceForAllMens = priceForAllMens + extra8;
    Console.WriteLine($"{priceForAllMens:f2} leva.");
}
else
{
    Console.WriteLine($"{priceForAllMens:f2} leva.");
}




//*************************************************************************************************************************************



//04. Computer Firm


//•	n - брой компютри - цяло число в интервала [1…10]
int n = int.Parse(Console.ReadLine());


double totalSales = 0;
double totalRating = 0;

for (int i = 0; i < n; i++)
{
    //•	Числото, представляващо възможните продажби и рейтинга - цяло число в интервала [32…306]
    double ratingInput = int.Parse(Console.ReadLine());
    double rating = ratingInput % 10;
    double sales = Math.Floor(ratingInput / 10);

    switch (rating)
    {
        case 2:
            totalSales += 0;
            break;
        case 3:
            totalSales += sales * 0.5;
            break;
        case 4:
            totalSales += sales * 0.7;
            break;
        case 5:
            totalSales += sales * 0.85;
            break;
        case 6:
            totalSales += sales;
            break;
        default:
            Console.WriteLine($"{totalSales}"); break;
    }

    totalRating += rating;
}

double averageRating = (totalRating / n);
double formattedSales = totalSales;
Console.WriteLine($"{formattedSales:f2}");
Console.WriteLine($"{averageRating:f2}");


******************************************************************************************************************************************




// 05. Best Player
//100/100

string bestPlayerName = string.Empty;
int bestPlayerGols = 0;
int count = 0;

while (true)
{

    if (count >= 3)
    {
        break;
    }

    //•	Име на играч – текст
    string nameOfPlayer = Console.ReadLine();

    if (nameOfPlayer == "END" || nameOfPlayer == string.Empty)
    {
        break;
    }

    //•	Брой вкарани голове  – цяло положително число в интервала [1 … 10000]
    int numberOfGools = int.Parse(Console.ReadLine());


    if (numberOfGools > bestPlayerGols)
    {
        bestPlayerGols = numberOfGools;
        bestPlayerName = nameOfPlayer;
    }


    count++;

    if (numberOfGools >= 10)
    {
        break;
    }
}

if (bestPlayerGols >= 3)
{
    Console.WriteLine($"{bestPlayerName} is the best player!");
    Console.WriteLine($"He has scored {bestPlayerGols} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"{bestPlayerName} is the best player!");
    Console.WriteLine($"He has scored {bestPlayerGols} goals.");
}




//**************************************************************************************************************************************



//06.Multiply Table


//Входът е цяло трицифрено число в интервала [111…999].
string numberString = Console.ReadLine();

//String value = "This is a string.";
//int startIndex = 0; //set number of char to get
//int length = 1; //how many chars to get
//String substring = value.Substring(startIndex, length); // cut needt chart number

//string s1 = "123";
string number1String = numberString.Substring(0, 1);
string number2String = numberString.Substring(1, 1);
string number3String = numberString.Substring(2, 1);

int number1 = int.Parse(number1String);
int number2 = int.Parse(number2String);
int number3 = int.Parse(number3String);

//Console.WriteLine($"{number1}");
//Console.WriteLine($"{number2}");
//Console.WriteLine($"{number3}");

//324
for (int i = 1; i <= number3; i++)
{
    for (int j = 1; j <= number2; j++)
    {
        for (int k = 1; k <= number1; k++)
        {
            Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
        }
    }
}