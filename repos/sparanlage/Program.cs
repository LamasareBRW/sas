// Deklaration
double sparsumme;
double jahre;
double zinsen;
double kapital;
bool fehler;

// Initialisierung
fehler = false;
kapital = 1;

// Eingabe
Console.WriteLine("\n\tProgramm zur Zinsberechnung");
Console.WriteLine("\t===========================");

Console.Write("\n\tGeben Sie die monatliche Sparsumme ein:\t");
    sparsumme = Convert.ToDouble(Console.ReadLine());
Console.Write("\tGeben Sie die Jahresanzahl ein:\t\t");
    jahre = Convert.ToDouble(Console.ReadLine());
Console.Write("\tGeben Sie die Zinsen ein:\t\t");
    zinsen = Convert.ToDouble(Console.ReadLine());

if(sparsumme <= 0 || jahre <= 0 || zinsen <= 0) {
    fehler = true;
}

// Verarbeitung
if (!fehler) {
    zinsen = zinsen / 100 + 1;
    kapital = sparsumme * 12;    
}
// Ausgabe

if (!fehler) {
    for (int i = 0; i <= jahre; i++) {
        Console.WriteLine($"\n\tJahr {i}: {kapital} (Wachstum = {Math.Round(kapital * zinsen - kapital, 2)})");
        kapital = Math.Round(kapital * zinsen, 2);
    }
}