
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double income = 0.0;

if (type == "Premiere")
{
    income = rows * columns * 12.00;
}
else if (type == "Normal")
{
    income = rows * columns * 7.50;

}
else if (type == "Discount")
{
    income = rows * columns * 5.00;
}

Console.WriteLine($"{income:f2} leva");


//*****************************************************************************************************************************//


//02. Summer Outfit  // 2.	 Лятно облекло



double degrees = double.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();


if ((10 <= degrees) && (degrees <= 18))
{
    if (timeOfDay == "Morning")
    {

        string outfit = "Sweatshirt";
        string shoes = "Sneakers";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }

    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    {
        string outfit1 = "Shirt";
        string shoes1 = "Moccasins";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit1} and {shoes1}.");
    }
}
else if ((18 < degrees) && (degrees <= 24))
{
    if (timeOfDay == "Morning")
    {

        string outfit2 = "Shirt";
        string shoes2 = "Moccasins";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit2} and {shoes2}.");
    }
    else if (timeOfDay == "Afternoon")
    {

        string outfit3 = "T-Shirt";
        string shoes3 = "Sandals";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit3} and {shoes3}.");
    }
    else if (timeOfDay == "Evening")
    {

        string outfit4 = "Shirt";
        string shoes4 = "Moccasins";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit4} and {shoes4}.");
    }
}
else if (degrees >= 25)
{
    if (timeOfDay == "Morning")
    {

        string outfit5 = "T-Shirt";
        string shoes5 = "Sandals";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit5} and {shoes5}.");
    }
    else if (timeOfDay == "Afternoon")
    {

        string outfit6 = "Swim Suit";
        string shoes6 = "Barefoot";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit6} and {shoes6}.");
    }
    else if (timeOfDay == "Evening")
    {

        string outfit7 = "Shirt";
        string shoes7 = "Moccasins";

        Console.WriteLine($"It's {degrees} degrees, get your {outfit7} and {shoes7}.");
    }

}


//*********************************************************************************************************************************//




//3.	Нов дом  // 03. New House

string typeFlowers = Console.ReadLine();
int countFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double money = 0.0;

switch (typeFlowers)
{
    case "Roses":
        money = countFlowers * 5;
        if (countFlowers > 80)
        {
            money = money * 0.9;
        }
        break;

    case "Dahlias":
        money = countFlowers * 3.8;
        if (countFlowers > 90)
        {
            money = money * 0.85;
        }
        break;

    case "Tulips":
        money = countFlowers * 2.8;
        if (countFlowers > 80)
        {
            money = money * 0.85;
        }
        break;

    case "Narcissus":
        money = countFlowers * 3;
        if (countFlowers < 120)
        {
            money = money * 1.15;
        }
        break;

    case "Gladiolus":
        money = countFlowers * 2.5;
        if (countFlowers < 80)
        {
            money = money * 1.2;
        }
        break;
}

double diff = Math.Abs(budget - money);
if (budget >= money)
{
    Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {diff:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
}


//***********************************************************************************************************************************************



//4.	Лодка за риболов // 04. Fishing Boat



int budgetMoney = int.Parse(Console.ReadLine());
string seasonsY = Console.ReadLine();
int teamNumber = int.Parse(Console.ReadLine());

double sheepPrice = 0.0;

switch (seasonsY)
{
    case "Spring":
        sheepPrice = 3000;
        break;
    case "Summer":
    case "Autumn":
        sheepPrice = 4200;
        break;
    case "Winter": sheepPrice = 2600; break;
}

if (teamNumber <= 6)
{
    sheepPrice = sheepPrice * 0.9;
}
else if (teamNumber <= 11)
{
    sheepPrice = sheepPrice * 0.85;
}
else if (12 <= teamNumber)
{
    sheepPrice = sheepPrice * 0.75;
}

if (teamNumber % 2 == 0 && seasonsY != "Autumn")
{
    sheepPrice = sheepPrice * 0.95;
}

if (budgetMoney >= sheepPrice)
{
    Console.WriteLine($"Yes! You have {(budgetMoney - sheepPrice):f2} leva left.");
}

else
{
    Console.WriteLine($"Not enough money! You need {(sheepPrice - budgetMoney):f2} leva.");
}


//************************************************************************************************************************************************



// 5.	Пътешествие //  05. Journey


double budget = double.Parse(Console.ReadLine());
string seasons = Console.ReadLine();


if (100 >= budget)
{
    string destination = "Bulgaria";
    switch (seasons)
    {
        case "summer":
            double spendBudget1 = budget * 0.30;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"Camp - {spendBudget1:f2}");
            break;
        case "winter":
            double spendBudget = budget * 0.70;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"Hotel - {spendBudget:f2}");
            break;
    }
}
else if (1000 >= budget)
{
    string destination = "Balkans";
    switch (seasons)
    {
        case "summer":
            double spendBudget1 = budget * 0.40;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"Camp - {spendBudget1:f2}");
            break;

        case "winter":
            double spendBudget = budget * 0.80;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"Hotel - {spendBudget:f2}");
            break;
    }

}
else if (budget > 1000)
{
    string destination = "Europe";
    double spendBudget = budget * 0.90;
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"Hotel - {spendBudget:f2}");
}


