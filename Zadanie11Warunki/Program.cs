int numerciGrade;
string[] grades = new string[] {
    "Niedostateczny",
    "Dopuszczający",
    "Dostateczny",
    "Dobry",
    "Bardzo dobry",
    "Celujący"};


Console.WriteLine("Podaj ocenę (1,2,3,4,5,6): ");
var enteredGrade = Console.ReadKey();
//Int32.TryParse(enteredGrade, out numerciGrade);

//Console.WriteLine(grades[numerciGrade -1]);

switch (enteredGrade.KeyChar)
{
    case '1':
        Console.WriteLine("\n" + grades[0]);
        break;
    case '2':
        Console.WriteLine("\n" + grades[1]);
        break;
    case '3':
        Console.WriteLine("\n" + grades[2]);
        break;
    case '4':
        Console.WriteLine("\n" + grades[3]);
        break;
    case '5':
        Console.WriteLine("\n" + grades[4]);
        break;
    case '6':
        Console.WriteLine("\n" + grades[5]);
        break;
    default:
        Console.WriteLine("Wpisałeś niepoprawny numer oceny.");
        break;
}
