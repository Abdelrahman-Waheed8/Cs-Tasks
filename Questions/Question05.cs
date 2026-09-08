public class Question05
{
    public static void Run()
    {
        int n1 = 5;
        int n2 = 10;
        n1 = n2;
        Console.WriteLine($"Before Modifying:\nN1= {n1}\nN2= {n2}");
        n1 *= 3;
        Console.WriteLine($"\nAfter Modifying:\nN1= {n1}\nN2= {n2}\nNothing Changed in N2 as integers are value type variables");
    }
}