using System;

Main();

void Main()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");

        // Let the moose speak!
        MooseSays("H I, I'M  E N T H U S I A S T I C !");
        MooseSays("I really am enthusiastic");

        // Ask questions
        MooseAsks("Is Canada real?", "Really? It seems very unlikely.", "I K N E W  I T !!!");
        MooseAsks("Are you enthusiastic?", "Yay!", "You should try it!");
        MooseAsks("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
        MooseAsks("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        MooseAsks("Do you enjoy frolicking in the forest?", "R I G H T  O N ! Frolicking among the trees is my favorite pastime.", "Oh, really? Well, more frolicking for me, I guess!");
        MooseAsks("Would you like to join my antler-polishing club?", "Great! Welcome to the club!", "Maybe next time then.");
    }


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



void MooseAsks(string question, string positiveResponse, string negativeResponse)
    {
        bool answer = GetYesOrNoAnswer(question);
        MooseSays(answer ? positiveResponse : negativeResponse);
    }

    bool GetYesOrNoAnswer(string question)
    {
        Console.Write($"{question} (Y/N): ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        string answer = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            answer = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        return answer == "y";
    }
