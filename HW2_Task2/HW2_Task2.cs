int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int A = number/100;
int B = number%10;
int newNumber = A*10 + B;
Console.WriteLine(newNumber);

