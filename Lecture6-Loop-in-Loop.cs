//   Вложени цикли   lecture

//1.	Часовник


   for (int i = 0; i <= 23; i++) {
     for (int j = 0; j <= 59; j++) {
        Console.WriteLine($"{i}:{j}");
     }
   }




//************************************************************************************************************************************



// 02. Multiplication Table


   for (int x = 1; x <= 10; x++) {
     for (int y = 1; y <= 10; y++) {
       int product = x * y;
        Console.WriteLine($"{x} * {y} = {product}");
     }
   }





//***************************************************************************************************************************************



//03. Combinations

int n = int.Parse(Console.ReadLine());
   int validCombinationsCount = 0;

   //x1 + x2 + x3 = n
   for (int x1 = 0; x1 <= n; x1++) {
     for (int x2 = 0; x2 <= n; x2++) {
       for (int x3 = 0; x3 <= n; x3++) {
         int sum = x1 + x2 + x3;
         if (n == sum) {
           validCombinationsCount++;
         }
       }
     }
   }
Console.WriteLine($"{validCombinationsCount}");


//***************************************************************************************************************************************//



//4.	Сума от две числа   /04. Sum of Two Numbers


int n1Number = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
   int combinations = 0;
   bool isFound = false;
   bool notFoundNumber = true;

   for (int i = n1Number; i <= endNumber; i++) {
     for (int j = n1Number; j <= endNumber; j++) {
       combinations++;
       if (i + j == magicNumber) {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
         isFound = true;
         notFoundNumber = false;
         break;
       }
     }
     if (isFound) {
       break;
     }
   }
   if (notFoundNumber) {
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
   }



//****************************************************************************************************************************


//5.	Пътуване    /05. Traveling


string destination = Console.ReadLine();
while (destination != "End")
{
    double minBudget = double.Parse(Console.ReadLine());

    double savedMoney = 0;
    while (savedMoney < minBudget) savedMoney += double.Parse(Console.ReadLine());

    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}


//**************************************************************************************************************************************




//06. Building


int flor = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());


   for (int florNumber = flor; 1 <= florNumber; florNumber--) {
   //апартамент , офиси и т.н.
     string roomType = "";

     if (florNumber == flor) {  // top flor
       roomType += 'L';
     } else if (florNumber % 2 == 0) {//а четните само офиси.
       roomType += 'O';
     } else {  // апартамент 
       roomType += 'A';
     }

     //всички стаи на 1 етаж изписани/отпечатани на 1 ред (обходен цикъла)
     string allRoomsIn1FlorPrinted = "";
     for (int roomNumber = 0; roomNumber < rooms; roomNumber++) {
       //натрупване на всички стаи на 1 етаж изписани на 1 ред
       allRoomsIn1FlorPrinted = allRoomsIn1FlorPrinted + $"{roomType}{florNumber}{roomNumber}" + " ";
     }

    Console.WriteLine($"{allRoomsIn1FlorPrinted}");
   }
