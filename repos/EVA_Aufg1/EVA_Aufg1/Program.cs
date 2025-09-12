// Deklaration
double lohn;
double stunden;
double endLohn;

// Eingabe
Console.Write("\n\tGeben Sie den Stundenlohn des Mitarbeiters ein:\t\t\t");
    lohn = Convert.ToDouble(Console.ReadLine());
Console.Write("\tGeben Sie die gearbeiteten Stunden ihres Mitarbeiters ein:\t");
    stunden = Convert.ToDouble(Console.ReadLine());

// Verarbeitung
endLohn = lohn * stunden;

// Ausgabe
Console.WriteLine($"\n\tDer endgültige Lohn beträgt {endLohn}");
