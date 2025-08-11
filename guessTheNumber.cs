Random rand = new Random();
int count = 1;
int randNum = 0;
Console.WriteLine("Welcome!");
Console.WriteLine("This is game 'Guess the number' ");
Console.WriteLine("Choose the difficulty level: ");
Console.WriteLine("1.Easy(range number: 1-25)");
Console.WriteLine("2.Pro(range number: 1-50)");
Console.WriteLine("3.Medium(range number: 1-75)");
Console.WriteLine("4.Hard(range number:1-100)");
Console.WriteLine("5.Exit");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        randNum = rand.Next(1, 26);
        break;
    case 2:
        randNum = rand.Next(1, 51);
        break;
    case 3:
        randNum = rand.Next(1, 76);
        break;
    case 4:
        randNum = rand.Next(1, 101);
        break;
}
while (true)
{
    if (choice == 5)
    {
        Console.WriteLine("Programm stoped its work");
        break;
    }
    if (choice > 5)
    {
        Console.WriteLine("Error, incorrect number input");
        break;
    }
    Console.WriteLine("Input number: ");
    string numberInput = Console.ReadLine();
    if (!int.TryParse(numberInput, out int num))
    {
        Console.WriteLine("Input number!");
    }
    if (num == randNum)
    {
        Console.WriteLine($"You guessed rigth number behind {count} attemts");
        break;
    }
    if (num > randNum)
    {
        Console.WriteLine("Too high! Try lower");
        count++;
    }
    else
    {
        Console.WriteLine("Too low! Try higher");
        count++;
    }
}

