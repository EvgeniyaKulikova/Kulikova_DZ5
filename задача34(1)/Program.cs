// Задача 34(1) Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] NewArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(min, max + 1);
    }
    return array;

}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " " );
    }
    Console.WriteLine();
}

int FindSum_Even (int [] array )
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array [i] % 2 == 0)
        {
            sum += array [i];
        }
       
    }
    return sum;
}

Console.Write("imput count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("imput minimal possible three-digit number on array: ");
int minArray = Convert.ToInt32(Console.ReadLine());


Console.Write("imput maximal possible three-digit number on array: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

if (minArray > 99 & minArray < 1000 & maxArray > 99 & minArray < 1000 & minArray < maxArray)
{
    int [] createdArray = NewArray (sizeArray, minArray,maxArray);
    ShowArray (createdArray);
    int ressum = FindSum_Even (createdArray);
    Console.Write ($"Sum of even-numbers is {ressum}");
}
else
Console.Write("impossible value, try again");



