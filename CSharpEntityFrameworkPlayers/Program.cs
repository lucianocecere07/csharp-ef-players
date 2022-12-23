// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

Console.WriteLine("Hello, World!");

//Milestone 1
//operazioni C.R.U.D.

//create - read - update - delete
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

    //lista del team
    Team newteam = new Team() { name = "All-Stars", city = "Miami", coach = "Ham", color = "Blue-Yellow" };

    //creazione nuovo giocatore
    Player newPlayer = new Player() { name = "LeBron", surname = "James", score = decimalNumberScore, match = randomIntNumberMatch, win = randomIntNumberWin };

    //aggiungere nuovo giocatore nel database
    db.Add(newPlayer);
    //db.SaveChanges();
    Console.WriteLine("aggiunto nuovo giocatore");

    //lettura del nuovo giocatore
    List<Player> Players = db.Players.OrderBy(newPlayer => newPlayer.name).ToList<Player>();

    //db.SaveChanges();
    Console.WriteLine("letto nuovo giocatore");


    //modifica del nuovo giocatore
    newPlayer.name = "Luka";
    newPlayer.surname = "Doncic";

    //modificare il nuovo giocatore nel database
    //db.SaveChanges();
    Console.WriteLine("modifica del nuovo giocatore");


    //cancellare il nuovo giocatore dal database
    db.Remove(newPlayer);

    //db.SaveChanges();
    Console.WriteLine("cancellazione del nuovo giocatore");

    //Milestone 3
    //creazione 3 nuovi giocatori
    Player newPlayer1 = new Player() { name = "Ja", surname = "Morant", score = decimalNumberScore, match = randomIntNumberMatch, win = randomIntNumberWin, team = newteam };
    Player newPlayer2 = new Player() { name = "Kevin", surname = "Durant", score = decimalNumberScore, match = randomIntNumberMatch, win = randomIntNumberWin, team = newteam };
    Player newPlayer3 = new Player() { name = "Stephen", surname = "Curry", score = decimalNumberScore, match = randomIntNumberMatch, win = randomIntNumberWin, team = newteam };

    //aggiungere al database
    db.Add(newPlayer1);
    db.Add(newPlayer2);
    db.Add(newPlayer3);

    //db.SaveChanges();
    Console.WriteLine("aggiunti i nuovi giocatori in database");

    //aggiungere alla lista
    newteam.playersInTeam.Add(newPlayer1);
    newteam.playersInTeam.Add(newPlayer2);
    newteam.playersInTeam.Add(newPlayer3);

    db.SaveChanges();
    Console.WriteLine("inserimento dei nuovi giocatori in team");

}






//---------------------------------------------------------------//
/*
//create
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

//read
using (SportContext db = new SportContext())
{
    //lettura del nuovo giocatore
    List<Player> players = db.Players.OrderBy(newPlayers => newPlayers.Name).ToList<Player>();
    
    db.SaveChanges();
    Console.WriteLine("letto nuovo giocatore");
}

// Update
using(SportContext db = new SportContext())
{
    //modifica del nuovo giocatore
    newPlayers.Name = "Luka";
    newPlayers.Surname = "Doncic";

    //modificare il nuovo giocatore nel database
    db.SaveChanges();
    Console.WriteLine("modifica del nuovo giocatore");
}

// Delete
using (SportContext db = new SportContext())
{
    //cancellare il nuovo giocatore dal database
    db.Remove(newPlayers);

    db.SaveChanges();
    Console.WriteLine("cancellazione del nuovo giocatore");
}
*/

