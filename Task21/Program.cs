Console.Clear();
int x1 = userinput("Введите координату Х точки А: ");
int y1 = userinput("Введите координату Y точки А: ");
int z1 = userinput("Введите координату Z точки А: ");
int x2 = userinput("Введите координату Х точки B: ");
int y2 = userinput("Введите координату Y точки B: ");
int z2 = userinput("Введите координату Z точки B: ");

double res = DisPoint (x1, y1, x2, y2, z1, z2);
Console.Write($"A ({x1},{y1},{z1});B ({x2},{y2},{z2}) -> {res}");
static double DisPoint (int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
static int userinput (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "");
}