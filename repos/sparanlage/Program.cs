// Deklaration
int eingabe;
int loesung;
bool fehler;

// Initialisierung
fehler = false;
loesung = 0;

// Eingabe
Console.WriteLine("\n\tProgramm zur Quersummenrechnung");
Console.WriteLine("\t===============================");

Console.Write("Geben Sie eine 5-Stellige Ziffer ein:\t");
    eingabe = Convert.ToInt32(Console.ReadLine());

if (eingabe <= 9999 || eingabe >= 100000) {
    fehler = true;
}

// Verarbeitung
if (!fehler) {
    for (int i = 1; i <= 5; i++) {
        loesung = (eingabe % 10) + loesung;
        eingabe = eingabe / 10;
    }
}

// Ausgabe
if (!fehler) {
    Console.WriteLine($"\n\tDie Quersumme beträgt {loesung}");
} else {
    Console.WriteLine("\n\tFehler bei der Eingabe.")
}