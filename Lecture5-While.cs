
//01. Read Text


using System;

string userInput = Console.ReadLine(); //"Nakov"

while (userInput != "Stop")
{ 
    Console.WriteLine($"{userInput}");
    userInput = Console.ReadLine();
}


//****************************************************************************************************************************************************//


//2.Парола /Password  --- първоначално прочита име и парола на потребителски профил. След това чете парола за вход. 

string username = Console.ReadLine(); //"Nakov"
        string password = Console.ReadLine();//"1234"
        string dataForMatchPassword = Console.ReadLine();//"Pass" //user input line


         while(dataForMatchPassword != password){ //"Pass" !== "1234"
             dataForMatchPassword = Console.ReadLine();
         }
        Console.WriteLine($"Welcome {username}!");


//****************************************************************************************************************************************************



// 03.Sum Numbers


      int maxNumber = int.Parse(Console.ReadLine());
      int sum = 0;
      int  i = 1;
      bool test = true;

    while (test) {
         int dataIn = int.Parse(Console.ReadLine());//"1"
         sum += dataIn; // x + 1    
     if(sum >= maxNumber){
            test = false;
             break;
         }   
     i++;
    }

Console.WriteLine($"{sum}");


//***********************************************************************************************************************************************


//  04. Sequence 2k+1  / Редица числа 2k + 1


     int n = int.Parse(Console.ReadLine());
     int k = 1;

     while (k <= n) {
        Console.WriteLine($"{k}");
        k = (k * 2) + 1;    
     }


//**********************************************************************************************************************************************



//!!! 05.Account Balance  < -----------------------------------------------


     string moneyInfo = Console.ReadLine(); //get is as 'string' to check for While condition
     double sum1 = 0.0;

     while(moneyInfo != "NoMoreMoney") {
    //    let dataIn = Number(moneyInfo);
          double dataIn = double.Parse(moneyInfo);

             if(dataIn < 0 ){
                 Console.WriteLine("Invalid operation!");
                 break;
            }

        Console.WriteLine($"Increase: {dataIn:f2}");
        sum1 += dataIn;

        moneyInfo = Console.ReadLine();
        }

Console.WriteLine($"Total: {sum1:f2}");
//console.log(`Total: ${sum.toFixed(2)}`);


//***********!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!********//

string input = Console.ReadLine();
double balance = 0.0;

while (input != "NoMoreMoney") {

    double amount = double.Parse(input);
    
    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {amount:f2}");
    balance += amount;

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {balance:f2}");



//****************************************************************************************************************************************************



// 06. Max Number  /6.	Най-голямо число


string numberX = Console.ReadLine();
int maxNumber = int.Parse(numberX);

         while(numberX != "Stop") {
             int searchX = int.Parse(numberX);

            if (searchX >maxNumber ){
                maxNumber = searchX;
            }


             numberX = Console.ReadLine();
         }
Console.WriteLine($"{maxNumber}");




//*********************************************************************************************************************************************************************************



// 07. Min Number /7.	Най-малко число 



string numberX = Console.ReadLine();
int minNumber = int.Parse(numberX);


         while(numberX != "Stop") {
             int searchX = int.Parse(numberX);

            if (searchX < minNumber) {
                minNumber = searchX;
            }

            numberX = Console.ReadLine();
         }

Console.WriteLine($"{minNumber}");




//*************************************************************************************************************************************************************************************



//100/100
//8.	Завършване  //08. Graduation


string nameStudent = Console.ReadLine();
double gradeX = 0.0;
double sumK = 0.0;
int failedYear = 0;
int classCount = 1;

     while (classCount <= 12){  


         gradeX = double.Parse(Console.ReadLine()); ; 

                 if (gradeX < 4.00){
                     failedYear++;
                         if(failedYear == 2){
                             Console.WriteLine($"{nameStudent} has been excluded at {classCount} grade");
                             break;
                         }
                     continue;
                 } 
         classCount++;
         sumK += gradeX;             
      }
             if (failedYear < 2) {
                Console.WriteLine($"{nameStudent} graduated. Average grade: {(sumK / 12):f2}");
             }