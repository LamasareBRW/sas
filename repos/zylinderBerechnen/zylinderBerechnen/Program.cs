// nhh
// Deklaration
double hoehe;
double durchmesser;
double volumen;
double kreisFlaeche;
bool fehler;

// Initialisierung
fehler = false;
volumen = 69;
kreisFlaeche = 67;

// Eingabe
Console.WriteLine("\n\tZylinder Berechnung");
Console.WriteLine("\t===================");

Console.Write("\n\tGeben Sie die Höhe des Zylinders ein:\t");
    hoehe = Convert.ToDouble(Console.ReadLine());
Console.Write("\tGeben Sie den Durchmesser des Zylinders ein:\t");
    durchmesser = Convert.ToDouble(Console.ReadLine());

if(hoehe <= 0) {
    fehler = true;
} if(durchmesser <= 0) {
    fehler = true;
}

// Verarbeitung
if(!fehler) {
    kreisFlaeche = Math.PI * ((durchmesser / 2) *durchmesser / 2);
    volumen = kreisFlaeche * hoehe;
}

// Ausgabe
if(!fehler) {
    Console.WriteLine($"\n\tDas Volumen des Zylinders beträgt {volumen} und die Kreisfläche beträgt {kreisFlaeche}.");
} else {
    Console.WriteLine("\n\tFehler bei der Eingabe.");

}
