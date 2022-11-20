// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(8);

//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int NumbersSum(int a, int b)
{
    if (a == b)
        return a;
    else
        return NumbersSum(a + 1, b) + a;
}
Console.WriteLine();
Console.WriteLine("Sum = " + NumbersSum(4,8));


//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    if (m == 0)
        return n + 1;
    return 0;
}
Console.WriteLine(Ackermann(2,4));

