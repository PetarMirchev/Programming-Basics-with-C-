

// 01. Number Pyramid

int n = int.Parse(Console.ReadLine());

int row = 1;
int current = 1;

while (current <= n)
{
    for (int i = 0; i < row; i++)
    {
        Console.Write($"{current} ");
        if (++current > n) break;
    }

    row++;
    Console.WriteLine();
}


//***************************************************************************************************************************************





// 02.Equal Sums Even Odd Position


int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    int evenSum = 0, oddSum = 0;
    bool isEven = true;

    int num = i;
    while (num != 0)
    {
        int digit = num % 10;
        if (isEven) evenSum += digit;
        else oddSum += digit;

        isEven = !isEven;
        num /= 10;
    }

    if (evenSum == oddSum) Console.Write($"{i} ");
}

Console.WriteLine();




//****************************************************************************************************************************************


// 03. Sum Prime Non Prime



int primeSum = 0;
int nonPrimeSum = 0;

string command = Console.ReadLine();


while (command != "stop")
{
    int number = int.Parse(command);

    if (number < 0) {
        Console.WriteLine("Number is negative.");
        }
    else {
        bool isPrime = true;
        double numSqrt = Math.Sqrt(number);
        for (int i = 2; i <= numSqrt; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            primeSum += number;
        }
        else
        {
            nonPrimeSum += number;
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");




//****************************************************************************************************************************************




// 04. Train The Trainers


int juries = int.Parse(Console.ReadLine());

double presentationScoresSum = 0;
int presentationsCount = 0;

string presentationName = Console.ReadLine();

while (presentationName != "Finish")
{
    double currentScoresSum = 0;
    for (int i = 0; i < juries; i++)
    {
        double juryScore = double.Parse(Console.ReadLine());
        currentScoresSum += juryScore;
    }

    double grade = currentScoresSum / juries;
    Console.WriteLine($"{presentationName} - {grade:f2}.");

    presentationScoresSum += grade;
    presentationsCount++;

    presentationName = Console.ReadLine();
}

double averageAssessment = presentationScoresSum / presentationsCount;
Console.WriteLine($"Student's final assessment is {averageAssessment:f2}.");



//***************************************************************************************************************************************




// 05.Special Numbers


int n = int.Parse(Console.ReadLine());

for (int i1 = 1; i1 <= 9; i1++)
{
    if (n % i1 != 0) continue;

    for (int i2 = 1; i2 <= 9; i2++)
    {
        if (n % i2 != 0) continue;

        for (int i3 = 1; i3 <= 9; i3++)
        {
            if (n % i3 != 0) continue;

            for (int i4 = 1; i4 <= 9; i4++)
            {
                if (n % i4 != 0) continue;

                Console.Write($"{i1}{i2}{i3}{i4} ");
            }
        }
    }
}

Console.WriteLine();



//***********************************************************************************************************************************




// 06. Cinema Tickets


string movie = Console.ReadLine();

int totalSoldTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while (movie != "Finish")
{
    int freeSeats = int.Parse(Console.ReadLine());
    string ticketType = Console.ReadLine();

    int soldTicketsForCurrentMovie = 0;
    while (ticketType != "End")
    {
        if (ticketType == "student")
        {
            studentTickets++;
        }
        else if (ticketType == "standard")
        {
            standardTickets++;
        }
        else if (ticketType == "kid")
        {
            kidTickets++;
        }

        soldTicketsForCurrentMovie++;
        if (soldTicketsForCurrentMovie >= freeSeats)
        {
            break;
        }

        ticketType = Console.ReadLine();
    }

    totalSoldTickets += soldTicketsForCurrentMovie;

    double usagePercentage = (double)soldTicketsForCurrentMovie / freeSeats * 100;
    Console.WriteLine($"{movie} - {usagePercentage:f2}% full.");

    movie = Console.ReadLine();
}

double studentTicketsPercentage = (double)studentTickets / totalSoldTickets * 100;
double standardTicketsPercentage = (double)standardTickets / totalSoldTickets * 100;
double kidTicketsPercentage = (double)kidTickets / totalSoldTickets * 100;

Console.WriteLine($"Total tickets: {totalSoldTickets}");
Console.WriteLine($"{studentTicketsPercentage:f2}% student tickets.");
Console.WriteLine($"{standardTicketsPercentage:f2}% standard tickets.");
Console.WriteLine($"{kidTicketsPercentage:f2}% kids tickets.");