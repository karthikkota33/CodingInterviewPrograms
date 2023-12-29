
using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string res = "malayalam"; //"Hello World!";
        string result = IsPalindromeOrNot(res);
        Console.WriteLine(result);
    }
    
    public static string IsPalindromeOrNot(string message){
        //char[] strArray = message.ToCharArray();
        string res = "";
        for(int i =message.Length-1; i >=0; i--){
            res += message[i];
        }
        if(message.ToLower() == res.ToLower()){
            return "Is Palindrome";
        }
        else{
            return "Not Palindrome";
        }
    }
}