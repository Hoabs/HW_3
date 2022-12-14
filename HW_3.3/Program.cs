Console.WriteLine("Enter an integer number");
int n = Convert.ToInt32(Console.ReadLine());
string result = "";

if (n < 0)
{
    n = -n;
}

for (int i = 1; i < n; i++)
{
result = result+$"{Math.Pow(i,3)}, ";
}

result = result+$"{Math.Pow(n,3)}";

Console.WriteLine(result);