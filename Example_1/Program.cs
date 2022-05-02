// Задайте массив, заполненный случайными положительными трехзначными числами. 
// Написать программу, которая покажет количество четных числе в массиве.

Console.WriteLine(" Введите количество элементов массива " );
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrayLength];
FillArray(numbers);
WriteArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int evenNumbers = 0;
for (int i = 0; i <numbers.Length; i++)
{
    if(numbers[i] %2 == 0)
    { 
       evenNumbers = evenNumbers+1;
    }
}
Console.WriteLine($" Количество четных элементов: " +evenNumbers);