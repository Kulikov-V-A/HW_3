// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// long InputNum(string message)
// {
// Console.Write(message);
// return long.Parse(Console.ReadLine()!);
// }

// long ReverseNum(long number)
// {
// long reversedNum = 0;
// while (number != 0)
// {
// reversedNum = reversedNum * 10 + number % 10;
// number /= 10;
// }
// return reversedNum;
// }

// bool Palindrome(long num, long rev)
// {
// return num == rev;
// }

// long num = InputNum("Введите число: ");
// long rev = ReverseNum(num);
// bool res = Palindrome(num, rev);
// Console.WriteLine(res);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int xA = InputNum("Введите x для A: ");
// int yA = InputNum("Введите y для A: ");
// int zA = InputNum("Введите z для A: ");
// int xB = InputNum("Введите x для B: ");
// int yB = InputNum("Введите y для B: ");
// int zB = InputNum("Введите z для B: ");

// double Root(int xA, int yA, int zA, int xB, int yB, int zB)
// {
//     double res1 = Math.Pow(xB - xA, 2);
//     double res2 = Math.Pow(yB - yA, 2);
//     double res3 = Math.Pow(zB - zA, 2);
//     double res = Math.Sqrt(res1 + res2 + res3);
//     return res;
// }

// double distance = Root(xA, yA, zA, xB, yB, zB);
// Console.WriteLine(Math.Round(distance, 2));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите число N: ");

for(int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if(i < num)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
}


