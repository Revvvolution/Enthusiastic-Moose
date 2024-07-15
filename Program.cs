﻿using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
    ForestQuestion();
    ClubQuestion();
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



bool MooseAsks(string question)
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

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}



// Making individual question its own function
void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    // Console.WriteLine(isTrue); test for boolean response
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

void ForestQuestion()
{
    bool doesFrolick = MooseAsks("Do you enjoy frolicking in the forest?");
    if (doesFrolick)
    {
        MooseSays("R I G H T  O N ! Frolicking among the trees is my favorite pastime.");
    }
    else
    {
        MooseSays("Oh, really? Well, more frolicking for me, I guess!");
    }
}

void ClubQuestion()
{
    bool wantsClub = MooseAsks("Would you like to join my antler-polishing club?");
    if (wantsClub)
    {
        MooseSays("F A N T A S T I C !! We’ll make those antlers shine like the northern lights!");
    }
    else
    {
        MooseSays("No worries, maybe next time. Keep those antlers wild and free!");
    }
}