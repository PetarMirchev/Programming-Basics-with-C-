

//Exam prep


// 01. Agency Profit  100/100


//1.Име на авиокомпанията - текст
string companyName = Console.ReadLine();

//2. Брой билети за възрастни - цяло число в диапазона [1…400]
int tiketsBigMens = int.Parse(Console.ReadLine());

//3.Брой детски билети - цяло число в диапазона [25…120]
int tiketsKids = int.Parse(Console.ReadLine());

//4.Нетна цена на билет за възрастен - реално число в диапазона [100.00…1600.00]
double priceTiketForBigMan = double.Parse(Console.ReadLine());

//5.Цената на такса обслужване - реално число в диапазона [10.00…50.00]
double priceFeeChecking = double.Parse(Console.ReadLine());


//Нетна цената на детски билет: 120 - 70 % = 36 лв.
double seventiProcent = priceTiketForBigMan * 0.70;
double kidTiketPriceOne = priceTiketForBigMan - seventiProcent;

//Цена на билет за възрастен с такса обслужване: 120 + 40 = 160 лв.
double finalPriceForBigManTiket = priceTiketForBigMan + priceFeeChecking;

//Цена на детски билет с такса обслужване: 36 + 40 = 76 лв.
double finalPriceForKidTiket = kidTiketPriceOne + priceFeeChecking;

//Общата цена на всички билети: (5 * 76) + (15 * 160) = 2780 лв.
double totalPriceForAllTikets = (tiketsKids * finalPriceForKidTiket) + (tiketsBigMens * finalPriceForBigManTiket);

//Печалба: 20 % от 2790 = 556 лв.
double afterEBET = totalPriceForAllTikets * 0.20;

// "The profit of your agency from {име на авиокомпанията} tickets is {печалба за агенцията} lv."
Console.WriteLine($"The profit of your agency from {companyName} tickets is {afterEBET:f2} lv.");





////**************************************************************************************************************************************




// 02. Cat Walking



//1.На първия ред - минути разходка на ден - цяло число в интервала [1...50]
int mins = int.Parse(Console.ReadLine());  // 30

//2.На втория ред - броят на разходките дневно - цяло число в интервала [1…10]
int numberOfTours = int.Parse(Console.ReadLine());   // 3

//3.На третия ред - приетите от котката калории на ден – цяло число в интервала [100…4000]
int caloriIncome = int.Parse(Console.ReadLine());  // 600




//Котката се разхожда 3 пъти по 30 минути => общо минути разходка -> 30 * 3 = 90 минути
int totalTourMinisPerDay = mins * numberOfTours;

//Общо изгорени калории за един ден от разходки -> 90 * 5 = 450
// За всяка минута от разходката, котката гори по 5 калории.
double totalCaloriInDay = totalTourMinisPerDay * 5;

//50 % от приетите калории на ден са: 50 % от 600 = 300
double hafCalorisPerDay = caloriIncome * 0.50;

//450 > 300 => разходката е достатъчна
if (totalCaloriInDay >= hafCalorisPerDay)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriInDay:f0}.");
}
else
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriInDay:f0}.");
}




//*************************************************************************************************************************************




// 03. Coffee Machine / Кафемашина

//100/100


// Първи ред - напитка - текст с възможности "Espresso", "Cappuccino" или "Tea"
string coffeTypeDrink = Console.ReadLine();


//• Втори ред - захар - текст с възможности "Without", "Normal" или "Extra"
string suggarSet = Console.ReadLine();

//• Трети ред - брой напитки - цяло число в интервала [1… 50]
int nummbersOfDrinks = int.Parse(Console.ReadLine());

double finalPriceCustomer = 0.0;
double price1 = 0.0;

switch (coffeTypeDrink)
{
    case "Espresso":
        {
            switch (suggarSet)
            {
                case "Without":
                    {
                        price1 = nummbersOfDrinks * 0.90;
                        //• При избрана напитка без захар има 35% отстъпка.
                        double discount35Percent = price1 * 0.35;
                        double priceDiscount1 = price1 - discount35Percent;
                        price1 = priceDiscount1;

                        //При избрана напитка "Espresso" и закупени поне 5 броя, има 25% отстъпка.
                        if (nummbersOfDrinks >= 5)
                        {
                            double buffExtraDiscount = priceDiscount1 * 0.25;
                            double moreExtraDiscountPrice = priceDiscount1 - buffExtraDiscount;
                            price1 = moreExtraDiscountPrice;
                        }
                    }
                    break;
                case "Normal":
                    {
                        price1 = nummbersOfDrinks * 1.00;
                        //При избрана напитка "Espresso" и закупени поне 5 броя, има 25% отстъпка.
                        if (nummbersOfDrinks >= 5)
                        {
                            double buffExtraDiscount = price1 * 0.25;
                            double moreExtraDiscountPrice = price1 - buffExtraDiscount;
                            price1 = moreExtraDiscountPrice;

                        }
                    }
                    break;
                case "Extra":
                    {
                        price1 = nummbersOfDrinks * 1.20;

                        //При избрана напитка "Espresso" и закупени поне 5 броя, има 25% отстъпка.
                        if (nummbersOfDrinks >= 5)
                        {
                            double buffExtraDiscount = price1 * 0.25;
                            double moreExtraDiscountPrice = price1 - buffExtraDiscount;
                            price1 = moreExtraDiscountPrice;
                        }
                    }
                    break;
                default: break;
            }
        }
        break;



    case "Cappuccino":
        {
            switch (suggarSet)
            {
                case "Without":
                    {
                        price1 = nummbersOfDrinks * 1.00;
                        //• При избрана напитка без захар има 35% отстъпка.
                        double discount35Percent = price1 * 0.35;
                        double priceDiscount1 = price1 - discount35Percent;
                        price1 = priceDiscount1;
                    }
                    break;
                case "Normal":
                    {
                        price1 = nummbersOfDrinks * 1.20;
                    }
                    break;
                case "Extra":
                    {
                        price1 = nummbersOfDrinks * 1.60;
                    }
                    break;
                default: break;
            }
        }
        break;



    case "Tea":
        {
            switch (suggarSet)
            {
                case "Without":
                    {
                        price1 = nummbersOfDrinks * 0.50;
                        //• При избрана напитка без захар има 35% отстъпка.
                        double discount35Percent = price1 * 0.35;
                        double priceDiscount1 = price1 - discount35Percent;
                        price1 = priceDiscount1;
                    }
                    break;
                case "Normal":
                    {
                        price1 = nummbersOfDrinks * 0.60;
                    }
                    break;
                case "Extra":
                    {
                        price1 = nummbersOfDrinks * 0.70;
                    }
                    break;
                default: break;
            }
            break;
        }
    default: break;
}



