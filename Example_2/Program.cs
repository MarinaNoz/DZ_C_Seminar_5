// Задайте одномерный массив, заполненный случайными числами. 
//Найдие сумму элементов, стоящих на нечетных позициях.

Console.WriteLine(" Введите количество элементов массива " );
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrayLength];
FillArray(numbers);
WriteArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
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
int sumOddElements = 0;
for (int i = 0; i <numbers.Length; i++)
{
    if(i %2 == 1)
    { 
       sumOddElements += numbers[i];
    }
}
Console.WriteLine($"Сумма нечетных элементов: " +sumOddElements);
