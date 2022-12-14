//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int chislo1 = int.Parse(Console.ReadLine());
int num = chislo1;
if (chislo1<100)
{
 Console.Write($"{num} -> третьей цифры нет");  
}
else 
{
while (chislo1>999)
{
 chislo1 = chislo1/10;
}
int num3 = chislo1 %10;
Console.Write($"{num} -> {num3}");
}