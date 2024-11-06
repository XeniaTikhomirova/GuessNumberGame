// Eine ausgedachte Zahl des Benutzers;
int yourNumber; 

//Ein Counter zu Zahl der Versuchen zu zahlen und speichern:
int counter = 0;

//Die Grenze des Spieles;
int minNum = 1;
int maxNum = 100;

//das Einstellen der Zufalligezahl:
Random generatedNum = new Random();
int newTry = generatedNum.Next(minNum, maxNum + 1);

do {
   Console.WriteLine("Denk dir deine Zahl zwischen {0} und {1} aus!", minNum, maxNum);
   yourNumber = Convert.ToInt32(Console.ReadLine());
   counter++;

   if (yourNumber == newTry) {
      Console.WriteLine($"🎉Du hast gewonnen! Die Zahl {yourNumber} ist eine reichtige Antwort. Du hast die Zahl mit {counter} Versuche verraten.");
   }

   else if (yourNumber > newTry) {
      Console.WriteLine($"Falsch. Die Zahl ist kleiner als {yourNumber}");
   }

   else if (yourNumber < newTry) {
      Console.WriteLine($"Falsch. Die Zahl ist großer als {yourNumber}");
   }
}
while (yourNumber != newTry);

Console.WriteLine();