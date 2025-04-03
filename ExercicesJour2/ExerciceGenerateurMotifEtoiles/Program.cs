// Jour 2 Exercice 2 : Générateur de motifs en étoiles


Console.WriteLine("Quel motif voulez-vous ?");
Console.WriteLine("Tapez 1 pour un triangle rectangle.");
Console.WriteLine("Tapez 2 pour un triangle isocèle.");
Console.WriteLine("Tapez 3 pour un carré plein.");
Console.WriteLine("Tapez 4 pour un carré vide.");
Console.WriteLine("Tapez 5 pour un damier.");
int choixMotif = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Combien d'étages voulez-vous ? ");
int nbEtage = Convert.ToInt32(Console.ReadLine());
string b = "*";
int nbespace = nbEtage - 1;

if (choixMotif == 1)
{
    for (int etage = 1; etage <= nbEtage; etage++)
    {
        if (etage == 1)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine("*" + b);
            b += "*";
        }
        nbespace--;
    }
}
else if (choixMotif == 2)
{
    for (int etage = 1; etage <= nbEtage; etage++)
    {
            Console.WriteLine(new string(' ', nbespace) + b);
            b += "**";
            nbespace--;        
    }
}
else if (choixMotif == 3)
{
    for (int etage = 1; etage <= nbEtage; etage++)
    {
        Console.WriteLine(new string('*', nbEtage * 2));
    }
}
else if (choixMotif == 4)
{
    Console.WriteLine(new string('*', nbEtage * 2));
    for (int etage = 1; etage <= nbEtage - 2; etage++)
    {
        Console.WriteLine(b + new string(' ', nbespace * 2) + b);
    }
    Console.WriteLine(new string('*', nbEtage * 2));   
}
else if (choixMotif == 5)
{
    for (int etage = 1; etage <= nbEtage; etage++)
    {
        if (etage % 2 == 0)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= nbEtage; j++)
        {
            Console.Write(b + " ");
        }
        Console.WriteLine();
    }
}