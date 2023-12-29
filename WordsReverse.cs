using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string res = "Hello World!";
        string result = WordReverse(res);
        Console.WriteLine($"Word Reverse:{result}");
    }
    
    public static string WordReverse(string message){
        string[] strArray = message.Split(' ');
        string res = "";
        for(int i =strArray.Length - 1; i >=0; i--){
            res += strArray[i] + " ";
        }
        return res;
    }
}