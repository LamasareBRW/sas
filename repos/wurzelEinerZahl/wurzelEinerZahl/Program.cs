// Deklaration
double zahl;
double loesung;
bool fehler;

// Initialisierung
zahl = 2813;
loesung = 2813;
fehler = false;

// Eingabe
Console.WriteLine("\n\tWurzel berechnen");
Console.WriteLine("\t================");

Console.Write("\n\tGeben Sie die zu berechnende Zahl ein:\t");
    zahl = Convert.ToDouble(Console.ReadLine());

if (zahl <= 0) {
    fehler = true;
}

// Verarbeitung
if (!fehler) {
    loesung = Math.Sqrt(zahl);
    loesung = Math.Round(loesung, 3, MidpointRounding.AwayFromZero);    // (Zahl, Nachkommastellen, Rundungsart)
}

// Ausgabe
if (!fehler) {
    Console.WriteLine($"\n\tDas Ergebnis lautet {loesung}");
} else {
    Console.WriteLine("\n\tFehler bei der Eingabe: Nur positive Zahlen können berechnet werden.");

}
