// Deklaration
string note;

// Eingabe
Console.Write("\n\tGeben die Note ein:\t");

// Ausgabe
switch (note)
{
    case "1":
        Console.WriteLine("\n\tDie Definition lautet Sehr Gut");
        break;
    case "2":
        Console.WriteLine("\n\tDie Definition lautet Gut");
        break;
    case "3":
        Console.WriteLine("\n\tDie Definition lautet Befriedigend");
        break;
    case "4":
        Console.WriteLine("\n\tDie Definition lautet Ausreichend");
        break;
    case "5":
        Console.WriteLine("\n\tDie Definition lautet Mangelhaft");
        break;
    case "6":
        Console.WriteLine("\n\tDie Definition lautet Ungenügend");
        break;
    default:
        Console.WriteLine("\n\tFalsche Eingabe");
        break;
}