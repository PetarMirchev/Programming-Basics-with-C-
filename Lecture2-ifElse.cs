


double grade = double.Parse(Console.ReadLine());

if (grade >= 5.50)
{
    Console.WriteLine("Excellent!");
}


//***********************************************************************************************************************************************************//




int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());


if (firstNumber > secondNumber) {
    Console.WriteLine(firstNumber);
} else {
    Console.WriteLine(secondNumber);
}


//**************************************************************************************************************************************************************//




int num = int.Parse(Console.ReadLine());
bool isNumberEven = num % 2 == 0;

if (isNumberEven) {
    Console.WriteLine("even");
}else {
    Console.WriteLine("odd");
 };


//*********************************************************************************************************************************************************//


// //4.	Познай паролата


string x = Console.ReadLine();
string z2 = "s3cr3t!P@ssw0rd";


if (x == z2) {
    Console.WriteLine("Welcome");
} else {
    Console.WriteLine("Wrong password!");
}


//****************************************************************************************************************************************************************//

//5.	Число от 100 до 200

int xX = int.Parse(Console.ReadLine());

    if (xX < 100) {
        Console.WriteLine("Less than 100");
    } else if (xX <= 200){
            if (100 <= xX)
        {
                Console.WriteLine("Between 100 and 200");
             }      
    } else if (201 <= xX) {
        Console.WriteLine("Greater than 200");
    }


//********************************************************************************************************************************************************* //

// 6.Информация за скоростта


            double xXx = double.Parse(Console.ReadLine());
//        // y = Math.trunc(x);

//         // •	При скорост до 10 (включително) отпечатайте "slow"
         if (xXx <= 10) {
                Console.WriteLine("slow");
         }
//         // •	При скорост над 10 и до 50 (включително) отпечатайте "average" 
         else if (10.1 <= xXx && xXx <= 50){ 
                Console.WriteLine("average");
          }
//         // •	При скорост над 50 и до 150 (включително) отпечатайте "fast"
          else if (50.1 <= xXx && xXx <= 150) {
                Console.WriteLine("fast");  
}
//         // •	При скорост над 150 и до 1000 (включително) отпечатайте "ultra fast" 
         else if (150.1 <= xXx && xXx <= 1000) {
                Console.WriteLine("ultra fast"); 
} 
//        // •	При по-висока скорост отпечатайте "extremely fast" 
         else if (  1000.1 <= xXx) {
                Console.WriteLine("extremely fast");
}


//***************************************************************************************************************************************************************//


// smetki na figuri  -- 7 или 9 задача от лекциите упр-та



string type = Console.ReadLine();

if (type == "square")
{
    double a = double.Parse(Console.ReadLine());
    double area = a * a;
    Console.WriteLine(area);
}
else if (type == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double area = a * b;
    Console.WriteLine(area);
}
else if (type == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double area = (a * h) / 2;
    Console.WriteLine(area);
}
else if (type == "circle") {   // лице на кръг
    double r = double.Parse(Console.ReadLine());
    //пи (3.14)  * r на квадрат
     double area = Math.PI * Math.Pow(r, 2);
     Console.WriteLine(area);
}

