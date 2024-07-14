
Console.WriteLine("Hello SoftUni");

//*******************************************************************************************************************************//


Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
Console.WriteLine(6);
Console.WriteLine(7);
Console.WriteLine(8);
Console.WriteLine(9);
Console.WriteLine(10);


//**********************************************************************************************************************************//



int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int area = a * b;
Console.WriteLine(area);


//******************************************************************************************************************************************//


double input = double.Parse(Console.ReadLine());

double result1 = input * 2.54;

Console.WriteLine(result1);


//*****************************************************************************************************************************************//


string inputL = (Console.ReadLine());
string printAll = "Hello, " + inputL + "!";

Console.WriteLine(printAll);


//******************************************************************************************************************************//



//06. Concatenate Data


//   // read the input
string firstName = (Console.ReadLine());
string lastName = (Console.ReadLine());
int age = int.Parse(Console.ReadLine());
string city = (Console.ReadLine());


//   // get the result
Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {city}.");


//********************************************************************************************************************************************//



string userName = (Console.ReadLine());
int projects = int.Parse(Console.ReadLine());

int clock = projects * 3;

Console.WriteLine($"The architect {userName} will need {clock} hours to complete {projects} project/s.");


//*******************************************************************************************************************************************//


// //  08. Pet Shop


double dogFood = 2.50;
int dogI = int.Parse(Console.ReadLine());
int catFood = 4;
int catI = int.Parse(Console.ReadLine());

double dogSum = (dogFood * dogI);
double catSum = (catFood * catI);

double finalSum = dogSum + catSum;
Console.WriteLine($"{finalSum} lv.");


//********************************************************************************************************************************************//


//   09. Yard Greening



double kvMetri = double.Parse(Console.ReadLine());

double priceForAll  = kvMetri * 7.61;

double discountP = 0.18 * priceForAll;

double finalPrice = priceForAll - discountP;

//         // На конзолата се отпечатват два реда:
Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discountP} lv.");
