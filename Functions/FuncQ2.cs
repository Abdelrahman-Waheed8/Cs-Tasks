public class FuncQ2
{
    public static void ChangeArrayByValue(int[] nums)
    {
        nums[0] = 15; // el original array hatetghayer
        nums = new int[4]; // hena msh hayehsal changes 
    }

    public static void ChangeArrayByReference(ref int[] nums)
    {
        nums = new int[] {9,13,27};
    }
    public static void Run()
    {
        int[] numbers = {5,15,25,35};

        ChangeArrayByValue(numbers);
        Console.WriteLine("Array items after changing by value");
        foreach(int item in numbers)
        {
            Console.WriteLine(item);
        }

        ChangeArrayByReference(ref numbers);
        Console.WriteLine("Array items after changing by reference");
        foreach(int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}