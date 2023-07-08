// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void Task10()
{
    int nom = Convert.ToInt32(Console.ReadLine());

    int a = nom / 10;
    int result = a % 10;

    Console.WriteLine($"{result} - требуемое число");

}

Task10();


int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task13()
{
    int nom_2 = Input("Вводим число:");
    if(nom_2 / 100 ==0)
    {
        Console.WriteLine("No");
    }
    else if( (nom_2 / 100) < 10 & (nom_2/100) > 0 ) 
    {
        int result = nom_2 / 100;
        Console.WriteLine($"{result} - требуемое число");
    }
    else if (nom_2 / 100 >= 10)
    {
        int a = nom_2 / 100;
        int result = a % 10;
        Console.WriteLine($"{result} - требуемое число");
    }
}
Task13();

void Task15()
{
    int day = Input("Вводим число:");
    if (day <= 7 & day >= 1)
    {
        Console.WriteLine("Это неделя обычного человека");
        if (day <= 7 & day > 5)
        {
            Console.WriteLine("УРА!!! ВЫХОДНОЙ!!!");

        }
        else
        {
             Console.WriteLine("НА РАБОТУ, ДОРОГОЙ МОЙ!!!");
        }
    }
    else 
    {
        Console.WriteLine("К ПСИХИАТРУ, ДОРОГОЙ МОЙ!!!");
    }
}
Task15();