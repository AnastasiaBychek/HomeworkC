Console.WriteLine("Input week day number");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("It's a day off");
}
else
{
    Console.WriteLine("It's working day");
}
