




using System;

int randomDay = int.Parse(Console.ReadLine());

switch (randomDay)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
    default: Console.WriteLine("Error"); break;
}


//**************************************************************************************************************************************************************//


//2.	Почивен или работен ден

string randomDay1 = Console.ReadLine();

switch (randomDay1) {

  case "Monday":
  case "Tuesday":
  case "Wednesday":
  case "Thursday":
  case "Friday": 
        Console.WriteLine("Working day"); break;
  case "Saturday":
  case "Sunday":
        Console.WriteLine("Weekend"); break;
  default: Console.WriteLine("Error"); break;
}


//*************************************************************************************************************************************************************//


//3.	Клас животно

string animal = Console.ReadLine();

 switch(animal) {
    case "dog": Console.WriteLine("mammal"); break;
    case "crocodile" :
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile"); break;
    default: Console.WriteLine("unknown"); break; 
}


//***************************************************************************************************************************************************************//



//04. Personal Titles //4.	Обръщение според възраст и пол

double ageOfPerson = double.Parse(Console.ReadLine());
string sexOfPerson = Console.ReadLine();

if (ageOfPerson < 16) {
    if (sexOfPerson == "f") {
         Console.WriteLine("Miss");
    } else if (sexOfPerson == "m") {
           Console.WriteLine("Master");
    } 
} else if (ageOfPerson >= 16) {
     if (sexOfPerson == "f") {
           Console.WriteLine("Ms.");
    } else if (sexOfPerson == "m") {
           Console.WriteLine("Mr.");
    } 
    } else {
       Console.WriteLine("djendar - X");
}



//***************************************************************************************************************************************************************//



//5.	Квартално магазинче // 05. Small Shop


string itemShop = Console.ReadLine();//coffee
string cityShop = Console.ReadLine();//Varna
double itemsSell = double.Parse(Console.ReadLine()); //2,7,8


if (cityShop == "Sofia")
{
    switch (itemShop)
    {
        case "coffee": double endPrice1 = (itemsSell * 0.50); Console.WriteLine(endPrice1); break;
        case "water": double endPrice2 = (itemsSell * 0.80); Console.WriteLine(endPrice2); break;
        case "beer": double endPrice3 = (itemsSell * 1.20); Console.WriteLine(endPrice3); break;
        case "sweets": double endPrice4 = (itemsSell * 1.45); Console.WriteLine(endPrice4); break;
        case "peanuts": double endPrice5 = (itemsSell * 1.60); Console.WriteLine(endPrice5); break;
        default: Console.WriteLine("Error"); break;
    }

}
else if (cityShop == "Plovdiv")
{
    switch (itemShop)
    {
        case "coffee": double endPrice1 = (itemsSell * 0.40); Console.WriteLine(endPrice1); break;
        case "water": double endPrice2 = (itemsSell * 0.70); Console.WriteLine(endPrice2); break;
        case "beer": double endPrice3 = (itemsSell * 1.15); Console.WriteLine(endPrice3); break;
        case "sweets": double endPrice4 = (itemsSell * 1.30); Console.WriteLine(endPrice4); break;
        case "peanuts": double endPrice5 = (itemsSell * 1.50); Console.WriteLine(endPrice5); break;
        default: Console.WriteLine("Error"); break;
    }

}
else if (cityShop == "Varna")
{
    switch (itemShop)
    {
        case "coffee": double endPrice1 = (itemsSell * 0.45); Console.WriteLine(endPrice1); break;
        case "water": double endPrice2 = (itemsSell * 0.70); Console.WriteLine(endPrice2); break;
        case "beer": double endPrice3 = (itemsSell * 1.10); Console.WriteLine(endPrice3); break;
        case "sweets": double endPrice4 = (itemsSell * 1.35); Console.WriteLine(endPrice4); break;
        case "peanuts": double endPrice5 = (itemsSell * 1.55); Console.WriteLine(endPrice5); break;
        default: Console.WriteLine("Error"); break;
    }
}



//******************************************************************************************************************************************************************************************************************************************



//6.	Число в интервалa


