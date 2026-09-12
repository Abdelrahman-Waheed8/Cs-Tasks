public class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Action> Questions = new Dictionary<int, Action>
        {
            { 1, Question01.Run },
            { 2, Question02.Run },
            { 3, Question03.Run },
            { 4, Question04.Run },
            { 5, Question05.Run },
            { 6, Question06.Run },
            { 7, Question07.Run },
            { 8, Question08.Run },
            { 9, Question09.Run },
            { 10, Question10.Run },
            { 14, Question14.Run },
            { 15, Question15.Run },
            { 16, Question16.Run },
            { 17, Question17.Run },
            { 18, Question18.Run },
            { 19, Question19.Run },
            { 20, Question20.Run },
            { 21, Question21.Run },
            { 22, Question22.Run },
            { 23, Question23.Run },
            { 24, Question24.Run },
            { 25, Question25.Run },
            { 26, Question26.Run },
            { 27, Question27.Run },
            { 28, Question28.Run },
            { 29, Question29.Run },
            { 30, Question30.Run },
            { 31, Question31.Run },
            { 32, Question32.Run },
            { 33, Question33.Run },
            { 34, Question34.Run },
            { 35, Question35.Run },
            { 36, Question36.Run },
            { 37, Question37.Run },
            { 38, Question38.Run },
            { 39, Question39.Run },
            { 40, Question40.Run },
            { 41, Question41.Run },
        };
        Dictionary<int, Action> FuncQuestions = new Dictionary<int, Action>
        {
            {1, FuncQ1.Run },
            {2, FuncQ2.Run },
            {3, FuncQ3.Run },
            {4, FuncQ4.Run },
            {5, FuncQ5.Run },
            {6, FuncQ6.Run },
            {7, FuncQ7.Run },
            {8, FuncQ8.Run }
        };

        int categoryChoice;
        int questChoice;
        Console.WriteLine("============ C# Basics Tasks ============");
        Console.Write("Enter 1 for Normal Quesitons 2 for functions question: ");
        while(!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > 2)
        {
            Console.Write("Invalid choice! Enter valid choice 1 Normal Quesitons or 2 Functions Questions: ");
        }

        
        if(categoryChoice == 1)
        {
            Console.Write("Enter question number to run: ");
            if(int.TryParse(Console.ReadLine(), out questChoice) && Questions.ContainsKey(questChoice))
            {
                Console.WriteLine($"\n            Running Question {questChoice}\n");
                Questions[questChoice].Invoke();
            }
            else Console.WriteLine("Invalid input or question not found!");
        }
        else if( categoryChoice ==2)
        {
            Console.Write("Enter Function question number to run: ");
            if(int.TryParse(Console.ReadLine(), out questChoice) && FuncQuestions.ContainsKey(questChoice))
            {
                Console.WriteLine($"\n            Running Function Question {questChoice}\n");
                FuncQuestions[questChoice].Invoke();
            }
            else Console.WriteLine("Invalid input or question not found!");
        }
    }
}
