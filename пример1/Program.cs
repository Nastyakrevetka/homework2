//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число: ");
int chislo1 = int.Parse(Console.ReadLine());
if (chislo1>99 && chislo1<1000)
{
 int num2 = chislo1/10;
     num2 = num2%10;
 Console.Write($"{chislo1} -> {num2}");  
}
else
{
Console.Write("введите трехзначное число");
}