int numberInputUser = int.Parse(Console.ReadLine());

 if ((numberInputUser >= -100) && (numberInputUser <= 100) && (numberInputUser != 0)) {
    Console.WriteLine("Yes");
    } else {
    Console.WriteLine("No");
}



//*************************************************************************************************************************************************//


//07.Working Hours  //7.	Работно време

int openTime = int.Parse(Console.ReadLine());
string x = Console.ReadLine();
         

  if ((openTime >= 10) && (openTime <= 18)) {
       switch(x) {
                        case "Monday":
                         case "Tuesday":
                         case "Wednesday":
                         case "Thursday":
                         case "Friday": 
                         case "Saturday":
                                Console.WriteLine("open");  break;
                         case "Sunday":
                                Console.WriteLine("closed"); break;
                         default: Console.WriteLine("Error"); break;
                }       
         } else {
            Console.WriteLine("closed");
}


//***************************************************************************************************************************************************//




//8.	Билет за кино  // 08.Cinema Ticket


string dayX = Console.ReadLine();

         switch(dayX) {
                 case "Monday": Console.WriteLine("12");  break;
                 case "Tuesday": Console.WriteLine("12"); break;
                 case "Wednesday": Console.WriteLine("14");  break;
                 case "Thursday": Console.WriteLine("14"); break;
                 case "Friday": Console.WriteLine("12"); break;
                 case "Saturday": Console.WriteLine("16"); break;
                 case "Sunday": Console.WriteLine("16"); break;          
                 default: Console.WriteLine("Error"); break;
         }


//********************************************************************************************************************************************//


// 9.	Плод или зеленчук  // 09. Fruit or Vegetable

string fruits = Console.ReadLine();

         switch (fruits) {
                 case "banana": 
                 case "apple":
                 case "kiwi":
                 case "cherry":
                 case "lemon":
                 case "grapes": Console.WriteLine("fruit"); break;

                 case "tomato": 
                 case "cucumber":
                 case "pepper":
                 case "carrot": Console.WriteLine("vegetable"); break;  

                 default: Console.WriteLine("unknown"); break;
         }

//************************************************************************************************************************************************//


// 10. Invalid Number //10.	Невалидно число


int a = int.Parse(Console.ReadLine());


         if ((a != 0) && ((a <= 99) || (a >= 201))) {
                 Console.WriteLine("invalid");            
}  //else {
   //       Console.WriteLine("err");  
   // }



//*********************************************************************************************************************************************//



// 11.	Магазин за плодове


