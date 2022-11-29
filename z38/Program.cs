/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

FillArrayRandomNumbers(array);
PrintArray(array);
double min = array[0];
double max = array[0];

 for (int i=0;i<array.Length-1;i++)
    {
        for (int j=i+1;j<array.Length;j++)
        {
            if(array[j]<array[i] && array[j]<min) 
            {min=array[j];}
            if(array[j]>array[i] && array[j]>max) 
            {max=array[j];}
        }   
    }

double diff=Math.Round((max-min),2);
Console.WriteLine();
Console.WriteLine($"Max -> {max} | Min -> {min} | Разница -> {diff}");


void FillArrayRandomNumbers(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = Math.Round(Convert.ToDouble(new Random().Next(0,10) + new Random().NextDouble()),2);
}
}

void PrintArray(double[] array)
{
    Console.Write("[  ");
    for (int i=0;i<array.Length;i++)
    {Console.Write($"{array[i]}  ");}
    Console.Write("] -> ");
}