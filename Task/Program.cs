using Task;

List<Point> points = new List<Point>();
FigureGenerator fRnd = new FigureGenerator(); //figure randomazer object
Random rnd = new Random();

const int POINT_AMOUNT = 10;

Console.WriteLine("Dots' coordinates:\n");

for (int i = 0; i < POINT_AMOUNT; i++)
{
    Point p = fRnd.GeneratePoint();
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
    figures.Add(new Circle(fRnd.GenerateCircle()));
    figures.Add(new Triangle(fRnd.GenerateTriangle()));
    figures.Add(new Rectangle(fRnd.GenerateRectangle()));
}

for (int i = 0; i < FIGURE_TYPES * FIGURE_AMOUNT; i++)
{
    areas.Add(figures[i].GetArea());
    Console.WriteLine($"{figures[i].Name} {i} has area: {areas[i]} {figures[i].Color}");
}

int maximumID = areas.IndexOf(areas.Max());
int minimumID = areas.IndexOf(areas.Min());

Console.WriteLine($"\n\n{figures[maximumID].Name} {maximumID} has maximum area: {areas[maximumID]}");
Console.WriteLine($"{figures[minimumID].Name} {minimumID} has minimum area: {areas[minimumID]}");
