
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!\n"); 

//Get User name
Console.WriteLine("What is your name?");
string username = Console.ReadLine();

//Check if user is up for challenge
Console.WriteLine("Welcome Grant Chirpus. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
if(Console.ReadLine() != "Yes")
{
    //user rejected, display the message and exit
    Console.WriteLine("\nYou are a coward " + username);
    Console.ReadKey();
    return;
}

//initialize the score
int score = 0;

//Challege is 5 rounds. 
for(int i = 0; i < 5; i++)
{
    //logic for system to pick value 
    string systemPick = "Tails";
    if(i%2 == 0)
    {
        systemPick = "Heads";
    }

    //Ask user to pick value
    Console.WriteLine("Heads or Tails?");
    if (Console.ReadLine() == systemPick)
    {
        //correct guess, increment score
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine("Wrong");
    }
}

Console.WriteLine("\nThank you "+ username + ". You got a score of "+ score+"!");
Console.ReadKey();