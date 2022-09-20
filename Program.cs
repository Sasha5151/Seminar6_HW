﻿// Урок 6. Двумерные массивы и рекурсия

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 8;
Console.WriteLine($"Введите {M} чисел: ");
int count = 0;
for (int i = 1; i <= M; i++)
{
    Console.Write($"Введите число {i}: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями 
// // y = k1 * x + b1,
// // y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5,
// // b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double DataEntry(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// double b1 = DataEntry ("Введите значение b1 : ");
// double k1 = DataEntry ("Введите значение k1 : ");
// double b2 = DataEntry ("Введите значение b2 : ");
// double k2 = DataEntry ("Введите значение k2 : ");


// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

// //End