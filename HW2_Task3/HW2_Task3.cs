Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    int number1 = number/100;
    int newNumber = number1%10;
    Console.WriteLine(newNumber);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}
