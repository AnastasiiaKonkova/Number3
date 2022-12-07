// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void polindrom (int num)
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
polindrom(newnum);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.