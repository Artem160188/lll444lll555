// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int SumN (int n)
{
   int sum = 0;
while (n > 0)
{
    sum = sum + n%10;
    n = n/10;
} 
return sum;
}
Console.WriteLine($"Сумма цифр числа равна {SumN(n)}");
