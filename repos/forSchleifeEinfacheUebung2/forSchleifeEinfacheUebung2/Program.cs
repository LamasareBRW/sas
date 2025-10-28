// Deklaration
int basis;
int quadrat;
int kubik;

// Initialisierung
basis = 0;
quadrat = 1;
kubik = 1;

// Eingabe
Console.WriteLine("\n\tProgramm");
Console.WriteLine("\t========");

// Verarbeitung


// Ausgabe
for (int i = 1; i <= 10; i++) {
    basis = basis + 1;
    quadrat = basis * basis;
    kubik = quadrat * basis;
    Console.WriteLine($"\n\tBasis = {basis}\tQuadrat = {quadrat}\tKubik = {kubik}");
}
