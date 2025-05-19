using System;
using System.Linq;
using System.Collections.Generic;
class Petya_and_array
{
    /* УСЛОВИЕ ЗАДАЧИ
     Петя играл на чердаке и нашел в сундуке запылившийся массив целых чисел.
    Пете показалось, что в этом массиве слишком много одинаковых элементов, и его нужно как-то разнообразить. 
    Петя еще не ходит в школу, поэтому он умеет только делить числа на 2 с округлением вниз. 
    Теперь его интересует, сколько различных элементов он может сделать, если он может сколько угодно раз проделывать изменения. 
    После применения операции элемент заменяется на полученное число.
     */
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var arr = a.OrderByDescending(n => n);
        var used = new HashSet<int>();

        foreach (int num in arr)
        {
            int current = num;
            while (current > 0)
            {
                if (!used.Contains(current))
                {
                    used.Add(current);
                    break;
                }
                current /= 2;

                if (current == 0 && !used.Contains(0))
                    used.Add(current);
            }
        }

        Console.WriteLine(used.Count);
    }
}