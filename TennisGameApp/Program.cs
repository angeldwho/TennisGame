using System;
using TennisGameApp;

Random random = new Random();

int scorePlayer1 = 0;
int scorePlayer2 = 0;

Player player1 = new Player();
Player player2 = new Player();

Console.WriteLine("Enter name's player 1 : ");
player1.name = Console.ReadLine();
Console.WriteLine("Enter surname's player 1 : ");
player1.surname = Console.ReadLine();
Console.Write("Enter level's player 1 (between 0 and 10) : ");
player1.levelPlayer = int.Parse(Console.ReadLine());

Console.WriteLine(Player.printPlayer(player1));
player1.ToString();

Console.WriteLine("Enter name's player 2 : ");
player2.name = Console.ReadLine();
Console.WriteLine("Enter surname's player 2 : ");
player2.surname = Console.ReadLine();
Console.Write("Enter level's player 2 (between 0 and 10) : ");
player2.levelPlayer = int.Parse(Console.ReadLine());

Console.WriteLine(Player.printPlayer(player2));
player2.ToString();

Console.WriteLine("The tennis game starts");
Console.WriteLine("");

while ((scorePlayer1 < 4 && scorePlayer1 < scorePlayer2 + 2 ) || (scorePlayer2 < 4 && scorePlayer2 < scorePlayer1 + 2 ))
//aspetta che scorePlayer2 sia >4
{
    int scoreGamePlayer1;
    scoreGamePlayer1 = random.Next(0, 4);
    scorePlayer1 += scoreGamePlayer1;
    Console.WriteLine($"It's {player1.name} turn :  ");
    switch (scoreGamePlayer1)
    {
        case (0):
            Console.WriteLine("Love point!");
            break;
        case (1):
            Console.WriteLine("Fifteen points!");
            break;
        case (2):
            Console.WriteLine("Thirty points!");
            break;
        case (3):
            Console.WriteLine("Forty points!");
            break;
    }

    Console.WriteLine($"{player1.name}'s total point are : {scorePlayer1}");
    Console.WriteLine("");
    int scoreGamePlayer2;
    scoreGamePlayer2 = random.Next(0, 4);
    scorePlayer2 += scoreGamePlayer2;
    Console.WriteLine($"It's {player2.name} turn :  ");
    switch (scoreGamePlayer2)
    {

        case (0):
            Console.WriteLine("Love point!");
            break;
        case (1):
            Console.WriteLine("Fifteen points!");
            break;
        case (2):
            Console.WriteLine("Thirty points!");
            break;
        case (3):
            Console.WriteLine("Forty points!");
            break;
    }
    Console.WriteLine($"{player2.name}'s total point are : {scorePlayer2}");
    Console.WriteLine("");

    if (scoreGamePlayer1 >= 3 && scoreGamePlayer1 == scoreGamePlayer2)
    {
        if (scorePlayer1 == scorePlayer2)
        {
            Console.WriteLine("The score is deuce!");
            Console.WriteLine("");
        }
        else if (scorePlayer1 == scorePlayer2 + 1 || scorePlayer2 == scorePlayer1 + 1)
        {
            Console.WriteLine("The score is advantage");
            Console.WriteLine("");
        }
    }
}
if (scorePlayer1 == scorePlayer2)
{
    Console.WriteLine("Par!");
}
if (scorePlayer1 >= scorePlayer2 + 2)
{
    Console.WriteLine($"{player1.name} win!");
}
else if (scorePlayer2 >= scorePlayer1 + 2)
{
    Console.WriteLine($"{player2.name} win!");

}

Console.WriteLine($"{player1.name} has {scorePlayer1} point and {player2.name} has {scorePlayer2} point.");