//************************************************************************************************************************************************


// 6.	Операции между числа

double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operator1 = Console.ReadLine();

switch (operator1)
{
    case "+":
        double resultX = firstNumber + secondNumber;
        if (resultX % 2 == 0)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {resultX} - even");
        }
        else
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {resultX} - odd");
        }
        break;

    case "-":
        double resultY = firstNumber - secondNumber;
        if (resultY % 2 == 0)
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {resultY} - even");
        }
        else
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {resultY} - odd");
        }
        break;

    case "*":
        double resultZ = firstNumber * secondNumber;
        if (resultZ % 2 == 0)
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {resultZ} - even");
        }
        else
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {resultZ} - odd");
        }
        break;

    case "/":
        double resultN = firstNumber / secondNumber;
        if (secondNumber == 0)
        {
            Console.WriteLine($"Cannot divide {firstNumber} by zero");
        }
        else
        {
            Console.WriteLine($"{firstNumber} / {secondNumber} = {resultN:f2}");
        }
        break;

    case "%":
        double resultK = firstNumber % secondNumber;
        if (secondNumber == 0)
        {
            Console.WriteLine($"Cannot divide {firstNumber} by zero");
        }
        else
        {
            Console.WriteLine($"{firstNumber} % {secondNumber} = {resultK}");
        }
        break;

}


//************************************************************************************************************************************************



//7.	Хотелска стая      // 07. Hotel Room


string monthYear = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

//create buffer
double apartmentPrice = 0.0;
double studioPrice = 0.0;


