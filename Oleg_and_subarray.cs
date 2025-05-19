using System;
using System.Collections.Generic;
class Oleg_and_subarray
{
    /* УСЛОВИЯ ЗАДАЧИ
     У мальчика Олега сегодня День Рождения, ему исполняется 10 лет. 
    Так как 10 лет особый возраст, то родители подарили ему особый подарок: массив из чисел от 1 до 10. 
    Обрадовавшись такому подарку, он сразу начал изучать его свойства.
Недавно на прогулке друзья рассказали Олегу о арифметических прогрессиях. 
    Для изучения свойств массива Олег решил начать с чего-то малого, а именно с арифметических прогрессий длиной 3. 
    Три числа  образуют арифметическую прогрессию, если  Оказалось, 
    что не все подотрезки массива могут содержать такие арифметические прогрессии, 
    поэтому Олег решил вначале узнать, сколько существует подотрезков, в которых можно выбрать три числа,
    не меняя их порядок, с нужным свойством.
    */
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        string[] input = (Console.ReadLine()).Split(" ");
        var array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        var list = new List<(int, int)>();
        for (int left = 0; left < n - 4; left++)
        {
            for (int right = n - 1; right >= left + 2; right--)
            {
                for (int i = left; i < right; i++)
                {
                    var first = array[i];
                    var second = array[i + 1];
                    var third = array[i + 2];
                    if (second - first == third - second && !list.Contains((left, right)))
                    {
                        list.Add((left,right));
                        break;
                    }
                }
            }
        }
    

        Console.WriteLine(list.Count);
    }

}