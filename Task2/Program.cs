using Task2;

List<Point> points = new List<Point>();
FigureGenerator fRnd = new FigureGenerator(); //figure randomazer
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

/*for (int i = 0; i < FIGURE_TYPES * FIGURE_AMOUNT; i++)
{
    
}*/

for (int i = 0; i < FIGURE_TYPES * FIGURE_AMOUNT; i++)
{
    areas.Add(figures[i].GetArea());
    if (figures[i] is Circle) Console.WriteLine($"Circle {i} has area: {areas[i]}");
    else if (figures[i] is Triangle) Console.WriteLine($"Triangle {i} has area: {areas[i]}");
    else Console.WriteLine($"Rectangle {i} has area: {areas[i]}");
}

int maximumID = areas.IndexOf(areas.Max());
int minimumID = areas.IndexOf(areas.Min());

if (figures[maximumID] is Circle) Console.WriteLine($"\n\nCircle {maximumID} has maximum area: {areas[maximumID]}");
else if (figures[maximumID] is Triangle) Console.WriteLine($"\n\nTriangle {maximumID} has maximum area: {areas[maximumID]}");
else Console.WriteLine($"\n\nRectangle {maximumID} has maximum area: {areas[maximumID]}");

if (figures[minimumID] is Circle) Console.WriteLine($"Circle {minimumID} has minimum area: {areas[minimumID]}");
else if (figures[minimumID] is Triangle) Console.WriteLine($"Triangle {minimumID} has minimum area: {areas[minimumID]}");
else Console.WriteLine($"Rectangle {minimumID} has minimum area: {areas[minimumID]}");