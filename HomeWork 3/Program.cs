// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Input a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(num);
Console.WriteLine(result);

bool Palindrome(int number)
{
    int number;
    int i = 0;

    if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}


// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;
}

Console.WriteLine("Input the x coordinates of the first point: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the y coordinates of the first point: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the z coordinates of the first point: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the x coordinates of the second point: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the y coordinates of the second point: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the z coordinates of the second point: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"The distance is {res}");
*/

// Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.Write(current*current*current + " ");
        current++;
    }
}

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/