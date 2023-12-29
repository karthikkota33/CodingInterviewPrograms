// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Hello World";
        int result = GetWordCount(str);
        Console.WriteLine(result);
    }
    
        public static int GetWordCount(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            input = input.Trim();
            var length = input.Split(' ').Length;
            return length;
        }
}