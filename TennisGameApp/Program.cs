using System;

Random random = new Random();

int scorePlayer1 = 0;
int scorePlayer2 = 0;
int scoreGamePlayer1 = 0;
int scoreGamePlayer2 = 0;

Console.WriteLine("The tennis game starts");
Console.WriteLine("");
while ((scorePlayer1 <= 4 && scorePlayer1-scorePlayer2<2)|| (scorePlayer2 <= 4 && scorePlayer2-scorePlayer1<2)) {
    if (scorePlayer1 >= scorePlayer2 + 2)
    {
        Console.WriteLine("Player 1 win!");
        break;
    }
    else if (scorePlayer1 >= scorePlayer2 + 2)
    {
        Console.WriteLine("Player 2 win!");
        break;
    }

    scoreGamePlayer1 =random.Next(0,4);
    scorePlayer1 += scoreGamePlayer1;
    Console.WriteLine($"It's player 1 turn :  ");
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

    Console.WriteLine($"Player 1 total point are : {scorePlayer1}");
    Console.WriteLine("");
    scoreGamePlayer2 = random.Next(0,4);
    scorePlayer2 += scoreGamePlayer2;
    Console.WriteLine($"It's player 2 turn :  ");
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
    Console.WriteLine($"Player 2 total point are : {scorePlayer2}");
    Console.WriteLine("");

    if (scoreGamePlayer1 == 3 && scoreGamePlayer1 == scoreGamePlayer2)
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

Console.WriteLine($"Player 1 has {scorePlayer1} point and player 2 has {scorePlayer2} point.");

