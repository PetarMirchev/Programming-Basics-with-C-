using System;
using System.Diagnostics.Metrics;

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}


//*******************************************************************************************************************************************************//



int n = int.Parse(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
    Console.WriteLine(i);
}


//**************************************************************************************************************************************************************//

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i += 3)
{

Console.WriteLine(i);
}



//**************************************************************************************************************************************************************//



//04. Even Powers of 2

int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i += 2)
{
    Console.WriteLine(Math.Pow(2, i));
}



//**************************************************************************************************************************************************************//


//05. Character Sequence


string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    char letter = input[i];
    Console.WriteLine(letter);
}


//**************************************************************************************************************************************************************//

// 6.	Сумиране на гласните букви


string word = Console.ReadLine();

int sum = 0;

     for (int i= 0; i < word.Length; i++ ) {

    // let currentCharacter = word.charAt(i);
            Char currentCharacter = word[i];

             switch(currentCharacter) {
                 case 'a': sum += 1; break;
                 case 'e': sum += 2; break;
                 case 'i': sum += 3; break;
                 case 'o': sum += 4; break;
                 case 'u': sum += 5; break;  
                 default: break;
    }
     }
Console.WriteLine(sum);



//*************************************************************************************************************************************************************



// 07. Sum Numbers // 7.	Сумиране на числа



int n = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    totalSum += number;
}

Console.WriteLine(totalSum);


//************************************************************************************************************************************************************




//08. Number sequence


int countNumbers = int.Parse(Console.ReadLine());

int biggestNum = int.MinValue;
int smallestNum = int.MaxValue;

for (int i = 0; i < countNumbers; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (biggestNum < number)
    {
        biggestNum = number;
    }
    if (smallestNum > number)
    {
        smallestNum = number;
    }
}
Console.WriteLine($"Max number: {biggestNum}");
Console.WriteLine($"Min number: {smallestNum}");



///*********************************************************************************************************************************************************



// 09.Left and Right Sum


int n = int.Parse(Console.ReadLine());

int leftSum = 0;
for (int i = 0; i < n; i++)
{
    leftSum += int.Parse(Console.ReadLine());
}

int rightSum = 0;
for (int i = 0; i < n; i++)
{
    rightSum += int.Parse(Console.ReadLine());
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int diff = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {diff}");
}


//*************************************************************************************************************************************************************



// 10.Odd Even Sum

int n = int.Parse(Console.ReadLine());

int evenSum = 0;
int oddSum = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i % 2 == 0) 
    {
        evenSum += number;
    }
    else if (i % 2 != 0)
    {
        oddSum += number;
    }
}


if (evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else if (evenSum != oddSum)
{
    int finsum = Math.Abs(oddSum - evenSum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {finsum}");
}