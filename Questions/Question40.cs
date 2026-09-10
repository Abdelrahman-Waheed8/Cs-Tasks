public class Question40
{
    public static void Run()
    {
        int row, column;
        Console.Write("Enter row size: ");
        int.TryParse(Console.ReadLine(), out row);
        Console.Write("Enter column size: ");
        int.TryParse(Console.ReadLine(),out column);
        
        int[,] arr1 = new int[row, column];
        int[,] arr2 = new int[row, column];
        Console.WriteLine($"Array 1 with {row} x {column}: ");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0 ; j < column; j++)
            {
                Console.Write($"Element ({i}, {j}): ");
                while(!int.TryParse(Console.ReadLine(), out arr1[i , j]))
                {
                    Console.Write("Enter a valid number: ");
                }
            }
        }

        for(int i = 0; i < row; i++)
        {
            for(int j = 0 ; j < column; j++)
            {
                arr2[i,j] = arr1[i,j];
            }
        }

        Console.WriteLine($"Copied Array 2 with {row} x {column}: ");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0 ; j < column; j++)
            {
                Console.Write($"{arr2[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}