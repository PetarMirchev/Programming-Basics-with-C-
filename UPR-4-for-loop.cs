
//01. Numbers Ending in 7

using System.Xml.Linq;

for ( int i = 7; i <= 997; i++ )
     {
         if ( i % 10 == 7 )
         {
                Console.WriteLine($"{i}");
            }
     }


//***********************************************************************************************************************************************************



// 02. Half Sum Element


int n = int.Parse(Console.ReadLine());
int big = int.Parse(Console.ReadLine());
int sum = big;
for (int i = 2; i <= n; i++)
{
    int a = int.Parse(Console.ReadLine());
    sum = sum + a;
    if (a > big) big = a;
}
if (big == (sum - big))
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + big);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + Math.Abs(big - (sum - big)));
}



//************************************************************************************************************************************************************




// 03. Histogram

double p1 = 0.0;
double p2 = 0.0;
double p3 = 0.0;
double p4 = 0.0;
double p5 = 0.0;
int num;
var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    num = int.Parse(Console.ReadLine());

    if (num < 200)
    {
        p1 += 1;
    }
    else
    {
        if (num >= 200 && num < 400)
        {
            p2 += 1;
        }
        else
        {
            if (num >= 400 && num < 600)
            {
                p3 += 1;
            }
            else
            {
                if (num >= 600 && num < 800)
                {
                    p4 += 1;
                }
                else
                {
                    if (num >= 800)
                    {
                        p5 += 1;
                    }
                }
            }
        }
    }
}


p1 = (p1 / n) * 100;
Console.WriteLine("{0:f2}%", p1);
p2 = (p2 / n) * 100;
Console.WriteLine("{0:f2}%", p2);
p3 = (p3 / n) * 100;
Console.WriteLine("{0:f2}%", p3);
p4 = (p4 / n) * 100;
Console.WriteLine("{0:f2}%", p4);
p5 = (p5 / n) * 100;
Console.WriteLine("{0:f2}%", p5);



//********************************************************************************************************************************************************//




//04. Clever Lily 


var lilisAge = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
var singleToyPrice = int.Parse(Console.ReadLine());


     int toysCounter = 0;
     double saveMoney = 0;
     double stolenMoney = 0;

     double addMoney = 10;


     for (int currentAge = 1; currentAge <=  lilisAge;  currentAge++ ){
         if(currentAge % 2 == 0){
//             //money
             saveMoney += addMoney;
             addMoney += 10;
             stolenMoney++;
         }else {
//             //toys
             toysCounter++;
         }
     }

     double totalMoneyFromToys = singleToyPrice * toysCounter;
     double totalSavedMoney = totalMoneyFromToys + saveMoney - stolenMoney;

     if (totalSavedMoney >= washingMachinePrice) {
        double result1 = totalSavedMoney - washingMachinePrice;
        Console.WriteLine($"Yes! {result1:f2}");
     } else {
        double result2 = washingMachinePrice - totalSavedMoney;
        Console.WriteLine($"No! {result2:f2}");
     }


//*************************************************************************************************************************************************************


// 05. Salary

// Според отворения сайт в таба се налагат следните глоби:
// •	"Facebook" -> 150 лв.
// •	"Instagram" -> 100 лв.
// •	"Reddit" -> 50 лв.

         int openTabs = int.Parse(Console.ReadLine());
         double salary = double.Parse(Console.ReadLine());

        // check for the end of open tabs (index <= input.length)
        for (int index = 1; index <= openTabs; index++) {

             string currentTabs = Console.ReadLine();

             switch (currentTabs) {
                 case "Facebook": salary = salary - 150; break;
                 case "Instagram": salary = salary - 100; break;
                 case "Reddit": salary = salary - 50; break;
                 default:  break;
             }

             if (salary <= 0) {
                Console.WriteLine($"You have lost your salary.");
                 break;
             }
         }

         if (salary > 0) {
            Console.WriteLine($"{Math.Floor(salary)}");
         }


//***********************************************************************************************************************//



// 06. Oscars

    string testedActorName = Console.ReadLine();//Zahari Baharov
    double startedActorPoints = double.Parse(Console.ReadLine());//205
    int numberOfJury = int.Parse(Console.ReadLine());//4

    double totalScore = startedActorPoints; //205

         for (int i = 0; i < numberOfJury; i++) {
             string currentJudgeName = Console.ReadLine();
             double currentJudgeScore = double.Parse(Console.ReadLine());

             totalScore += (currentJudgeName.Length * currentJudgeScore) / 2;

             if (totalScore >= 1250.5) {
                 Console.WriteLine($"Congratulations, {testedActorName} got a nominee for leading role with {totalScore:F1}!");
                 break;
             }
         }

        if (totalScore < 1250.5) {
             Console.WriteLine($"Sorry, {testedActorName} you need {1250.5 - totalScore:F1} more!");
        }


