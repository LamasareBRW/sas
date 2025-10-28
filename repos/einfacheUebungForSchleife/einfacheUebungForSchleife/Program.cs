// Deklaration
int startwert;
int endwert;
int schrittweite;

// Initialisierung


// Eingabe
Console.WriteLine("\n\tProgramm");
Console.WriteLine("\t========");

Console.Write("\n\tGeben Sie den Startwert ein:\t");
    startwert = Convert.ToInt32(Console.ReadLine());
Console.Write("\tGeben Sie den Endwert ein:\t");
    endwert = Convert.ToInt32(Console.ReadLine());
Console.Write("\tGeben Sie die Schrittweite ein:\t");
    schrittweite = Convert.ToInt32(Console.ReadLine());

// Verarbeitung


// Ausgabe
for (int i = startwert; i <= endwert; i = i + schrittweite) {
    Console.WriteLine(i);
}
