
char[] RuLetter = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц','ъ','ь', 'ч', 'ш', 'щ' , 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы' };
char[] EnLetter = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', };
List <bool> cheks = new List <bool> ();
int count = 0;
bool result=true;
void Funk()
{
    Console.WriteLine("Введите предложение");
    string enter = Console.ReadLine();
    char[] a = enter.ToCharArray();

        foreach (char c2 in RuLetter)
        {

        if (!a.Contains(c2))
        {
            result = false;
            break;
        }
            //foreach (char c3 in RuLetter)
            //{


            //    if (c2 == c3)
            //    {
                
            //    count++;
            //    }
            //    else
            //    {
                    
            //    }
            //}
        
        }
        if(result==true)
        {
            Console.WriteLine($"да");
        }
    else
    {
        Console.WriteLine("нет");
    }
}
void hgu()
{

}
Funk();
