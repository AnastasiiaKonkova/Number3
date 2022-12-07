// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* 
void palindrom (int num)
{
    int PerNum = 0;
    int delta = Math.Abs(num);
    while(delta > 0)
    {
        PerNum = PerNum * 10 + delta % 10;
        delta = delta/10;
    }
    if (Math.Abs(num) == PerNum)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }    
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
palindrom(newnum);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double xA, double yA, double zA,double xB, double yB, double zB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));
    return length;
}
Console.Write("Введите х - координаты точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите у - координаты точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z - координаты точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х - координаты точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y - координаты точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z - координаты точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, yA,zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками в 3D пространстве составляет {distanceBetweenAB}.");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* void kyb ( int num)
{
    int temp = 1;
    while (temp <= num)
    {
    Console.Write(Math.Pow(temp,3) + " ");
    temp ++;
    }
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кубы от 1 до "+ newnum + ": ");
kyb (newnum);
*/