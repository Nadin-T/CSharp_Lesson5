﻿int Fact (int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: n = {n}");
        return 1;
    }
    Console.WriteLine($"n = {n}");
    return n * Fact(n - 1);
}

Console.WriteLine(Fact(5));


//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следующей точки)