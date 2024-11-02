public static class UserInputHandler
{
    public static int GetIntInput(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
                return value;

            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }
}