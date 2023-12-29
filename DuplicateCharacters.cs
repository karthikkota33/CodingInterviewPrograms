// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Malayalam";
        string result = DuplicateCharacters(str);
        Console.WriteLine(result);
    }
    
    public static string DuplicateCharacters(string message){
        var charList = new List<char>();
        string res = "";
        foreach(char ch in message.ToLower()){
            if(charList.Contains(ch)){
                if(!res.Contains(ch)){
                    res += ch;
                }
            }
            else{
               charList.Add(ch); 
            }
        }
        return res;
    }
}