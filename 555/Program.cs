// Задача 26. - HARD необязательная Напишите программу, которая 
// принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
Console.Write("Введите число : ");
  int num=int.Parse(Console.ReadLine());
  int i=0;
  while(num>0) {
   i++;
   num/=10;
  }
  Console.WriteLine("Количество цифр введенного числа : {0}", i);
  Console.ReadKey();
  return 0;
 
// n = int(input("Введите число:"))
// count = 0
// while(n > 0):
//     count = count + 1
//     n = n // 10
// print("Количество цифр равно:", count)