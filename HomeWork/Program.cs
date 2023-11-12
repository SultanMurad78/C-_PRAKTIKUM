// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100 || num >=1000){Console.WriteLine("Вы ввели не трехзначное число!");}

// int result = num /10 % 10;
// Console.WriteLine(result);

//________________________________________________________________________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100){Console.WriteLine("В введённом вами числе третьей цирфы нет!");}
// else{while (num > 999){num /= 10;} num %= 10; Console.WriteLine(num);}


//________________________________________________________________________________________________________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0 && num <= 5){Console.WriteLine("Увы, это рабочий день недели!");}
// else if (num > 5 && num <= 7){Console.WriteLine("Ура! выходный день недели!");}
// else {Console.WriteLine("Такого дня недели нет!");}

//________________________________________________________________________________________________________________________________________________________________________________

<<<<<<< HEAD

// Домашнее задание 5
// ЗАДАЧА 1 

// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
// Аргументы передаваемые в метод
// '124, 378, 593, 821, 456'

// На выходе
// Массив:
// 124     378     593     821     456 
// Количество четных элементов: 3



// using System;

// public class Answer
// {
//     public static int CountEvenElements(int[] array)
//     {
//         int count = 0;
//         foreach (int number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

//     public static void PrintArray(int[] array)
//     {
//       for (int i = 0; i < array.Length; i++)
//       {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         {
//         Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         }
//       }
//         Console.WriteLine();
//     }

//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
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
//         int evenCount = CountEvenElements(array);
//         Console.WriteLine($"Количество четных элементов: {evenCount}");
//     }
// }





// Задача 2. Сумма нечетных элементов массива

// Напишите программу, которая находит сумму элементов с нечетными 
// индексами в одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, который принимает 
// массив целых чисел и возвращает сумму элементов с нечетными индексами 
// в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы 
// массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Аргументы, передаваемые в метод/функцию:
// '18, 76, 11'
// На выходе:
// 18      76      11  
// Сумма нечетных элементов: 76

// using System;

// public class Answer
// {
//     public static int SumOddElements(int[] array)
//     {
//         int sum = 0;
//         for (int i = 1; i < array.Length; i = i + 2)
//         {
//             sum += array[i];
//         }
//         return sum;
//     }

//     public static void PrintArray(int[] array)
//     {
//       for (int i = 0; i < array.Length; i++)
//       {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         {
//         Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         }
//       }
//         Console.WriteLine();
//     }


//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем массив по умолчанию
//             array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
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

//         PrintArray(array);
//         int sumOdd = SumOddElements(array);
//         Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
//     }
// }






//Задание 3
// Разница между максимальным и минимальным элементами массива
// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические
//  методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных 
// чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных 
// чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход
// массив вещественных чисел array и возвращает разницу между
// максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран.
// Он принимает на вход массив array и выводит его элементы с двумя 
// знаками после запятой через табуляцию.
// Аргументы, передаваемые в метод/функцию:

// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:
// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

// using System;

// public class Answer
// {
//     public static double FindMax(double[] array)
//     {
//         double max = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (max < array[i])
//             {
//                 max = array[i];
//             }
//         }
//         return max;
//     }

//     public static double FindMin(double[] array)
//     {
//         double min = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (min > array[i])
//             {
//                 min = array[i];
//             }
//         }
//         return min;
//     }

//     public static double CalcDifferenceBetweenMaxMin(double[] array)
//     {
//         return FindMax(array) - FindMin(array);
//     }

//     public static void PrintArray(double[] array)
//     {
//       for (int i = 0; i < array.Length; i++)
//       {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         {
//         Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         }
//       }
//         Console.WriteLine();
//     }

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

=======
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//  Console.WriteLine("Введите число");
//  int a= Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число");
//  int b= Convert.ToInt32(Console.ReadLine());

//  int GetSumNum()
//  {

//      int i = 1;
//      int result = a;

//      while(i<b)
//      {
//          result= result * a;
//          i++;
//      }

//      return result;
//  }
//  System.Console.WriteLine(GetSumNum());

//________________________________________________________________________________________________________________________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//  Console.WriteLine("Введите число");
//  string a = Console.ReadLine();
//  int sum = 0;

//  for (int i = 0; i < a.Length; i++)
//  {sum += int.Parse(a[i].ToString());} 

//  Console.WriteLine("Сумма цифр числа: " + a + " = " + sum);

//______________________________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    Console.Write(message); 
    string ReadInput = Console.ReadLine(); 
    int result = int.Parse(ReadInput); 
    return result; 
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; 
    Random random = new Random(); 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); 
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", "); 
    }
    Console.WriteLine(array[array.Length - 1] + "]");     
}

int length = Prompt("Введите длинну массива: "); 
int min = Prompt("Начальное значение, для диапазона случайных чисел: "); 
int max = Prompt("Конечное значение, для диапазона случайных чисел: ");
int[] array = GenerateArray(length, min, max); 
PrintArray(array);
>>>>>>> 4451a5dd2766f012cae622559c366bb843e4b094
