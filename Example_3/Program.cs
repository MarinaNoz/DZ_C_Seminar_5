// Задайте массив вещественных чисел. Найдите разницу между макс. и миним. элементом массива

Console.WriteLine(" Введите количество элементов массива " );
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrayLength];
FillArray(numbers);
WriteArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
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
int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

for (int i = 0; i <numbers.Length; i++)
{
    if (numbers[i] < minNumber)
        minNumber = numbers[i];
    if (numbers[i] > maxNumber)
        maxNumber = numbers[i];
    
}
Console.WriteLine($"Разница: " +(maxNumber-minNumber));

