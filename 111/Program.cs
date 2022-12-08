// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитечисло В,степень");
int B =Convert.ToInt32(Console.ReadLine());
int S=1;
for (int i=1;i<=B;i++)
{
S=S*A;
}
Console.WriteLine($"Число {A} в степени {B} равно {S}");
