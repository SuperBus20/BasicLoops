string answer = "y";
do
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Would you like to continue (y/n)");
    answer = Console.ReadLine();
} while (answer.Trim().ToLower() == "y");
Console.WriteLine("Goodbye");
//End of Part 1
do
{
    Console.WriteLine("Pick a number");

    int userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine($":{i}");
    }

    for (int i = 0; i <= userNumber; i++)
    {
        Console.WriteLine($":{i}");
    }
    Console.WriteLine("Would you like to continue");
    answer = Console.ReadLine();
} while (answer.Trim().ToLower() == "y");
Console.WriteLine("Goodbye");

//End of part 2

int keypadCode = 13579;

int enteredCode = 00000;

while (enteredCode != keypadCode)
{
    Console.WriteLine("Please enter a code to get inside");
    enteredCode = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Welcome user!");


//End of part 3

keypadCode = 13579;
enteredCode = 00000;

do
{
    Console.WriteLine("Please enter a code to get inside");
    enteredCode = Convert.ToInt32(Console.ReadLine());
} while (enteredCode != keypadCode);

Console.WriteLine("Welcome user!");

//End of part 4

keypadCode = 13579;

enteredCode = 00000;


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Attempt number {i}/5: Please enter a key code to open the door");
    enteredCode = Convert.ToInt32(Console.ReadLine());


    if (enteredCode == keypadCode)
    {
        Console.WriteLine("Welcome");
        break;
    }
    else if (i == 5)
    {
        Console.WriteLine("Im sorry but you have run out of guesses, goodbye.");
    }
    else 
    {
        Console.WriteLine($"I'm sorry but you have {5-i} guesses left");
    }

}
//End of extra

