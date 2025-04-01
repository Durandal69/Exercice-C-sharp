// Jour 2 Exercice 1 : Conversion de température

// Annonce des variables
// VARIABLE TypeConversion : ENTIER
// VARIABLE Temperature : REEL
// VARIABLE TemperatureConvertie : REEL
int TypeConversion;
double Temperature;
double TemperatureConvertie;
// Choisir le type de conversion C -> F ou F -> C
// AFFICHER "Choississez le type de conversion voulue :"
// AFFICHER "Tapez 1 pour Celsius vers Fahrenheit."
// AFFICHER "Tapez 2 pour Fahrenheit vers Celsius."
// LIRE TypeConversion
Console.WriteLine("Choississez le type de conversion voulue :");
Console.WriteLine("Tapez 1 pour Celsius vers Fahrenheit.");
Console.WriteLine("Tapez 2 pour Fahrenheit vers Celsius.");
TypeConversion = Convert.ToInt32(Console.ReadLine());
// Entrez la valeur à convertir
// AFFICHER "Tapez la valeur de la température à convertir :"
// LIRE Temperature
Console.WriteLine("Tapez la valeur de la température à convertir :");
Temperature = Convert.ToDouble(Console.ReadLine());
// Conversion de Celsius vers Fahrenheit
// SI TypeConversion = 1
    // Celsius vers Fahrenheit
    // TemperatureConvertie <- (Temperature * 9/5) + 32
    // AFFICHER TemperatureConvertie
if (TypeConversion == 1) {
TemperatureConvertie = (Temperature * 9 / 5) + 32;
Console.WriteLine("Vous avez donc une température de " + TemperatureConvertie + "°F");
}
// Console.WriteLine($"{Temperature}°C équivaut à {TemperatureConvertie:F2}°F");  // string interpolation
// sur learn.microsoft.com trouver comment sont formatés double, date, string, avec
// le mecanisme "strong interpolation"
// date:HH:mm, ...

// Conversion de Fahrenheit vers Celsius
// SI TypeConversion = 2
    // Fahrenheit vers Celsius
    // TemperatureConvertie <- (Temperature - 32) * 5/9
    // AFFICHER TemperatureConvertie
else if (TypeConversion == 2) {
TemperatureConvertie = (Temperature - 32) * 5 / 9;
Console.WriteLine("Vous avez donc une température de " + TemperatureConvertie + "°C");
}
// En cas de valeur autre que 1 ou 2 choisie pour la conversion, une erreur s'affiche
// SI TypeConversion != 1 ou 2
// AFFICHER "Erreur : Veuillez choisir une option de conversion entre 1 et 2."
else {
    Console.WriteLine("Erreur : Veuillez choisir une option de conversion entre 1 et 2.");
}