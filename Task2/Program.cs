using Task2;



List<Point> points = new List<Point>();

Console.WriteLine("Dots' coordinates:\n");

for (int i = 0; i < 10; i++)
{
    Point p = new Point();
    points.Add(p);
    Console.WriteLine($"Point {i}: {points[i].XCoordinate}, {points[i].YCoordinate}");
}

List<double> distances = new List<double>();
Console.WriteLine("\n\n");

for (int i = 0; i < points.Count - 1; i++)
{
    for (int j = i + 1; j < points.Count; j++)
    {
        distances.Add(points[i].Distance(points[j]));
        Console.WriteLine($"Distance between Point {i} and  Point {j}: {points[i].Distance(points[j])}");
    }
    Console.WriteLine('\n');
}

Console.Write('\n');
Console.WriteLine($"Maximum distance: {distances.Max()}");
Console.WriteLine($"Minimum distance: {distances.Min()}\n");

List<Rectangle> rectangles= new List<Rectangle>();
List<Circle> circles= new List<Circle>();
List<Triangle> triangles= new List<Triangle>();
List<double> areas = new List<double>();

int amount = 3;

for (int i = 0; i < amount; i++)
{
    rectangles.Add(new Rectangle());
    circles.Add(new Circle());
    triangles.Add(new Triangle());
}

for (int i = 0; i < amount; i++)
{
    areas.Add(circles[i].GetArea());
    areas.Add(rectangles[i].GetArea());
    areas.Add(triangles[i].GetArea());
}

for (int i = 0; i < areas.Count; i++)
{
    Console.WriteLine($"Area {i}: {areas[i]}");
}

Console.WriteLine($"\nMaximum area: {areas.Max()}");