string itemX = Console.ReadLine();//apple
string deyX = Console.ReadLine();// Tuesday",
double itemNumberSell = double.Parse(Console.ReadLine());// 2,6,8,9,12


        switch (deyX) {
                         case "Monday": {
                                 switch(itemX){
                                     case "banana": double price1 = (itemNumberSell * 2.50); Console.WriteLine($"{price1:f2}"); break;  
                                     case "apple": double price2 = (itemNumberSell * 1.20); Console.WriteLine($"{price2:f2}"); break; 
                                     case "orange": double price3 = (itemNumberSell * 0.85); Console.WriteLine($"{price3:f2}"); break;
                                     case "grapefruit": double price4 = (itemNumberSell * 1.45); Console.WriteLine($"{price4:f2}"); break; 
                                     case "kiwi": double price5 = (itemNumberSell * 2.70); Console.WriteLine($"{price5:f2}"); break;
                                     case "pineapple": double price6 = (itemNumberSell * 5.50); Console.WriteLine($"{price6:f2}"); break; 
                                     case "grapes": double price7 = (itemNumberSell * 3.85); Console.WriteLine($"{price7:f2}"); break;
                                     default: Console.WriteLine("error"); break;
                                 }
                         }; break;
                         case "Tuesday": {
                                 switch(itemX){
                                         case "banana": double price1 = (itemNumberSell * 2.50); Console.WriteLine($"{price1:f2}"); break;  
                                         case "apple": double price2 = (itemNumberSell * 1.20); Console.WriteLine($"{price2:f2}"); break;
                                         case "orange": double price3 = (itemNumberSell * 0.85); Console.WriteLine($"{price3:f2}"); break;
                                         case "grapefruit": double price4 = (itemNumberSell * 1.45); Console.WriteLine($"{price4:f2}"); break; 
                                         case "kiwi": double price5 = (itemNumberSell * 2.70); Console.WriteLine($"{price5:f2}"); break;
                                         case "pineapple": double price6 = (itemNumberSell * 5.50); Console.WriteLine($"{price6:f2}"); break; 
                                         case "grapes": double price7 = (itemNumberSell * 3.85); Console.WriteLine($"{price7:f2}"); break;
                                         default: Console.WriteLine("error"); break;
            }
                             }; break;
                         case "Wednesday":  {
                                 switch(itemX){
                                         case "banana": double price1 = (itemNumberSell * 2.50); Console.WriteLine($"{price1:f2}"); break;  
                                         case "apple": double price2 = (itemNumberSell * 1.20); Console.WriteLine($"{price2:f2}"); break;
                                         case "orange": double price3 = (itemNumberSell * 0.85); Console.WriteLine($"{price3:f2}"); break;
                                         case "grapefruit": double price4 = (itemNumberSell * 1.45); Console.WriteLine($"{price4:f2}"); break; 
                                         case "kiwi": double price5 = (itemNumberSell * 2.70); Console.WriteLine($"{price5:f2}"); break;
                                         case "pineapple": double price6 = (itemNumberSell * 5.50); Console.WriteLine($"{price6:f2}"); break; 
                                         case "grapes": double price7 = (itemNumberSell * 3.85); Console.WriteLine($"{price7:f2}"); break;
                                         default: Console.WriteLine("error"); break;
            }
                             }; break;
                         case "Thursday":  {
                                 switch(itemX){
                                         case "banana": double price1 = (itemNumberSell * 2.50); Console.WriteLine($"{price1:f2}"); break;  
                                         case "apple": double price2 = (itemNumberSell * 1.20); Console.WriteLine($"{price2:f2}"); break;
                                         case "orange": double price3 = (itemNumberSell * 0.85); Console.WriteLine($"{price3:f2}"); break;
                                         case "grapefruit": double price4 = (itemNumberSell * 1.45); Console.WriteLine($"{price4:f2}"); break; 
                                         case "kiwi": double price5 = (itemNumberSell * 2.70); Console.WriteLine($"{price5:f2}"); break;
                                         case "pineapple": double price6 = (itemNumberSell * 5.50); Console.WriteLine($"{price6:f2}"); break; 
                                         case "grapes": double price7 = (itemNumberSell * 3.85); Console.WriteLine($"{price7:f2}"); break;
                                         default: Console.WriteLine("error"); break;
            }
                             }; break;
                         case "Friday": {
                                 switch(itemX){
                                         case "banana": double price1 = (itemNumberSell * 2.50); Console.WriteLine($"{price1:f2}"); break;  
                                         case "apple": double price2 = (itemNumberSell * 1.20); Console.WriteLine($"{price2:f2}"); break;
                                         case "orange": double price3 = (itemNumberSell * 0.85); Console.WriteLine($"{price3:f2}"); break;
                                         case "grapefruit": double price4 = (itemNumberSell * 1.45); Console.WriteLine($"{price4:f2}"); break; 
                                         case "kiwi": double price5 = (itemNumberSell * 2.70); Console.WriteLine($"{price5:f2}"); break;
                                         case "pineapple": double price6 = (itemNumberSell * 5.50); Console.WriteLine($"{price6:f2}"); break; 
                                         case "grapes": double price7 = (itemNumberSell * 3.85); Console.WriteLine($"{price7:f2}"); break;
                                         default: Console.WriteLine("error"); break;
            }
                             }; break;
                         case "Saturday":  {
                                 switch(itemX){
                                     case "banana": double price1 = (itemNumberSell * 2.70); Console.WriteLine($"{price1:f2}"); break;  
                                     case "apple": double price2 = (itemNumberSell * 1.25); Console.WriteLine($"{price2:f2}"); break;
                                     case "orange": double price3 = (itemNumberSell * 0.90); Console.WriteLine($"{price3:f2}"); break;
                                     case "grapefruit": double price4 = (itemNumberSell * 1.60); Console.WriteLine($"{price4:f2}"); break; 
                                     case "kiwi": double price5 = (itemNumberSell * 3.00); Console.WriteLine($"{price5:f2}"); break;
                                     case "pineapple": double price6 = (itemNumberSell * 5.60); Console.WriteLine($"{price6:f2}"); break; 
                                     case "grapes": double price7 = (itemNumberSell * 4.20); Console.WriteLine($"{price7:f2}"); break;
                                     default: Console.WriteLine("error"); break;
            }
                         }; break;
                         case "Sunday":   {
                                 switch(itemX){
                                         case "banana": double price1 = (itemNumberSell * 2.70); Console.WriteLine($"{price1:f2}"); break;  
                                         case "apple": double price2 = (itemNumberSell * 1.25); Console.WriteLine($"{price2:f2}"); break;
                                         case "orange": double price3 = (itemNumberSell * 0.90); Console.WriteLine($"{price3:f2}"); break;
                                         case "grapefruit": double price4 = (itemNumberSell * 1.60); Console.WriteLine($"{price4:f2}"); break; 
                                         case "kiwi": double price5 = (itemNumberSell * 3.00); Console.WriteLine($"{price5:f2}"); break;
                                         case "pineapple": double price6 = (itemNumberSell * 5.60); Console.WriteLine($"{price6:f2}"); break; 
                                         case "grapes": double price7 = (itemNumberSell * 4.20); Console.WriteLine($"{price7:f2}"); break;
                                         default: Console.WriteLine("error"); break;
            }
                            }; break;
                         default: Console.WriteLine("error"); break;
}



