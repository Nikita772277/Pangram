bool result = true;
Menu();
void Menu()
{
    while (true)
    {
        Console.WriteLine("Выберите язык (Select a language)");
        Console.WriteLine("1. Русский (Russian)");
        Console.WriteLine("2. Английский (English)");
        Console.WriteLine();
        string choice = Console.ReadLine();
        bool check = int.TryParse(choice, out int number);
        if (check == true)
        {
            if (number == 1)
            {
                RuPangram();
            }
            else if (number == 2)
            {
                EnPangram();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Выберите пункт из меню");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine();
        }
    }
}
void RuPangram()
{
    char[] RuLetter = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ъ', 'ь', 'ч', 'ш', 'щ', 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы' };
    Console.WriteLine("Введите предложение");
    string enter = Console.ReadLine();
    char[] a = enter.ToCharArray();
    foreach (char c in RuLetter)
    {

        if (!a.Contains(c))
        {
            result = false;
            break;
        }
    }
    if (result == true)
    {
        Console.WriteLine();
        Console.WriteLine($"Предложение панграмма");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Предложение не панграмма");
        Console.WriteLine();
    }
}
void EnPangram()
{
    char[] EnLetter = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', };

    Console.WriteLine("Enter a suggestion");
    string enter = Console.ReadLine();
    char[] a = enter.ToCharArray();
    foreach (char c in EnLetter)
    {

        if (!a.Contains(c))
        {
            result = false;
            break;
        }
    }
    if (result == true)
    {
        Console.WriteLine();
        Console.WriteLine($"Pangram offer");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("The offer is not a pangram");
        Console.WriteLine();
    }
}