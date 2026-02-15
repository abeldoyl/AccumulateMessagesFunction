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

                if ((userInput != "Q" && userInput != "q"))
                {
                    if (string.IsNullOrEmpty(message))
                    {
                        message = userInput;
                    }

                    //adds new line if input is left blank
                    else
                    {
                        message = message + "\n" + userInput;
                    }
                    addString = message;
                }
                Console.Clear();
                Console.WriteLine(addString);
            } while (userInput != "Q" && userInput != "q");
            
            //Displays message before quitting
            Console.Clear();
            Console.WriteLine($"Your message is: \n{addString}");
            Console.WriteLine();

            //pause
            Console.Read();
        }
    }
}
