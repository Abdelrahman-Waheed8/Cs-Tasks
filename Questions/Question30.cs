public class Question30
{
    public static void Run()
    {
        Console.Write("Enter point 1 (x1,y1): ");
        double.TryParse(Console.ReadLine(), out double x1);
        double.TryParse(Console.ReadLine(), out double y1);

        Console.Write("Enter point 2 (x2,y2): ");
        double.TryParse(Console.ReadLine(), out double x2);
        double.TryParse(Console.ReadLine(), out double y2);

        Console.Write("Enter point 3 (x3,y3): ");
        double.TryParse(Console.ReadLine(), out double x3);
        double.TryParse(Console.ReadLine(), out double y3);

        double determinant = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

        if(Math.Abs(determinant) < 0.00001) Console.WriteLine("Three points are on same line");
        else Console.WriteLine("Three points are NOT on same line");
    }
}