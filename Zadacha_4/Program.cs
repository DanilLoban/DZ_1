﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N; i++) 
{
if(i % 2 == 0)
Console.Write(i);
}

