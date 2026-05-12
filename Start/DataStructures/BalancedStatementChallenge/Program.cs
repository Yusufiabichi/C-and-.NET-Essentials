
using System;
using System.Collections.Generic;

namespace BalancedStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testStatements =
            {
                "print ('Hello, World!')",
                "if (x > 0) { print(x); }",
                "for (int i = 0; i < 10; i++ print(i); }",
                "print 'Hello, World!')",
                "f(x) = g(x[2)",
                "([{})({])",
                "{",
                ")"
            };

            foreach (string Teststr in testStatements)
            {
                bool result = CheckBalanced(Teststr);
                Console.WriteLine($"Statement: {Teststr} {(result ? "is" : "is not" )}  Balanced.");
            }
        }

        static bool CheckBalanced(string TestStatement)
        {
            Stack<char> tempStack = new Stack<char>();
            foreach(char c in TestStatement)
            {
                if(c == '[' || c == '{' || c == '(')
                {
                    tempStack.Push(c);
                }
                if(c == ']' || c == '}' || c == ')')
                {
                    if(tempStack.Count == 0)
                    {
                        return false;
                    }
                    char TestChar = tempStack.Pop();
                    if(c == ')' && TestChar != '(')
                    {
                        return false;
                    }
                    if(c == ']' && TestChar != '[')
                    {
                        return false;
                    }
                    if(c == '}' && TestChar != '{')
                    {
                        return false;
                    }
                }
            }
            if(tempStack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}