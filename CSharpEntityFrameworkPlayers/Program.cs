// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

Console.WriteLine("Hello, World!");

//Milestone 1
//operazioni C.R.U.D.

using (SportContext db = new SportContext())
{
    //numero decimale random da 1.0 a 10.0 per il punteggio
    Random randomScore = new Random();
    double randomIntNumberScore = randomScore.Next(10, 100);
    double decimalNumberScore = randomIntNumberScore / 10;

    //numero intero random da 1 a 100 per le partite giocate
    Random randomMatch = new Random();
    int randomIntNumberMatch = randomMatch.Next(1, 100);

    //numero intero random da 1 a partite giocate per le partite vinte
    Random randomWin = new Random();
    int randomIntNumberWin = randomWin.Next(1, randomIntNumberMatch);

    //creazione nuovo giocatore
    Player newPlayers = new Player() { Name = "LeBron", Surname = "James", Score = decimalNumberScore, Match = randomIntNumberMatch, Win = randomIntNumberWin };

    //aggiungere nuovo giocatore nel database
    db.Add(newPlayers);
    db.SaveChanges();
    Console.WriteLine("aggiunto nuovo giocatore");
}
