




//01. Old Books  / 1.	Старата Библиотека


using System;

string bookToLookFor = Console.ReadLine();

int booksCount = 0;
bool isFound = false;

string input = Console.ReadLine();
while (input != "No More Books")
{
    if (input == bookToLookFor)
    {
        isFound = true;
        break;
    }

    booksCount++;
    input = Console.ReadLine();
}

if (isFound)
{
    Console.WriteLine($"You checked {booksCount} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {booksCount} books.");
}



//***********************************************************************************************************************************************//




// 02. Exam Preparation


int maxBadGradesCount = int.Parse(Console.ReadLine());

int currentBadGradesCount = 0, sum = 0, count = 0;
bool isSuccessful = true;

string input = Console.ReadLine(), lastProblem = string.Empty;

while (input != "Enough")
{
    int grade = int.Parse(Console.ReadLine());

    sum += grade;
    count++;
    lastProblem = input;

    if (grade <= 4)
    {
        currentBadGradesCount++;
        if (currentBadGradesCount == maxBadGradesCount)
        {
            isSuccessful = false;
            break;
        }
    }

    input = Console.ReadLine();
}

if (isSuccessful)
{
    Console.WriteLine($"Average score: {1.0 * sum / count:f2}");
    Console.WriteLine($"Number of problems: {count}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
else
{
    Console.WriteLine($"You need a break, {currentBadGradesCount} poor grades.");
}



//**************************************************************************************************************************************************//



// 03. Vacation


    double moneyForVacation = double.Parse(Console.ReadLine());
    double moneyInBankAccount = double.Parse(Console.ReadLine());
     int dyes = 0;
     int spendDyes = 0;

     while (moneyInBankAccount < moneyForVacation) {
              dyes++;
        string moneyAction = Console.ReadLine();
        double moneyTransaction = double.Parse(Console.ReadLine());


        if (moneyAction == "spend") {
             moneyInBankAccount -= moneyTransaction;
             spendDyes++;
             if (spendDyes == 5) {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{dyes}");
                break;
             }
             if (moneyInBankAccount < 0) {
                 moneyInBankAccount = 0;
             }

         } else if (moneyAction == "save") {
             spendDyes = 0;
             moneyInBankAccount += moneyTransaction;
              }
     }

     if (moneyForVacation <= moneyInBankAccount ) {
        Console.WriteLine($"You saved the money for {dyes} days.");
     }




//************************************************************************************************************************



// 4. Стъпки    //04. Walking


const int goalLimit = 10000;
int totalSteps = 0;
bool shouldContinue = true;
bool goalIsReached = false;

while (shouldContinue && !goalIsReached)
{
    string input = Console.ReadLine();

    int currentSteps;
    if (input == "Going home")
    {
        currentSteps = int.Parse(Console.ReadLine());
        shouldContinue = false;
    }
    else currentSteps = int.Parse(input);

    totalSteps += currentSteps;
    if (totalSteps >= goalLimit)
    {
        goalIsReached = true;
    }
}

if (goalIsReached)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - goalLimit} steps over the goal!");
}
else Console.WriteLine($"{goalLimit - totalSteps} more steps to reach goal.");




//************************************************************************************************************************





// 5.  Монети  / 05. Coins   /най-малко монети ресто.


    double restore = double.Parse(Console.ReadLine());
    double coins = Math.Floor(restore * 100); // ako ne se prasne dava otklonenie i vremeto se vdiga pri obrabotka
     int coinsCount = 0;

     while (coins > 0) {
         if(coins >= 200){
             coins = coins - 200;
             coinsCount++;
         } else if(coins >= 100){
             coins = coins - 100;
             coinsCount++;
         } else if(coins >= 50) {
             coins = coins - 50;
             coinsCount++;
         } else if(coins >= 20) {
             coins = coins - 20;
             coinsCount++;
         } else if(coins >= 10) {
             coins = coins - 10;
             coinsCount++;
         } else if(coins >= 5) {
             coins = coins - 5;
             coinsCount++;
         } else if(coins >= 2){
             coins = coins - 2;
             coinsCount++;
         }else if(coins >= 1){
             coins = coins - 1;
             coinsCount++;
         }
     }

Console.WriteLine($"{coinsCount}");



//**************************************************************************************************************************




 //6.  Торта /06. Cake


    int sizeX1 = int.Parse(Console.ReadLine());
    int sizeX2 = int.Parse(Console.ReadLine());
     int sizeCake = sizeX1 * sizeX2;

    string command = Console.ReadLine();
    int numPieces = 0;

     while (command != "STOP") {
         int cakeParts = int.Parse(command);
         numPieces += cakeParts;

         if (numPieces > sizeCake){
            Console.WriteLine($"No more cake left! You need {numPieces - sizeCake} pieces more.");
             break;
         }

         command = Console.ReadLine();
     }

     if ((command == "STOP") && (numPieces <= sizeCake)){
        Console.WriteLine($"{sizeCake - numPieces} pieces are left.");
     }




//**********************************************************************************************************************************************************************





// 7.	Преместване  // 07. Moving



    int w = int.Parse(Console.ReadLine());
    int l = int.Parse(Console.ReadLine());
    int h = int.Parse(Console.ReadLine());

     //: Един кашон е с точни размери:  1m. x 1m. x 1m. 10 * 10 * 2 = 200 кубични метра налични
     int totalFreeSpaceBox = w * l * h;

    int cubMeters = 0;

    string boxCommand = Console.ReadLine();

    while (boxCommand != "Done") {
         int boxSpace = int.Parse(boxCommand);
         cubMeters += boxSpace;

         if(cubMeters > totalFreeSpaceBox){
            Console.WriteLine($"No more free space! You need {cubMeters - totalFreeSpaceBox} Cubic meters more.");
             break;
         }

            boxCommand = Console.ReadLine();
    }

     if (totalFreeSpaceBox > cubMeters) {
        Console.WriteLine($"{totalFreeSpaceBox - cubMeters} Cubic meters left.");
     }
