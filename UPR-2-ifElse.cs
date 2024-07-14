// задача 1

int firstTIme = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTIme + secondTime + thirdTime;

int minutes = totalTime / 60;
int seconds = totalTime % 60;


if (seconds < 10)
{
Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
Console.WriteLine($"{minutes}:{seconds}");
}


//**********************************************************************************************************************************************//


// задача 2 -- Бонус точки

double num = int.Parse(Console.ReadLine());
double bonus = 0.0;


if (num <= 100)
{
bonus = 5;

}
else if (num >= 1000)
{
bonus = num * 0.10;

}
else
{
bonus = num * 0.20;

}

//	За четно число  + 1 т.
if (num % 2 == 0)
{
bonus = bonus + 1;

}  //За число, което завършва на 5  + 2 т.
else if (num % 10 == 5)
{
bonus = bonus + 2;
}

Console.WriteLine(bonus);
Console.WriteLine(num + bonus);


//************************************************************************************************************************************************//


// 3.	Време + 15 минути  


int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

// all the time in min
int time = h * 60 + m + 15;

double xyz = time / 60;

double totalH = Math.Floor(xyz);
double totalM = time % 60;

//проверка дали сме в другия ден вече
if (totalH > 23)
{
totalH = 0;
}

if (totalM < 10)
{
Console.WriteLine($"{totalH}:0{totalM}");
}
else
{
Console.WriteLine($"{totalH}:{totalM}");
}


//************************************************************************************************************************************************




// 4.	Магазин за детски играчки



// //  1.	Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
double price = double.Parse(Console.ReadLine());

// // 2.	Брой пъзели - цяло число в интервала [0… 1000]
int puzzleCount = int.Parse(Console.ReadLine());

// // 3.	Брой говорещи кукли - цяло число в интервала [0 … 1000]
int dollCount = int.Parse(Console.ReadLine());

// // 4.	Брой плюшени мечета - цяло число в интервала [0 … 1000]
int bearCount = int.Parse(Console.ReadLine());

// // 5.	Брой миньони - цяло число в интервала [0 … 1000]
int minionsCount = int.Parse(Console.ReadLine());

// // 6.	Брой камиончета - цяло число в интервала [0 … 1000]
int truckCount = int.Parse(Console.ReadLine());


//     //Брой на играчките: 20 + 25 + 30 + 50 + 10 = 135
int toyCount = puzzleCount + dollCount + bearCount + minionsCount + truckCount;

//     //Сума: 20 * 2.60 + 25 * 3 + 30 * 4.10 + 50 * 8.20 + 10 * 2 = 680 лв.
double money = puzzleCount * 2.60 + dollCount * 3 + bearCount * 4.10 + minionsCount * 8.20 + truckCount * 2;


//     //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена.
if (toyCount >= 50)
{
money = money * 0.75;  //money - money * 0.25;
}
//     //От спечелените пари Петя трябва да даде 10% за наема на магазина. 
money = money * 0.90; //money - money * 0.10;


//     //Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
if (money >= price)
{
double diff = money - price;
Console.WriteLine($"Yes! {diff:f2} lv left.");
}
else
{
double diff = price - money;
Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
}




//*******************************************************************************************************************************************//


//05. Godzilla vs. Kong

double budget = double.Parse(Console.ReadLine());
int countWalkons = int.Parse(Console.ReadLine());
double priceClothes = double.Parse(Console.ReadLine());

double priceDecor = budget * 0.10;
double totalPriceClothes = countWalkons * priceClothes;


if (countWalkons > 150)
{
totalPriceClothes = totalPriceClothes - totalPriceClothes * 0.10;
}

double neededMoney = priceDecor + totalPriceClothes;
double result = Math.Abs(neededMoney - budget);

if (neededMoney > budget)
{
Console.WriteLine("Not enough money!");
Console.WriteLine($"Wingard needs {result:f2} leva more.");
}
else
{
Console.WriteLine("Action!");
Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
}


//************************************************************************************************************************************************


// 6.	Световен рекорд по плуване  //06. World Swimming Record


//     //1.	Рекордът в секунди 
double worldRecord = double.Parse(Console.ReadLine());

//     //2.	Разстоянието в метр
double distance = double.Parse(Console.ReadLine());

//     //3.	Времето в секунди, за което плува разстояние от 1 м. - 
double timeForM = double.Parse(Console.ReadLine());


//     //съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди. 
double slowTime = Math.Floor(distance / 15);
double totalTimeX = distance * timeForM + (slowTime * 12.5);


//     //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 
if (totalTimeX < worldRecord)
{
Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeX:f2} seconds.");
}
else
{
double diff = Math.Abs(totalTimeX - worldRecord);
Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
}


//*********************************************************************************************************************************




//7. Пазаруване  


double kesh = double.Parse(Console.ReadLine());
int videoCardNumber = int.Parse(Console.ReadLine());
int cpuNumber = int.Parse(Console.ReadLine());
int ramNumber = int.Parse(Console.ReadLine());


int totalVideoCardPrice = videoCardNumber * 250;

double cpuPrice = totalVideoCardPrice * 0.35;
double totalCPUPrice = cpuNumber * cpuPrice;

double ramPrice = totalVideoCardPrice * 0.10;
double totalRamPrice = ramNumber * ramPrice;


if (videoCardNumber > cpuNumber)
{
    double totalPriceForALL = totalVideoCardPrice + totalCPUPrice + totalRamPrice;
    double discount = totalPriceForALL * 0.15;

    double finalPrice = totalPriceForALL - discount;

    double moneyLeft = kesh - finalPrice;

    //let display = Math.Abs(moneyLeft).toFixed(2);
    double display = Math.Abs(moneyLeft);

    if (moneyLeft >= 0)
    {
        Console.WriteLine($"You have {display:f2} leva left!");
    }
    else Console.WriteLine($"Not enough money! You need {display:f2} leva more!");
}
else



    //********************************************************************************************************************************




    //8. Обедна почивка    //08. Lunch Break


         //1.	Име на сериал – текст
    string name = Console.ReadLine();

     //2.	Продължителност на епизод  – цяло число 
double durationEP = double.Parse(Console.ReadLine());


     // 3.	Продължителност на почивката  – цяло число 
int durationBreak = int.Parse(Console.ReadLine());


    //Време за обяд : 96 * 1/8 = 12.0
     double lunch = durationBreak / 8.00;

     //Време за отдих : 96 * 1/4 = 24.0'
     double relaxTime = durationBreak / 4.00;

     //Останало време : 96 - 12 - 24 = 60
     double totalFreeTime = durationBreak - lunch - relaxTime;

     // разликата за врмето гледане на сериал и продалжителноста на сериала -- Math.abs(-100) -> 100 върща абсолютната стоиност на числото вътре
    double diff = Math.Abs(totalFreeTime - durationEP);

     if (totalFreeTime >= durationEP) {
        Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(diff)} minutes free time.");
     } else {
        Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(diff)} more minutes.");
     }

