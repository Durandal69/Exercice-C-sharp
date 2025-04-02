// Jour 1 Exercice 4 : Calcul de distance entre deux points

// Les Variables
// VARIABLE x1, x2, y1, y2 : ENTIER
// VARIABLE distance : REEL

// AFFICHER "Veuillez entrer les coordonnées du premier point x, y :"
// AFFICHER "Valeur de x :"
// Lire x1
// AFFICHER "Valeur de y :"
// Lire y1
// AFFICHER "Veuillez entrer les coordonnées du deuxième point x, y :"
// AFFICHER "Valeur de x :"
// Lire x2
// AFFICHER "Valeur de y :"
// Lire y2

// distance <- racine carré((x2 - x1)² + (y2 - y1)²)

// AFFICHER $"La distance entre les deux points est de {distance} unités"

double x1, x2, y1, y2;
double distance;

Console.WriteLine("Veuillez entrer les coordonnées du premier point x, y :");
Console.WriteLine("Valeur de x :");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Valeur de y :");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez entrer les coordonnées du deuxième point x, y :");
Console.WriteLine("Valeur de x :");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Valeur de y :");
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"La distance entre les deux points est de {distance} unités");