Console.WriteLine("Enter coordinate A (x)");
double Ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate A (y)");
double Ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate A (z)");
double Az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate B (x)");
double Bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate B (y)");
double By = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate B (z)");
double Bz = Convert.ToDouble(Console.ReadLine());

double len = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
len = Math.Round(len, 2);

Console.WriteLine(len);


