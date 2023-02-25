// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int Sum_odd_numbers (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array [i];
        }
       
    }
    return sum;
}
Console.Write("imput count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("imput minimal on array: ");
int minArray = Convert.ToInt32(Console.ReadLine());


Console.Write("imput maximal number on array: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

if (minArray < maxArray)
{
     int [] createdArray = NewArray (sizeArray, minArray,maxArray);
    ShowArray (createdArray);
    int ressum = Sum_odd_numbers (createdArray);
    Console.Write ($"Sum of odd-numbers is {ressum}");
}
else
Console.Write("impossible value, try again");
