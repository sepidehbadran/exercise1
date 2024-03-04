// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter a number");
String number = Console.ReadLine();
int n = int.Parse(number);

for (int i=3; i< n; i = i+3)
{
    Console.WriteLine(i);
}
