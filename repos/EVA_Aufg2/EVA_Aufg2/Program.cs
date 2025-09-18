// Deklaration
double lohn;
double stunden;
double endLohn;
double prozent;

// Eingabe
Console.Write("\n\tGeben Sie den Stundenlohn des Mitarbeiters ein:\t\t\t");
    lohn = Convert.ToDouble(Console.ReadLine());

Console.Write("\tGeben Sie die gearbeiteten Stunden ihres Mitarbeiters ein:\t");
    stunden = Convert.ToDouble(Console.ReadLine());

Console.Write("\tGeben Sie den Prozentsatz der BA ein:\t\t\t\t");
    prozent = Convert.ToDouble(Console.ReadLine());

// Verarbeitung
prozent = (100 - prozent) / 100;
endLohn = lohn * stunden * prozent;

// Ausgabe
Console.WriteLine($"\n\tDer endgültige Lohn beträgt {endLohn}");
