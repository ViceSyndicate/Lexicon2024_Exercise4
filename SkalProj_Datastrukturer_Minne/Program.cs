using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        //ToDo: Recursive Exercise
                        break;
                    case '6':
                        //ToDo: Iterative Exercise
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            List<string> stringList = new List<string>();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\n+ <String> to add <String> to the list"
                    + "\n- <String> to subtract <String> from the list"
                + "\n0 To Exit.");

                string input = "";
                char firstLetter = '0';

                input = Console.ReadLine().ToString();
                if (input.Length > 0)
                {
                    firstLetter = input![0];
                    // Remove the first character from the string
                    input = input[1..];
                }
                switch (firstLetter)
                {
                    case '+':
                        stringList.Add(input);
                        break;
                    case '-':
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (stringList[i].Equals(input))
                            {
                                // If pattern match, remove string at that index and break out of the for loop.
                                // I break out of the for loop in order to just remove the first match and not all of them.
                                stringList.RemoveAt(i);
                                break;
                            }
                        }
                        break;
                    case '0':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please start your string input with + or -.");
                        break;
                }
                Console.WriteLine("Current List Capacity: " + stringList.Capacity);
                Console.WriteLine("Current List Count: " + stringList.Count());
                Console.Write("Current List: ");
                foreach (string strings in stringList)
                {
                    Console.Write(strings + ", ");
                }
                Console.WriteLine("\n------------------------------");
            }
            // The Capacity doubles every time we hit...Capacity.
            // and NEVER decreases in size. 

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            Queue<string> queue = new Queue<string>();
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\n+ <String> to add <String> to the list"
                    + "\n- <String> to subtract <String> from the list"
                + "\n0 To Exit.");

                string input = "";
                char firstLetter = '0';

                input = Console.ReadLine().ToString();
                if (input.Length > 0)
                {
                    firstLetter = input![0];
                    // Remove the first character from the string
                    input = input[1..];
                }
                switch (firstLetter)
                {
                    case '+':
                        queue.Enqueue(input);
                        break;
                    case '-':
                        queue.Dequeue();
                        break;
                    case '0':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please start your string input with + or -.");
                        break;
                }
                
                Console.WriteLine("Current Queue Count: " + queue.Count());
                Console.Write("Current Queue: ");
                foreach (string strings in queue)
                {
                    Console.Write(strings + ", ");
                }
                Console.WriteLine("\n------------------------------");
                /*
                * Loop this method untill the user inputs something to exit to main menue.
                * Create a switch with cases to enqueue items or dequeue items
                * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