//*************************************************************************************************************************************************//



//  12. Trade Commissions   // 12.	Търговски комисионни


string cityX = Console.ReadLine();
double sellS = double.Parse(Console.ReadLine());


         switch (cityX) {
                 case "Sofia": {
                        if ((0 <= sellS) && (sellS <= 500)) {
                         double commissionX = sellS * 0.05;
                         Console.WriteLine($"{commissionX:f2}");
                        }
                        else if ((500 < sellS) && (sellS <= 1000)) {
                         double commissionX = sellS * 0.07;
                         Console.WriteLine($"{commissionX:f2}");
                        }
                        else if ((1000 < sellS) && (sellS <= 10000)) {
                         double commissionX = sellS * 0.08;
                         Console.WriteLine($"{commissionX:f2}");
                        }
                        else if(sellS > 10000) {
                         double commissionX = sellS * 0.12;
                         Console.WriteLine($"{commissionX:f2}");
                        } else {
                        Console.WriteLine("error");
                        }
                 } break;
                 case "Varna" : {
                         if ((0 <= sellS) && (sellS <= 500)) {
                          double commissionX = sellS * 0.045;
                          Console.WriteLine($"{commissionX:f2}");
                         }
                         else if ((500 < sellS) && (sellS <= 1000)) {
                          double commissionX = sellS * 0.075;
                          Console.WriteLine($"{commissionX:f2}");
                         }
                         else if ((1000 < sellS) && (sellS <= 10000)) {
                          double commissionX = sellS * 0.10;
                          Console.WriteLine($"{commissionX:f2}");
                         }
                         else if(sellS > 10000) {
                          double commissionX = sellS * 0.13;
                          Console.WriteLine($"{commissionX:f2}");
                         } else {
                         Console.WriteLine("error");
                         }
                  } break;
                 case "Plovdiv": {
                         if ((0 <= sellS) && (sellS <= 500)) {
                          double commissionX = sellS * 0.055;
                          Console.WriteLine($"{commissionX:f2}");
                          }
                         else if ((500 < sellS) && (sellS <= 1000)) {
                          double commissionX = sellS * 0.08;
                          Console.WriteLine($"{commissionX:f2}");
                          }
                         else if ((1000 < sellS) && (sellS <= 10000)) {
                          double commissionX = sellS * 0.12;
                          Console.WriteLine($"{commissionX:f2}");
                          }
                         else if(sellS > 10000) {
                          double commissionX = sellS * 0.145;
                          Console.WriteLine($"{commissionX:f2}");
                          } else {
                            Console.WriteLine("error");
                          }
                  } break;
                  default: Console.WriteLine("error"); break;

         }
