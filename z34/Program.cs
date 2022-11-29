/*Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];

FillArrayRandomNumbers(numbers, 100, 1000);
PrintArray(numbers);

int count=0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine(count);



void FillArrayRandomNumbers(int[] array, int min, int max)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
}
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length;i++)
    {Console.Write($"{numbers[i]} ");}
    Console.Write("] -> ");
}
