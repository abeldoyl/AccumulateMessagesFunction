namespace AccumulateMessagesFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string message = "";
            string addString = message + userInput;

            Console.WriteLine("Enter a new message");
            Console.WriteLine($"To quit press \"Q\"");

            do
            {
                userInput = Console.ReadLine();

                if ((userInput.Equals("Q", StringComparison.OrdinalIgnoreCase)))
                {
                    if (string.IsNullOrEmpty(message))
                    {
                        message = userInput;
                    }

                    else
                    {
                        message = message + "\n" + userInput;
                    }
                    addString = message;
                }
                Console.Clear();
                Console.WriteLine(addString);
            }
        }
    }
}
