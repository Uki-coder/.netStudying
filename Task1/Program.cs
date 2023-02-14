using Task1;

Dot[] dots = new Dot[10];
Random rd = new Random();

Console.WriteLine("Dots' coordinates:\n");

for (int i = 0; i < 10; i++)
{
    double x = (double)rd.Next(-100, 100);
    double y = (double)rd.Next(-100, 100);
    double z = (double)rd.Next(-100, 100);

    dots[i] = new Dot(x, y, z);
    Console.WriteLine($"Dot {i}: {x}, {y}, {z}");
}

Console.WriteLine('\n');

for (int i = 0; i < 9; i++)
{
    for (int j = i + 1; j < 10; j++)
    {
        Console.WriteLine($"Distance between Dot {i} and  Dot {j}: {dots[i].Distance(dots[j])}");
    }
    Console.WriteLine('\n');
}
