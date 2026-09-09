public class Question25
{
    public static void Run()
    { 
        Console.WriteLine("==============================================");
        Console.WriteLine("               Simple Calculator              ");
        Console.WriteLine("==============================================");

        double number1;
        Console.Write("Enter First number: ");
        while (!double.TryParse(Console.ReadLine(), out number1))
        {
            Console.Write("Invalid input. Enter First number: ");
        }
        char operation;
        Console.Write("Enter Operation (+, -, x, /): ");
        while (!char.TryParse(Console.ReadLine(), out operation) || (operation != '+' && operation != '-' && operation != 'x' && operation != '*' && operation != '/'))
        {
            Console.Write("Invalid operation. Enter Operation (+, -, x, /): ");
        }
        double number2;
        Console.Write("Enter Second number: ");
        while (!double.TryParse(Console.ReadLine(), out number2))
        {
            Console.Write("Invalid input. Enter Second number: ");
        }

        if(operation == '+')
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }
        else if(operation == '-')
        {
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        }
        else if(operation == 'x' || operation == '*')
        {
            Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
        }
        else if(operation == '/')
        {
            while (number2 == 0)
            {
                Console.Write("Cannot divide by zero. Enter Second number: ");
                double.TryParse(Console.ReadLine(), out number2);
            }
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
    }
}