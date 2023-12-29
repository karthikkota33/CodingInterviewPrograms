// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "aaabbbccc";
        string result = ConsecutiveCharacter(str.ToCharArray());
        Console.WriteLine(result);
    }
    
    public static string ConsecutiveCharacter(char[] characterArray){
        int len = characterArray.Length - 1;    
           List<char> result = new List<char>();    
           for (int i = 0; i < len; i++)    
           {    
               for (int j = i + 1; j <= len; j++)    
               {    
                   if (characterArray[i] == characterArray[j])    
                   {    
                       if (!result.Contains(characterArray[i]))    
                           result.Add(characterArray[i]);    
                       continue;    
                   }    
                   else    
                   {    
                       break;    
                   }    
               }    
           }  
        return new String(result.ToArray());
    }
}