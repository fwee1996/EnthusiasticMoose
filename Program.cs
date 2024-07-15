// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

//Console.Write("Welcome to the Enthusiastic Moose Simulator! \n --------------------------------------------");

//Or:
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine(); //create extra line break in between welcome and picture

//Call the fn!
//MooseSays();

// Let the moose speak! Call the fn with messages:
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// Ask a question
bool isTrue = MooseAsks("Is Canada real?");
//Console.WriteLine(isTrue);
if (isTrue)
{
    MooseSays("Really? It seems very unlikely.");
}
else
{
    MooseSays("I  K N E W  I T !!!");
}

//Create a MooseSays() function that displays moose:
//@ in front of the string to allow for a multi-line string.
//$ character to the front of the string to enable string interpolation.
void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

//MooseAsks fn: moose answers yes/no:
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}