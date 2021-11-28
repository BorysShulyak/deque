using System;

using DequeLibrary;

namespace DequeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque<string> usersDeck = new Deque<string>();
            usersDeck.RegisterHandler(ShowInfoMessage);

            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Deleted: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);
        }

        private static void ShowInfoMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
