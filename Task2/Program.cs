using Task2;

List<Point> points = new List<Point>();
PointGenerator pRnd = new PointGenerator();
Random rnd = new Random();

const int POINT_AMOUNT = 10;

Console.WriteLine("Dots' coordinates:\n");

for (int i = 0; i < POINT_AMOUNT; i++)
{
    Point p = pRnd.Generate();
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
Console.WriteLine($"Minimum distance: {distances.Min()}\n\n");

List<double> areas = new List<double>();
List<Figure> figures = new List<Figure>();

const int FIGURE_AMOUNT = 3;
const int FIGURE_TYPES = 3;

for (int i = 0; i < FIGURE_AMOUNT; i++)
{
    figures.Add(new Circle(pRnd.Generate(), (double)rnd.Next(-100, 100)));
    figures.Add(new Triangle(pRnd.Generate(), pRnd.Generate(), pRnd.Generate()));
    figures.Add(new Rectangle(pRnd.Generate(), pRnd.Generate()));
}

for (int i = 0; i < FIGURE_TYPES * FIGURE_AMOUNT; i++)
{
    areas.Add(figures[i].GetArea());
}

for (int i = 0; i < FIGURE_TYPES * FIGURE_AMOUNT; i++)
{
    if (figures[i] is Circle) Console.WriteLine($"Circle has area: {areas[i]}");
    else if (figures[i] is Triangle) Console.WriteLine($"Triangle has area: {areas[i]}");
    else Console.WriteLine($"Rectangle has area: {areas[i]}");
}

int maximumID = areas.IndexOf(areas.Max());
int minimumID = areas.IndexOf(areas.Min());

if (figures[maximumID] is Circle) Console.WriteLine($"\n\nCircle has maximum area: {areas[maximumID]}");
else if (figures[maximumID] is Triangle) Console.WriteLine($"\n\nTriangle has maximum area: {areas[maximumID]}");
else Console.WriteLine($"\n\nRectangle has maximum area: {areas[maximumID]}");

if (figures[minimumID] is Circle) Console.WriteLine($"Circle has minimum area: {areas[minimumID]}");
else if (figures[minimumID] is Triangle) Console.WriteLine($"Triangle has minimum area: {areas[minimumID]}");
else Console.WriteLine($"Rectangle has minimum area: {areas[minimumID]}");