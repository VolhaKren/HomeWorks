/*
//Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(int number)
{
    int second = number / 10 % 10;
    return second;
}

Console.WriteLine("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);
Console.WriteLine($"The second number of number {num} is {result}");
*/


//Task 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber (int number)
{
    int i = 0;
    int third = 0;

    while(i >= 1000)
    {
        third = number % 10;
        i = i-1;
        if(i < 100)
        {
            Console.WriteLine("The third number is absent.");
        }
        else
        {
            third = number % 10;
        }
    }
    return third;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumber(num);
Console.WriteLine($"The third number of number {num} is {result}");



/*
//Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayOff(int number)
{
    if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Input a number of a day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = DayOff(num);
Console.WriteLine(result);
*/