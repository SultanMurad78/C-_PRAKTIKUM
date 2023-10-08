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
