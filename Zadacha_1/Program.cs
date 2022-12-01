// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write(num1);
}
else
{
    Console.Write(num2);
}