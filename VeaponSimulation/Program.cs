using Core.Entities;

AssaultRifle akm = new AssaultRifle(200, 30);
NewPlace:
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Please Choose\n1 for Single Fire\n2 for Automatic Fire\n3 for Reload\n4 for Reload enter number\n5 for info");
string input = Console.ReadLine().Trim().ToUpper();

switch (input)
{
    case "1":

        Console.WriteLine(akm.SingleFire(HowMuchShoot()));
        goto NewPlace;
    case "2":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(akm.AutomaticFire());

        goto NewPlace;
    case "3":
        Console.WriteLine(akm.Reload());
        goto NewPlace;
    case "4":
        Console.WriteLine(akm.Reload(HowMuchReload()));
        goto NewPlace;
    case "5":
        Console.WriteLine(akm);
        goto NewPlace;
    default:
        Console.WriteLine("Invalid Input");
        goto NewPlace;
}
        
         static int HowMuchShoot()
{
TryAgain:
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please enter the value that you want to Shoot: ");
    string input = Console.ReadLine();
    int convValue = 0;
    try
    {
        convValue = Convert.ToInt32(input);
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Please Choose\n1 for Single Fire\n2 for Automatic Fire\n3 for Reload\n4 for Reload enter number\n5 for info");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nInvalid!\nTry Again!");

        goto TryAgain;
    }

    return convValue;
}
 static int HowMuchReload()
{
TryAgain:
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please enter the value,How many bullet do you want to add to the magazine: ");
    string input = Console.ReadLine();
    int convValue = 0;
    try
    {
        convValue = Convert.ToInt32(input);
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Please Choose\n1 for Single Fire\n2 for Automatic Fire\n3 for Reload\n4 for Reload enter number\n5 for info");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nInvalid!\nTry Again!");
        goto TryAgain;
    }

    return convValue;
}