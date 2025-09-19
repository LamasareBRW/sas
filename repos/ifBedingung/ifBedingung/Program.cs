// Deklaration
int zahl;
int ausgabe;
bool falsch;

// Initialisierung
falsch = false;
ausgabe = 69;

// Eingabe
Console.WriteLine("\n\tBeispielprogramm für if");
Console.WriteLine("\t=======================");
Console.Write("\n\tBitte geben Sie eine Zahl ein:\t");
zahl = Convert.ToInt32(Console.ReadLine());
if(zahl <= 10) {
    falsch = true;
}

// Verarbeitung
if(!falsch) {           // entspricht falsch == false, dann
    ausgabe = zahl + 2;
}

// Ausgabe
if (!falsch) {
    Console.WriteLine($"\n\tDas Ergebnis lautet {ausgabe}.");
} else {
    Console.WriteLine("\n\tFalsche Eingabe.");
}