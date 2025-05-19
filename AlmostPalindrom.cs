class AlmostPalindrom
{
    /* УСЛОВИЕ ЗАДАЧИ
     *Недавно Кирилл нашел строку из четырех символов. Ему стало интересно, является ли она почти палиндромом. Строка называется почти палиндромом, если из нее можно удалить один символ, чтобы она читалась слева направо также, как и справа налево.
      Помогите Кириллу это проверить.
    Формат входных данных
    В единственной строке входных данных дается строка из четырех латинских символов.
    Формат выходных данных
    Выведите , если строка является почти палиндромом,  в ином случае.
    */
    static void Main()
    {
        string word = Console.ReadLine(); //вводим слово
        bool found = false;
        
        if (word.Length != 4)
            throw new ArgumentException();
        

        for (int i = 0; i < 4; i++)
        {
            var newWord = word.Remove(i, 1);
            if (IsPalindrom(newWord))
            {
                Console.WriteLine("YES");
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine("NO");
    }

    static bool IsPalindrom(string word) => word.Equals(Reverse(word)); 
    
    //можно было и LINQ, но возможно я подзабыл какой то нюанс и программа в любом случак возвращала NO, я переписал метод
    private static string Reverse(string text) 
    {
        char[] cArray = text.ToCharArray();
        string reverse = "";
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

}