//***********************************************************************************************************************



//7.	Трекинг мания  //07. Trekking Mania

int groups = int.Parse(Console.ReadLine());
     int group1 = 0;
     int group2 = 0;
     int group3 = 0;
     int group4 = 0;
     int group5 = 0;   
     int totalPeople = 0;

    for (int i = 1; i <= groups; i++) {
             int currentNumberGroup = int.Parse(Console.ReadLine());

    //Общ брой хора: 25 + 41 + 31 + 250 + 6 = 353
    //totalPeople = totalPeople + currentNumberGroup;
    totalPeople += currentNumberGroup;


    // •	Група до 5 човека – изкачват Мусала
    if ((currentNumberGroup <= 5 ) && (0 <= currentNumberGroup) ){
             group1 += currentNumberGroup;

         // •	Група от 6 до 12 човека – изкачват Монблан
         }else if ((6  <= currentNumberGroup ) && (currentNumberGroup <= 12)) {
             group2 += currentNumberGroup;

          // •	Група от 13 до 25 човека – изкачват Килиманджаро
         }else if((13 <= currentNumberGroup) && (currentNumberGroup <= 25)) {
             group3 += currentNumberGroup;

         // •	Група от 26 до 40 човека –  изкачват К2    
         }else if ((26 <= currentNumberGroup) && (currentNumberGroup <= 40)) {
             group4 += currentNumberGroup;

         // •	Група от 41 или повече човека – изкачват Еверест
         }else if (41 <= currentNumberGroup){
             group5 += currentNumberGroup;
         }

     }

// console.log(`totalPeople:` + totalPeople); //Общ брой хора: 25 + 41 + 31 + 250 + 6 = 353
Console.WriteLine($"{(double)group1 / totalPeople * 100:f2}%");//Изкачващи Мусала: 0 / 353 * 100 = 0.00%
Console.WriteLine($"{(double)group2 / totalPeople * 100:f2}%");//Изкачващи Монблан: 6 / 353 * 100 = 1.78%
Console.WriteLine($"{(double)group3 / totalPeople * 100:f2}%");//Изкачващи Килиманджаро: 25 / 353 * 100 = 7.08%
Console.WriteLine($"{(double)group4 / totalPeople * 100:f2}%");// Изкачващи К2: 31 / 353 * 100 = 8.78%
Console.WriteLine($"{(double)group5 / totalPeople * 100:f2}%");//Изкачващи Еверест: 291 / 353 * 100 = 82.44%

//console.log(`${((group1 / totalPeople) * 100).toFixed(2)}%`); 
//console.log(`${((group2/ totalPeople) * 100).toFixed(2)}%`);
//console.log(`${((group3/ totalPeople) * 100).toFixed(2)}%`);
//console.log(`${((group4/ totalPeople) * 100).toFixed(2)}%`);
//console.log(`${((group5/ totalPeople) * 100).toFixed(2)}%`);



//********************************************************************************************************************//



//8.	Световна ранглиста по тенис    // 08. Tennis Ranklist


 // Брой турнири, в които е участвал – цяло число в интервала [1…20] 
 // Начален брой точки в ранглистата - цяло число в интервала [1...4000]
 // За всеки турнир се прочита отделен ред: Достигнат етап от турнира – текст – "W", "F" или "SF"

int numberTurnirs = int.Parse(Console.ReadLine());
int pointsStartRanklist = int.Parse(Console.ReadLine());

  double pointsStageAcheved = 0;
  int wins = 0;


     // check for the end of array (i < input.length)  "F","SF","W","W","SF"]);
     for (int i = 1; i <= numberTurnirs; i++) {
    //      let currentStage = input[i];
            string currentStage = Console.ReadLine();
         //Console.WriteLine(currentStage);

         switch (currentStage) {
             case "F": pointsStageAcheved += 1200; break;
             case "SF": pointsStageAcheved += 720; break;
             case "W": pointsStageAcheved += 2000; wins++;  break;
             default: pointsStageAcheved += 0; break;
    }
     }


Console.WriteLine($"Final points: {pointsStartRanklist + pointsStageAcheved}");
Console.WriteLine($"Average points: {Math.Floor(pointsStageAcheved / numberTurnirs)}");
Console.WriteLine($"{((double)wins / numberTurnirs) * 100:f2}%");
//     console.log(`Final points: ${pointsStartRanklist + pointsStageAcheved}`);
//     console.log(`Average points: ${Math.floor(pointsStageAcheved/numberTurnirs)}`);
//     console.log(`${((wins/numberTurnirs)*100).toFixed(2)}%`);