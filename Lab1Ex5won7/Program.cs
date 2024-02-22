/*Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele
doua valori in ordine crescatoare.
• Exemplu: citim 9,0 Afisam : 0 9*/


Console.WriteLine("Introduce primul numar: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce a doilea numar: ");
int y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Numere in ordine crescatore sunt: ");

if (x > y)
{
    if (y > x)
        Console.WriteLine($"{x}, {y} ");

    else if (x > y)
        Console.WriteLine($"{y}, {x}");

    else
        Console.WriteLine($"{x}, {y}");
    
}
else if (y > x)
{
    if (y > x)
    {
        if (y > x)
            Console.WriteLine($"{x}, {y} ");

        else
            Console.WriteLine($"{x}, {y}");
    }
}

Console.ReadLine();


