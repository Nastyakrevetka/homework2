//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели: ");
int chislo1 = int.Parse(Console.ReadLine());
if (chislo1<8 && (chislo1==6 || chislo1==7))
     Console.Write($"{chislo1} -> да");  
else
{
Console.Write($"{chislo1} -> нет");
}
