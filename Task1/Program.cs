using Task1;

const int POINTS_AMOUNT = 10;
List<Point> points = new List<Point>();
Random rd = new Random();

Console.WriteLine("Dots' coordinates:\n");

for (int i = 0; i < POINTS_AMOUNT; i++)
{
    double x = (double)rd.Next(-100, 100);
    double y = (double)rd.Next(-100, 100);
    double z = (double)rd.Next(-100, 100);

    points.Add(new Point(x, y, z));
    Console.WriteLine($"Point {i}: {x}, {y}, {z}");
}

Console.WriteLine('\n');

for (int i = 0; i < points.Count() - 1; i++)
{
    for (int j = i + 1; j < points.Count(); j++)
    {
        Console.WriteLine($"Distance between Point {i} and  Point {j}: {points[i].Distance(points[j])}");
    }
    Console.WriteLine('\n');
}
