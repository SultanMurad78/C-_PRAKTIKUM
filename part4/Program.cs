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

// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];

// int sumNum=0;
// int sumNegNum=0;

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(-9,10);
// System.Console.Write(array[i]+ " ");

// if(array[i]>0)
// {
// sumNum=sumNum+ array[i];
// }
// else
// {
// sumNegNum= sumNegNum +array[i];
// }
// }
// System.Console.WriteLine("Сумма полож.= "+ sumNum+ " отриц. = "+ sumNegNum);


// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[] {3,-21,9,-2};

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= array[i] *-1;
// System.Console.Write(array[i]+ " ");
// }



// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[6];

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// bool isFind= false;

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(-1,3);
// System.Console.Write(array[i]+ " ");

// if(array[i]== num)
// {
// isFind=true;
// }

// }

// if(isFind)
// {
// Console.Write("Да");
// }
// else
// {
// Console.Write("Нет");
// }





// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];

// int count=0;

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(-1,150);
// System.Console.Write(array[i]+ " ");

// if(array[i]>9 && array[i]<100)
// {
// count++;
// // count=count+1;
// }
// }
// System.Console.WriteLine("Количество = "+ count);






// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = new int[5];
// int countElErray1= array.Length;
// int[] array2 = new int[countElErray1/2 + countElErray1%2];

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(-1,10);
// System.Console.Write(array[i]+ " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
// {
// if(i == countElErray1-1-i)
// {
// array2[i]= array[i];
// System.Console.Write(array2[i]+ " ");
// break;
// }

// array2[i]= array[i] * array[countElErray1-1-i];
// System.Console.Write(array2[i]+ " ");

// }

// using System;

// public class Answer
// {
//     public static double FindMax(double[] array)
//     {     // Введите свое решение ниже
//        if (array == null) throw new ArgumentNullException(nameof(array));
//        if (array.Length == 0) return 0;
//        double maxValue = array[0];
//           for (int i = 1; i < array.Length; i++)
//           {
//             if (maxValue < array[i]) maxValue = array[i];
//           }
//         return maxValue;          
//     }

//     public static double FindMin(double[] array)
//     {     // Введите свое решение ниже
//         if (array == null) throw new ArgumentNullException(nameof(array));
//         if (array.Length == 0) return 0;

//         double minValue = array[0];

//         for(int i = 1; i < array.Length; i++)
//         {
//             if(minValue > array[i]) minValue = array[i];
//         }
//         return minValue;
//     }

//     public static double CalcDifferenceBetweenMaxMin(double[] array)
//     {// Введите свое решение ниже

//         return Math.Abs(FindMax(array) - FindMin(array));

//     }

//     public static void PrintArray(double[] array)
//     {// Введите свое решение ниже
//         foreach (var item in array)
//         {
//             Console.Write("{0:F2}", item);
//             Console.Write("\t");
//         }

//         Console.WriteLine();
//     }
//  // Не удаляйте и не меняйте метод Main! 


//     public static void Main(string[] args)
//     {
//         double[] array;
//         if (args.Length == 0)
//         {
//             array = new double[] { 3, 7.4, 22.3, 2, 78 };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в массив чисел
//             string[] argStrings = args[0].Split(", ");
//             array = new double[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (double.TryParse(argStrings[i], out double number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         double diff = CalcDifferenceBetweenMaxMin(array);
//         Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
//     }
// }



// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray (int m, int n)
// {
// int [,] array = new int[m,n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// }
// }

// return array;
// }

// void PrintArray(int[,] inputArray)
// {
// for (int i = 0; i < inputArray.GetLength(0); i++)
// {
// for (int j = 0; j < inputArray.GetLength(1); j++)
// {
// Console.Write(inputArray[i,j]);
// }
// Console.WriteLine();
// }
// }

// void ChangeArray(int[,] matrix)
// {
// int rowsCount = matrix.GetLength(0)-1;

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
// int temp = matrix[0,i];
// matrix[0,i] =matrix[rowsCount,i];
// matrix[rowsCount,i]= temp;
// }
// }

// int[,] array2= GetArray(rows,columns);
// PrintArray(array2);
// ChangeArray(array2);
// System.Console.WriteLine();
// PrintArray(array2);



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,rows];
// int [,] array2 = new int[rows,rows];

// int[,] GetArray (int [,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// }
// }

// return array;
// }

// void PrintArray(int[,] inputArray)
// {
// for (int i = 0; i < inputArray.GetLength(0); i++)
// {
// for (int j = 0; j < inputArray.GetLength(1); j++)
// {
// Console.Write(inputArray[i,j]);
// }
// Console.WriteLine();
// }
// }

// void ChangeArray(int[,] matrix,int[,] matrix2 )
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix2[j,i]= matrix[i,j];
// }
// }
// }

// GetArray(array);
// PrintArray(array);
// ChangeArray(array,array2);
// System.Console.WriteLine();
// PrintArray(array2);


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// if(rows != columns)
// {
// System.Console.WriteLine("Введите правильные числа");
// return;
// }

// int [,] array = new int[rows,columns];
// int [,] array2 = new int[rows,columns];

// int[,] GetArray (int [,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// }
// }

// return array;
// }

// void PrintArray(int[,] inputArray)
// {
// for (int i = 0; i < inputArray.GetLength(0); i++)
// {
// for (int j = 0; j < inputArray.GetLength(1); j++)
// {
// Console.Write(inputArray[i,j]);
// }
// Console.WriteLine();
// }
// }

// void ChangeArray(int[,] matrix,int[,] matrix2 )
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix2[j,i]= matrix[i,j];
// }
// }
// }

// GetArray(array);
// PrintArray(array);
// ChangeArray(array,array2);
// System.Console.WriteLine();
// PrintArray(array2);



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:


// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minValue= int.MaxValue;
// int minRows=0;
// int minColumns= 0;

// int[,] GetArray (int m, int n)
// {
// int [,] array = new int[m,n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);

// if(array[i,j] <minValue)
// {
// minValue = array[i,j];
// minRows= i;
// minColumns = j;
// }
// }
// }

// return array;
// }

// void PrintArray(int[,] inputArray)
// {
// for (int i = 0; i < inputArray.GetLength(0); i++)
// {
// for (int j = 0; j < inputArray.GetLength(1); j++)
// {
// Console.Write(inputArray[i,j]);
// }
// Console.WriteLine();
// }
// }

// void ChangeArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// if (minRows!= i && minColumns!=j)
// {
// Console.Write(matrix[i,j]);
// }
// }
// Console.WriteLine();
// }
// }

// int[,] array2= GetArray(rows,columns);
// PrintArray(array2);
// System.Console.WriteLine();
// ChangeArray(array2);