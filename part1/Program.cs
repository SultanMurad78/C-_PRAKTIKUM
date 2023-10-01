// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = num * num;
// Console.WriteLine(num2);

// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("понедельник");
// }

// else if (num == 2)
// {
//     Console.WriteLine("вторник");
// }

// else if (num == 3)
// {
//     Console.WriteLine("среда");
// }

// else if (num == 4)
// {
//     Console.WriteLine("четверг");
// }

// else if (num == 5)
// {
//     Console.WriteLine("Пятница");
// }

// else if (num == 6)
// {
//     Console.WriteLine("Суббота");
// }

// else if (num == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// else
// {
//     Console.WriteLine("Такого дня недели нет");
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int negNum = -1 * num;

// while (negNum <= num)
// {
//     Console.WriteLine(negNum);
//         negNum++;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num % 10;
// Console.WriteLine(num1);
 
 
 // Семинар 2

//int num = new Random().Next(10, 100);

// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num % 10;

// if (num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }


// int num = new Random().Next(100, 1000);

// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;

// int result = num1*10 + num2;

// Console.WriteLine(result);


// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("Да, кратно");
// }
// else
// {
//     Console.WriteLine("не кратно, " + num1 % num2);         //канкатинация      \t табуляция   \n переход на новую строку
//     Console.WriteLine($"{num1} не кратно, {num1%num2}");    //интерполяция
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num % 7 == 0) && (num % 23 == 0))      // && - И           || - Или
// {
//     Console.WriteLine("Да, кратно");
// }
// else
// {
//     Console.WriteLine("не кратно, ");
// }




// int num1 = new Random().Next(100,1000);
// Console.WriteLine(num1);
// int num2 = new Random().Next(100,1000);
// Console.WriteLine(num2);
// // int num1 = 5;
// // int num2 = 25;

// if (num1 == num2 * num2 || num2 == num1 * num1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// using System;

// public class Answer 
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if(firstNumber < secondNumber)
//         {
//             Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber +"`");
//         }
//         else if (firstNumber == secondNumber)
//         {
//             Console.WriteLine("Введенные числа равны `" +  secondNumber + "`"); 
//         }
//         else if (firstNumber > secondNumber)
//         {
//             Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
//         }
//     }
// // Не удаляйте и не меняйте метод Main! 
//  static public void Main(string[] args) 
// {
// int firstNumber, secondNumber;
// if (args.Length >= 2) 
// {
//     firstNumber = int.Parse(args[0]);
//     secondNumber = int.Parse(args[1]);
// }
// else 
// {           // Здесь вы можете поменять значения для отправки кода на Выполнение
//     firstNumber = 5;
//     secondNumber = 7;
// }
//     CompareNumbers(firstNumber, secondNumber);
// }
// }



// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//         // Введите свое решение ниже
//         if (a > b && a > c){return a;}
//         if (b > a && b > c){return b;}
//         else return c;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 15;
//            b = 9;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }



// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).


// number = 4 -> Число 4 чётное

// number = 3 -> Число 3 нечётное

// number = 7 -> Число 7 нечётное

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//         // Введите свое решение ниже
//         if(number % 2 == 0){Console.WriteLine("Число " + number + " чётное");}
//         else{ Console.WriteLine("Число " + number + " нечётное");}
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 9;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.


// number = 5 -> 2    4

// number = 8 -> 2    4    6    8

using System; 
 
public class Answer { 
    static void PrintEvenNumbers(int number) 
    { 
      // Введите свое решение ниже  
      int start = 1; 
      while (start <= number) 
      { 
        if(start % 2 == 0) 
        { 
          Console.Write(start + "\t"); 
          start++; 
        }     
      }
 
    } 
 
 
  // Не удаляйте и не меняйте метод Main!  
    static public void Main(string[]args) { 
        int number; 
 
        if (args.Length >= 1) { 
            number = int.Parse(args[0]); 
        } else { 
           // Здесь вы можете поменять значения для отправки кода на Выполнение 
            number = 6; 
        } 
 
        // Не удаляйте строки ниже 
        PrintEvenNumbers(number); 
    }

}