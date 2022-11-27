# HomeWorks
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int RaiseToPower (int numberA, int numberB)
{
    int result = 1;
    for (int current = 1; current <= numberB; current++)
        result = result * numberA;
    return result;
}

Console.Write("Input a numberA: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a numberB: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result of numbers {a} and {b} power is {RaiseToPower(a, b)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindSum(int number)
{
    int num = number;
    int sum = 0;
    while (number > 0 && number % 10 != 0)
    {
        if (num % (number % 10))
            sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result between numbers is {FindSum(a)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a numbers of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
*/
