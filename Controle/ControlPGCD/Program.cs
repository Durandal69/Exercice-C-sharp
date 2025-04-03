int a, b;
{
    Console.Write("Entrez le premier nombre : ");
    if (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
    {
        Console.WriteLine("Veuillez entrer un nombre entier positif.");
        return;
    }

    Console.Write("Entrez le deuxième nombre : ");
    if (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
    {
        Console.WriteLine("Veuillez entrer un nombre entier positif.");
        return;
    }

    int pgcd = CalculerPGCD(a, b);

    Console.WriteLine($"\nPGCD({a}, {b}) = {pgcd}");

    Console.ReadKey();
}

static int CalculerPGCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
