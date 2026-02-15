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

            do
            {
                Console.WriteLine("To make a new message press \"enter\"");
                Console.WriteLine($"When finished press \"Q\" to display full message then quit");
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
                Console.WriteLine(message);
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
