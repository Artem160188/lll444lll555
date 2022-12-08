// Задача 29: Напишите программу, которая задаёт массив
//  из 8 элементов с клавиатуры и выводит массив на экран.
int[] myArray = new int[8];
for (int i=0;i<myArray.Length;i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
} 
Console.WriteLine("Вывод массива:");

for (int i=0; i<myArray.Length;i++)
{
    Console.WriteLine(myArray[i]);
}
