using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        var n = int.Parse(input[0]);
        var a = long.Parse(input[1]);
        var b = long.Parse(input[2]);
        var s = Console.ReadLine();

        var d1 = 0;
        var balance = 0;
        foreach (char c in s)
        {
            balance += (c == '(') ? 1 : -1;
            if (balance < 0)
            {
                d1++;
                balance = 0;
            }
        }

        var d2 = 0;
        balance = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            balance += (s[i] == ')') ? 1 : -1;
            if (balance < 0)
            {
                d2++;
                balance = 0;
            }
        }

        var changes = (d1 + d2) / 2;
        var cost = changes * Math.Min(a, 2 * b);
        Console.WriteLine(cost);
    }
}