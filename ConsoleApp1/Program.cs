int points = 0 ;

Console.WriteLine("welcome to the cod quiz :D");

// --------------------------------------------------------------------------------------------------

Console.WriteLine("question numero uno(1 incase u don't know mexican)");
Console.WriteLine("Who is steve in the movie?");
Console.WriteLine("a) Jack Black  b) Morgan Freeman  c) Dwayne the rock Johnson  d) that one guy that gets bullied on tiktok for looking like minecraft steve.");

string answer1 = Console.ReadLine();

if (answer1 == "a")
{
    points++;
    Console.Clear();
    Console.WriteLine("Bumbaclaat! that's correct!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("Incorrect, bro actually lives under a rock...anyways");
    Console.ReadLine();
}
// --------------------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("What's the best cod?");
Console.WriteLine("a) Atlantic Cod  b) Pacific Cod  c) Black Cod  d) White Cod");

String answer2 = Console.ReadLine();

if (answer2 == "c")
{
    points++;
    Console.Clear();
    Console.WriteLine("Bumbaclaat! that's correct!");
    Console.ReadLine();
}
}
