// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 28
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел для ввода: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

for(int i = 0; i < N; i++)
{
    System.Console.WriteLine($"Введите {i+1}-е число: ");
    if(Convert.ToInt32(Console.ReadLine()) > 0) count++;
}

System.Console.WriteLine("Количество введенных положительных чисел = "+count);