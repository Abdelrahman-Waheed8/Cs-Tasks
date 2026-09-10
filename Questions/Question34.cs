public class Question34
{
    public static void Run()
    {
        int[] arr1 = {5,9,1,4,2};
        int[] arr2 = {15,3,7,6,8};
        int size= arr1.Length + arr2.Length;
        int[] arr3 = new int[size];

        Console.Write("First array: ");
        for(int i = 0; i< arr1.Length; i++)
        Console.Write($"{arr1[i]} ");

        Console.Write("\nSecond array: ");
        for(int i = 0; i< arr2.Length; i++)
        Console.Write($"{arr2[i]} ");

        for(int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i];
        }

        for(int i = 0; i < arr2.Length; i++)
        {
            arr3[i + arr2.Length] = arr2[i];
        }
        Array.Sort(arr3);
        Console.Write("\nMerged array: ");
        for(int i = 0; i< size; i++)
        Console.Write($"{arr3[i]} ");
    }
}