// Jour 2 Exercice 6 : Equation du second degré

// Les Variables
// VARIABLE discriminant, a, b, c, x1, x2 = REEL

// AFFICHER "Résolution de l'équation ax² + bx + c = 0."
// AFFICHER "Quelle est votre coefficient a ?"
// LIRE a
// AFFICHER "Quelle est votre coefficient b ?"
// LIRE b
// AFFICHER "Quelle est votre coefficient c ?"
// LIRE c

// discriminant <- b² - 4 * a * c

// SI discriminant < 0
// AFFICHER $"L'équation {a}x² + {b}x + 2 = 0 n'a pas de solution réelle."
// SINON SI discriminant == 0
// x1 <- -b / (2 * a)
// AFFICHER $"L'équation {a}x² + {b}x + 2 = 0 a une solution réelle {x1}."
// SINON SI discriminant > 0
// x1 <- (-b - √discriminant) / (2 * a)
// x2 <- (-b + √discriminant) / (2 * a)
// AFFICHER $"L'équation {a}x² + {b}x + 2 = 0 a deux solutions réelles {x1} ou {x2}."

double discriminant, a, b, c, x1, x2;

Console.WriteLine("Résolution de l'équation ax² + bx + c = 0.");
Console.WriteLine("Quelle est votre coefficient a ?");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quelle est votre coefficient b ?");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quelle est votre coefficient c ?");
c = Convert.ToDouble(Console.ReadLine());

discriminant = (b * b) - (4 * a * c);

if (discriminant < 0)
{
    Console.WriteLine($"L'équation {a}x² + {b}x + 2 = 0 n'a pas de solution réelle.");
}
else if (discriminant == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"L'équation {a}x² + {b}x + 2 = 0 a une solution réelle {x1}");
}
else if (discriminant > 0)
{
    x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"L'équation {a}x² + {b}x + 2 = 0 a deux solutions réelles {x1} ou {x2}.");
}