//При сума надвишава 15 лева, 20% отстъпка от крайната цена,
if (price1 > 15)
{
    double buff = price1 * 0.20;
    finalPriceCustomer = price1 - buff;
}
else
{
    finalPriceCustomer = price1;
}

Console.WriteLine($"You bought {nummbersOfDrinks} cups of {coffeTypeDrink} for {finalPriceCustomer:f2} lv.");




//*************************************************************************************************************************************





// 04.Trekking Mania



//• На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
int groupsNumber = int.Parse(Console.ReadLine());

int Musala = 0;
int Montblanc = 0;
int Kilimanjaro = 0;
int K2 = 0;
int Everest = 0;


for (int i = 1; i <= groupsNumber; i++)
{
    //• За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала [1...1000]
    int peopleInGroup = int.Parse(Console.ReadLine());

    //• Група до 5 човека– Мусала
    if (peopleInGroup <= 5)
    {
        Musala += peopleInGroup;
    }

    //• Група от 6 до 12 – Монблан
    if (6 <= peopleInGroup && peopleInGroup <= 12)
    {
        Montblanc += peopleInGroup;
    }


    //• Група от 13 до 25 – Килиманджаро
    if (13 <= peopleInGroup && peopleInGroup <= 25)
    {
        Kilimanjaro += peopleInGroup;
    }

    //• Група от 26 до 40 – К2
    if (26 <= peopleInGroup && peopleInGroup <= 40)
    {
        K2 += peopleInGroup;
    }

    //• Група от 41 или повече – Еверест
    if (41 <= peopleInGroup)
    {
        Everest += peopleInGroup;
    }
}

// Всички хора 10 + 5 + 1 + .... + 78 = 326
double allPeopleIn = Musala + Montblanc + K2 + Everest + Kilimanjaro;

// 6 / 326 * 100 = 1.84 % изкачващи Мусала
double percentMusala = Musala / allPeopleIn * 100;
// 22/326*100 = 6.75% изкачващи Монблан
double percentMontblanc = Montblanc / allPeopleIn * 100;
//17/326*100 = 5.21% изкачващи Килиманджаро
double percentKilimanjaro = Kilimanjaro / allPeopleIn * 100;
//103/326*100 = 31.60% изкачващи К2
double percentK2 = K2 / allPeopleIn * 100;
// 178/326*100 = 54.60% изкачващи Еверест
double percentEverest = Everest / allPeopleIn * 100;


Console.WriteLine($"{percentMusala:f2}%");
Console.WriteLine($"{percentMontblanc:f2}%");
Console.WriteLine($"{percentKilimanjaro:f2}%");
Console.WriteLine($"{percentK2:f2}%");
Console.WriteLine($"{percentEverest:f2}%");


//**************************************************************************************************************************************




// 04. Movie Stars


// input:

//170000 --> bugetForMovie
//Ben Affleck --> actorName
//40000.50
//Zahari Baharov
//80000
//Tom Hanks
//2000.99
//ACTION

//90/100
double budgetActors = double.Parse(Console.ReadLine());
string nameOfActor = Console.ReadLine();
double salaryOut = 0;

while (nameOfActor != "ACTION")
{
    if (nameOfActor.Length <= 15 && nameOfActor.Length > 0)
    {
        double salary = double.Parse(Console.ReadLine());
        salaryOut = salary;
    }
    else
    {
        salaryOut = budgetActors * 0.20;
    }

    if (budgetActors < salaryOut)
    {
        break;
    }
    budgetActors -= salaryOut;

    nameOfActor = Console.ReadLine();
}
if (budgetActors >= salaryOut)
{
    Console.WriteLine($"We are left with {budgetActors:f2} leva.");
}
else
{
    double result = Math.Abs(budgetActors - salaryOut);
    Console.WriteLine($"We need {(result):f2} leva for our actors.");
}



//**************************************************************************************************************************************
