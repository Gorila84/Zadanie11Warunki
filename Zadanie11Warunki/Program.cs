int numerciGrade;
string[] grades = new string[] {
    "Niedostateczny",
    "Dopuszczający",
    "Dostateczny",
    "Dobry",
    "Bardzo dobry",
    "Celujący"};


Console.WriteLine("Podaj ocenę (1,2,3,4,5,6): ");
var enteredGrade = Console.ReadLine();
Int32.TryParse(enteredGrade, out numerciGrade);

Console.WriteLine(grades[numerciGrade -1]);
