using System.ComponentModel.Design;

bool numberAnalyzer = true;
string userAnswer;
string yes = "yes";
string y = "y";
string no = "no";
string n = "n";

while (numberAnalyzer)
{

    int userNum = 0;

    Console.WriteLine("Hello User. Please enter a number from one to one hundred. (Only whole numbers please.)");
    string userInput = Console.ReadLine();
    bool inputGood = int.TryParse(userInput, out userNum);

    if (inputGood == false)
    {
        Console.WriteLine("You failed to enter a number. Please try again.");
        Console.WriteLine();
    }
    else if (userNum < 1 || userNum > 100)
    {
        Console.WriteLine("That number does not fall within the proper parameters. Please enter a number froim one to one hundred.");
        Console.WriteLine();
    }
    else if (userNum % 2 != 0 && userNum < 60)
    {
        Console.WriteLine(userInput + " is odd and it's less than 60. Wanna go again?");
        userAnswer = Console.ReadLine().ToLower().Trim();
        userAnswer = userAnswer.Trim();
        Console.WriteLine();
        if (userAnswer == y || userAnswer == yes)
        {
            numberAnalyzer = true;
        }
        else
        {
            Console.WriteLine("So long.");
            numberAnalyzer = false;
        }
    }
    else if (userNum % 2 == 0 && userNum > 1 && userNum < 25)
    {
        Console.WriteLine(userInput + " is even and it's less than 25. Any more?");
        userAnswer = Console.ReadLine().ToLower().Trim();
        userAnswer = userAnswer.Trim();
        Console.WriteLine();
        if (userAnswer == y || userAnswer == yes)
        {
            numberAnalyzer = true;
        }
        else
        {
            Console.WriteLine("So long.");
            numberAnalyzer = false;
        }
    }
    else if (userNum % 2 == 0 && userNum > 25 && userNum < 61)
    {
        Console.WriteLine(userInput + " is even and it's between 26 and 60 (inclusive). Got another?");
        userAnswer = Console.ReadLine().ToLower().Trim();
        userAnswer = userAnswer.Trim();
        Console.WriteLine();
        if (userAnswer == y || userAnswer == yes)
        {
            numberAnalyzer = true;
        }
        else
        {
            Console.WriteLine("So long.");
            numberAnalyzer = false;
        }
    }
    else if (userNum % 2 == 0 && userNum > 61)
    {
        Console.WriteLine(userInput + " is even and it's greater than 60. One more?");
        userAnswer = Console.ReadLine().ToLower().Trim();
        userAnswer = userAnswer.Trim();
        Console.WriteLine();
        if (userAnswer == y || userAnswer == yes)
        {
            numberAnalyzer = true;
        }
        else
        {
            Console.WriteLine("So long.");
            numberAnalyzer = false;
        }
    }
    else
    {
        Console.WriteLine(userInput + " is odd and it's greater than 60. Will that be all?");
        userAnswer = Console.ReadLine().ToLower().Trim();
        userAnswer = userAnswer.Trim();
        Console.WriteLine();
        if (userAnswer == n || userAnswer == no)
        {
            numberAnalyzer = true;
        }
        else
        {
            Console.WriteLine("So long.");
            numberAnalyzer = false;
        }
    }
}
    Console.ReadLine();