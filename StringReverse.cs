using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string res = "Hello World!";
        //Console.WriteLine(res); 
        string result = StringReverse(res);
        Console.WriteLine($"With Array:{result}");
        
        result = StringReverseWithFor(res);
        
        Console.WriteLine($"With Loop:{result}");
    }
    
    public static string StringReverse(string message){
        char[] strArray = message.ToCharArray();
        Array.Reverse(strArray);
        return new String(strArray);
    }
    
    public static string StringReverseWithFor(string message){
        string reverseString ="";
        for(int i = message.Length -1; i >= 0; i--){
            reverseString += message[i];
        }
        return reverseString;
    }
}