/*Задача 36: Задайте одномерный массив,
 заполненный случайными числами. Найдите 
 сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];

FillArrayRandomNumbers(numbers, -100, 100);
PrintArray(numbers);

int sum=0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i%2!=0)
    {
        sum+=numbers[i];
    }
}
Console.WriteLine(sum);


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
