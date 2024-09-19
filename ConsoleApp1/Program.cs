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
    Console.WriteLine("Bumbaraasclaat! that's correct!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("Incorrect, bro actually has L taste...anyways");
    Console.ReadLine();
}
// -----------------------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("What's the best call of duty game?");
Console.WriteLine("a) black ops  b) black ops 2  c) modern warfare 2  d) modern warfare 3");

string answer3 = Console.ReadLine();

if (answer3 == "b")
{
    points++;
    Console.Clear();
    Console.WriteLine("Bumbafart! that's correct!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("Incorrect... bro actually has L taste, anyways");
    Console.ReadLine();
}
// ------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("What's the capital of Thailand?");
Console.WriteLine("a)bangkok  b) bangpusi  c) bangdik  d) bangtits");

string answer4 = Console.ReadLine();

if (answer4 == "a")
{
    points++;
    Console.Clear();
    Console.WriteLine("Bumbaaaa! that's correct!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("Incorrect... bro actually sucks at geography L taste, anyways");
    Console.ReadLine();
}
// -------------------------------------------------------------
Console.WriteLine($"You got {points} questions right");
if (points == 0)
{
    Console.WriteLine("Bro needs to go touch grass fr.");
    Console.ReadLine();
}
else if (points < 4)
{
    Console.WriteLine("mid performance.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Congrats, u proved that u know useless information about random facts.");
    Console.ReadLine();
}