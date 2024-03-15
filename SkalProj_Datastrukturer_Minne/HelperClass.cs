namespace SkalProj_Datastrukturer_Minne
{
    public static class HelperClass
    {
        public static void CheckParanthesis()
        {
            /*
            * Use this method to check if the paranthesis in a string is Correct or incorrect.
            * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
            * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
            */

            bool loop = true;
            while (loop)
            {

                Console.WriteLine("\n0 To Exit.");
                Console.Write("Enter a string: ");

                string input = "";

                input = Console.ReadLine().ToString();

                Queue<char> symbolQue = new Queue<char>();
                Stack<char> symbolStack = new Stack<char>(); ;
                switch (input)
                {
                    case "0":
                        loop = false;
                        break;
                    default:
                        bool formatFlag = true;
                        for (int i = 0; i < input.Length; i++)
                        {
                            // For each character in the input string 
                            switch (input[i])
                            {
                                // If the current character is ')'
                                case ')':
                                    // AND IF the previous symbol was not '(' OR
                                    // If we don't have anything left in the symbolStack
                                    if (symbolStack.Count == 0 || symbolStack.Pop() != '(') formatFlag = false;
                                    break;
                                case '}':
                                    if (symbolStack.Count == 0 || symbolStack.Pop() != '{') formatFlag = false;
                                    break;
                                case ']':
                                    if (symbolStack.Count == 0 || symbolStack.Pop() != '[') formatFlag = false;
                                    break;
                                // if the current character is an opening bracket symbol, push it to the stack. 
                                case '(': symbolStack.Push(input[i]); break;
                                case '{': symbolStack.Push(input[i]); break;
                                case '[': symbolStack.Push(input[i]); break;
                            }
                        }
                        // After the loop and the symbol stack is empty and the format flag is still true/good
                        if (symbolStack.Count == 0 && formatFlag) Console.WriteLine("Good Format!");
                        else Console.WriteLine("Bad Format!");
                        break;
                }
                // Previous nightmare attempts before googling it. 
                /*
                char parenthesis = ')';
                char curlybracket = '}';
                char squarebracket = ']';

                // If the Deque grabs '(' the next acceptable values are (, {, [ or )
                // If the Deque grabs '{' the next acceptable values are (, {, [ or }
                // If the Deque grabs '[' the next acceptable values are (, {, [ or ]

                // • ), }, ] får enbart förekomma efter respektive (, {, [
                //• Varje parentes som öppnas måste stängas dvs ”(” följs av ”)”

                bool goodFormatFlag = true;
                char previousSymbol = symbolQue.Dequeue();
                for (int i = 0; i < symbolQue.Count();)
                {
                    // prints the same thing you put in

                    char currentSymbol = symbolQue.Dequeue();
                    if (previousSymbol == '(' && currentSymbol == '(' || currentSymbol == '{' || currentSymbol == '[' || currentSymbol != ')')
                    {
                        goodFormatFlag = true;
                    }
                    else if (previousSymbol == '{' && currentSymbol == '(' || currentSymbol == '{' || currentSymbol == '[' || currentSymbol != '}')
                    {
                        goodFormatFlag = true;
                    }
                    else if (previousSymbol == '[' && currentSymbol == '(' || currentSymbol == '{' || currentSymbol == '[' || currentSymbol != ']')
                    {
                        goodFormatFlag = true;
                    }
                    else
                    {
                        goodFormatFlag = false;
                    }
                    previousSymbol = currentSymbol;
                    //Console.Write(currentSymbol + " > ");
                }
                if (goodFormatFlag)
                {
                    Console.WriteLine("Good Format!");
                }
                else
                {
                    Console.WriteLine("Bad Format!");
                }

                Console.WriteLine("--------------");
                /*
                for (int i = 0; i < symbolStack.Count();)
                {
                    // prints out the last symbol thing you put in 
                    Console.Write(symbolStack.Pop() + " > ");
                }
                */

            }
        }
    }
}