﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите три числа, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("max=");
Console.Write(max);