using System.Runtime.CompilerServices;
using System;
class TrainStations
{
    /* УСЛОВИЕ ЗАДАЧИ
    Егор с друзьями гуляли по городу N и нашли карту метро. В этом городе целых  веток метро, у каждой ветки свое расписание. 
    Изучив расписание, они обнаружили, что по ветке  поезд начинает ходить в  секунду с начала дня,
    и каждый новый поезд начинает маршрут после предыдущего спустя  секунд. 
    Теперь им захотелось научиться в некоторые моменты времени для ветки и времени определять, 
    когда они увидят поезд после прихода на станцию.
    Формат входных данных
    В первой строке входных данных дано число   количество веток в городе .
    В следующих  строках даны числа  первый момент, когда поезд с i-й ветки приезжает на станцию, и промежуток между поездами 
    В следующей строке дано число  количество запросов 
    В следующих  строках даны числа  номер ветки и момент времени, когда друзья придут на станцию 
    Формат выходных данных
    Для каждого запроса выведите в отдельной строке ответ на задачу.
    */
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //кол-во станций
        var stationsTiming = new int[n,2];
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            stationsTiming[i, 0] = int.Parse(input.Split(" ")[0]); //когда выходит первый поезд
            stationsTiming[i, 1] = int.Parse(input.Split(" ")[1]); //промежуток между поездами
        }
        int q = int.Parse(Console.ReadLine()); //кол-во запросов
        var questionsArray = new int[q, 2];
        for (int i = 0;i < q; i++) // DRY сегодня не работает, я слишком волнуюсь :)))
        {
            var input = Console.ReadLine();
            questionsArray[i, 0] = int.Parse(input.Split(" ")[0]) - 1; //станция
            questionsArray[i, 1] = int.Parse(input.Split(" ")[1]); //момент, когда ребята придут на станцию
        }
        for (int i = 0;i<q;i++)
        {
            var station = questionsArray[i, 0];
            var timing = questionsArray[i, 1];
            Console.WriteLine(TimingProcessing(station, timing, stationsTiming));
        }

    }

    private static int TimingProcessing(int station, int timing, int[,] stationTiming)
    {
        var finallyTiming = stationTiming[station,0];
        if ( timing < stationTiming[station,0] ) //граничный случай
            return stationTiming[station,0];
        do
        {
            finallyTiming += stationTiming[station, 1];
        } while (finallyTiming < timing);
        return finallyTiming;
    }
}
