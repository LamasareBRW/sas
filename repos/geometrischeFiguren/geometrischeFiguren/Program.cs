// Deklaration
byte koerper;
bool fehler;
double durchmesser;
double hoehe;
double durchmesser2;
double hoehe2;
double volumen;
double flaeche;

// Initialisierung
fehler = false;
durchmesser = 1;
hoehe = 1;
volumen = 1;
flaeche = 1;
durchmesser2 = 1;
hoehe2 = 1;

// Eingabe
Console.WriteLine("\n\tWelchen Körper möchten Sie berechnen?\n\t(1) Würfel\n\t(2) Zylinder\n\t(3) Hohlzylinder");
Console.Write("\n\tGeben Sie die Zahl des Körpers ein:\t");
    koerper = Convert.ToByte(Console.ReadLine());

if(koerper <= 0 || koerper >= 4) {
    fehler = true;
} else {
    switch (koerper) {
        case 1:
            Console.Write("\n\tGeben Sie die Seitenlänge des Würfels ein:\t");
                durchmesser = Convert.ToDouble(Console.ReadLine());
            break;
        case 2:
            Console.Write("\n\tGeben Sie den Durchmesser des Zylinders ein:\t");
                durchmesser = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tGeben Sie die Höhe des Zylinders ein:\t");
                hoehe = Convert.ToDouble(Console.ReadLine());
            break;
        case 3:
            Console.Write("\n\tGeben Sie den Durchmesser des Zylinders ein:\t");
                durchmesser = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tGeben Sie die Höhe des Zylinders ein:\t");
                hoehe = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tGeben Sie den Durchmesser des Innenylinders ein:\t");
                durchmesser2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tGeben Sie die Höhe des Innenzylinders ein:\t");
                hoehe2 = Convert.ToDouble(Console.ReadLine());
            break;
    }
    if (durchmesser <= 0 || hoehe <= 0 || durchmesser2 <= 0 || hoehe2 <= 0) {
        fehler = true;
    }

}

// Verarbeitung
if(!fehler) {
    switch (koerper) {
        case 1:
            flaeche = durchmesser * durchmesser;
            volumen = flaeche * durchmesser;
            break;
        case 2:
            flaeche = Math.Round(Math.PI * ((durchmesser / 2) * durchmesser / 2), 2);
            volumen = Math.Round(flaeche * hoehe, 2);            
            break;
        case 3:
            flaeche = Math.Round((Math.PI / 4) * (((durchmesser / 2) * durchmesser / 2) - ((durchmesser2 / 2) * durchmesser2 / 2)), 2);
            volumen = Math.Round(flaeche * hoehe, 2);
            break;
    }
}

// Ausgabe

if(!fehler) {
    switch (koerper) {
        case 1:
            Console.WriteLine($"\n\tDas Volumen des Würfels beträgt {volumen} und die Fläche beträgt {flaeche}");
            break;
        case 2:
            Console.WriteLine($"\n\tDas Volumen des Zylinders beträgt {volumen} und die Fläche beträgt {flaeche}");
            break;
        case 3:
            Console.WriteLine($"\n\tDas Volumen des Hohlzylinders beträgt {volumen} und die Fläche beträgt {flaeche}");
            break;
    }
} else {
    Console.WriteLine("\n\tFehler bei der Eingabe");
}