switch (monthYear)
{
    case "May":
        apartmentPrice = days * 65.00;
        studioPrice = days * 50.00;
        if ((14 >= days) && (days > 7))
        {
            studioPrice = studioPrice * 0.95;
        }
        else if (days > 14)
        {
            studioPrice = studioPrice * 0.70;
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;
    case "October":
        apartmentPrice = days * 65.00;
        studioPrice = days * 50.00;
        if ((14 >= days) && (days > 7))
        {
            studioPrice = studioPrice * 0.95;
        }
        else if (days > 14)
        {
            studioPrice = studioPrice * 0.70;
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;

    case "September":
        apartmentPrice = days * 68.70;
        studioPrice = days * 75.20;
        if (days > 14)
        {
            studioPrice = studioPrice * 0.80;
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;
    case "June":
        apartmentPrice = days * 68.70;
        studioPrice = days * 75.20;
        if (days > 14)
        {
            studioPrice = studioPrice * 0.80;
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;

    case "July":
        apartmentPrice = days * 77.00;
        studioPrice = days * 76.00;
        if (days > 14)
        {
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;
    case "August":
        apartmentPrice = days * 77.00;
        studioPrice = days * 76.00;
        if (days > 14)
        {
            apartmentPrice = apartmentPrice * 0.90;
        }
        break;

}
Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:f2} lv.");



//**************************************************************************************************************************************************//

// 8.	Навреме за изпит   // 08. On Time for the Exam  (93/100)



double examHour = double.Parse(Console.ReadLine());
double examMin = double.Parse(Console.ReadLine());
double arriveHour = double.Parse(Console.ReadLine());
double arriveMin = double.Parse(Console.ReadLine());


         //convert to min
         double examTime = (examHour * 60) + examMin; 
         double arrivalTime = (arriveHour * 60) + arriveMin;

         double timeDifference = examTime - arrivalTime;

         double earlyHour;
         double earlyMin;
         double lateHour;
         double lateMin;

         // on time
         if (timeDifference >= 0 && timeDifference <= 30) {  

             if (timeDifference == 0){
                Console.WriteLine("On time");

            } else {
                Console.WriteLine($"On time {timeDifference} minutes before the start");
            }

         }
             // Early
         else if (timeDifference > 30 ) {          

             earlyHour = Math.Floor(timeDifference / 60);
             earlyMin = timeDifference % 60;


             if (timeDifference > 30 && timeDifference <= 59) {
                    Console.WriteLine($"Early {timeDifference} minutes before the start");
                }
             else if ((60 <= timeDifference) && (timeDifference <= 69)){
                Console.WriteLine($"Early {earlyHour}:0{earlyMin} hours before the start");
            }
             else {
                Console.WriteLine($"Early {earlyHour}:{earlyMin} hours before the start");
            }

         }

          //  Late
         else {     

             timeDifference = Math.Abs(timeDifference);
             lateHour = Math.Floor(timeDifference / 60);
             lateMin = timeDifference % 60;

             if (timeDifference <= 59) {
                Console.WriteLine($"Late {timeDifference} minutes after the start");
            }
             else if ((60 <= timeDifference) && (timeDifference <= 69)){
                Console.WriteLine($"Late {lateHour}:0{lateMin} hours after the start");             
             }
             else {
                Console.WriteLine($"Late {lateHour}:{lateMin} hours after the start");
            } 
         }


//*****************************************************************************************//



       //  (100/100)


    double examHour = double.Parse(Console.ReadLine());
    double examMin = double.Parse(Console.ReadLine());
    double arrivalHour = double.Parse(Console.ReadLine());
    double arrivalMin = double.Parse(Console.ReadLine());


    double examTimeMin = examHour * 60 + examMin;
    double arrivalTimeMin = arrivalHour * 60 + arrivalMin;
    double difference = examTimeMin - arrivalTimeMin;
    double hours;
    double minutes;

    if (difference == 0)
    {
        Console.WriteLine("On time");
    }
    else if (difference <= 30 && difference >= 0)
    {
        minutes = difference;
        Console.WriteLine("On time");
        Console.WriteLine($"{minutes} minutes before the start");
    }
    else if (examTimeMin > arrivalTimeMin)
    {
        difference = Math.Abs(difference);
        minutes = difference % 60;
        hours = Math.Floor(difference / 60);

        Console.WriteLine("Early");

        if (minutes <= 10 && hours > 0)
        {
            Console.WriteLine($"{hours}:0{minutes} hours before the start");
        }
        else if (minutes > 10 && hours > 0)
        {
            Console.WriteLine($"{hours}:{minutes} hours before the start");
        }
        else
        {
            Console.WriteLine($"{minutes} minutes before the start");
        }
    }
    else if (arrivalTimeMin > examTimeMin)
    {
        difference = Math.Abs(difference);
        minutes = difference % 60;
        hours = Math.Floor(difference / 60);
       
        Console.WriteLine("Late");

    if (minutes <= 10 && hours > 0)
        {
            Console.WriteLine($"{hours}:0{minutes} hours after the start");
        }
        else if (minutes > 10 && hours > 0)
        {
            Console.WriteLine($"{hours}:{minutes} hours after the start");
        }
        else
        {
            Console.WriteLine($"{minutes} minutes after the start");
        }
    }









//***********************************************************************************************************************************************//



//9.	Ски почивка  // skiTrip


int daysToStay = int.Parse(Console.ReadLine());
    string roomType = Console.ReadLine();
    string feedback = Console.ReadLine();


    int nights = daysToStay - 1;
    double totalPrice = 0.0;

    switch (roomType)
    {
        case "room for one person":
            totalPrice = nights * 18;
            break;
        case "apartment":
            totalPrice = nights * 25;
            if (nights < 10)
            {
                totalPrice = totalPrice * 0.70;
            }
            else if (10 <= nights && nights < 15)
            {
                totalPrice = totalPrice * 0.65;
            }
            else if (nights >= 15)
            {
                totalPrice = totalPrice * 0.50;
            }
            break;
        case "president apartment":
            totalPrice = nights * 35;
            if (nights < 10)
            {
                totalPrice = totalPrice * 0.90;
            }
            else if (10 >= nights && nights < 15)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (nights >= 15)
            {
                totalPrice = totalPrice * 0.80;
            }
            break;
    }
    if (feedback == "positive")
    {
        totalPrice = totalPrice * 1.25;
    }
    else
    {
        totalPrice = totalPrice * 0.90;
    }
    Console.WriteLine($"{totalPrice:f2}");
