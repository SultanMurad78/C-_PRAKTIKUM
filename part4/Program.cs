// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// int n =49;
// double result= Math.Sqrt(48);

// double res= Math.Pow(-3,3);
// System.Console.WriteLine(res);

// Console.WriteLine("Введите число");
// int x1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y2= Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2));

// Console.WriteLine(d);




// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int i = 1;

//  while(i<=num)
//  {
//     Console.WriteLine(Math.Pow(i,2));
//     i=i+1;
//  }



// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }



// какой то пример для самостоятельного разбора
// using System;
// //using System.Collections.Generic;
// //using System.Linq;
// //using System.Text;
// //using System.Threading.Tasks;

// namespace cSharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(СonvertString() + " - сконвертированное число");
//             Console.ReadKey();
//         }

//         private int СonvertString()
//         {
//             string userInputString;
//             int userInputInt = 0;
//             bool wasNumberConverted = false;

//             Console.WriteLine("Введите строку для конвертации");

//             while (wasNumberConverted == false)
//             {
//                 userInputString = Console.ReadLine();

//                 if (int.TryParse(userInputString, out int ConvertedUserInput))
//                 {
//                     Console.WriteLine("Конвертация прошла успешно");
//                     userInputInt = ConvertedUserInput;
//                     wasNumberConverted = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Конвертация не удалась");
//                     wasNumberConverted = false;
//                 }
//             }

//             return userInputInt;
//         }
//     }
// }

