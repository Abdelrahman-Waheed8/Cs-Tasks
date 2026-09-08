public class Question06
{
    public static void Run()
    {
        int[] arr1 = {12,8,61,30};
        int[] arr2 = arr1;

        Console.WriteLine("Before Modifying:\nArray 1: ");
        for(int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine("\nArray 2: ");
        for(int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }

        arr2[1] = 150;
        Console.WriteLine("\n\nAfter Modifying element with index[1] to 150:\nArray 1:");
        for(int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine("\nArray 2: ");
        for(int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine("\nAfter modifying in array 2, array 1 also changed because arrays are reference type variables");
    }
}