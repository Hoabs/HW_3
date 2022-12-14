Console.WriteLine("Enter a positive 5-digit number");
string? a = Console.ReadLine();
while (a.Length != 5)
{
Console.WriteLine("Error. Enter a positive 5-digit number");
a = Console.ReadLine();
}
if (a[0]==a[4] && a[1]==a[3])
{
    Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}