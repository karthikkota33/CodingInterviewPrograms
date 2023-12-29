using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Malayalam";
        string result = RemoveDuplicate(str);
        Console.WriteLine(result);
    }
    
    public static string RemoveDuplicate(string message){
        var charList = new List<char>();
        foreach(char ch in message.ToLower()){
            if(!charList.Contains(ch)){
               charList.Add(ch); 
            }
        }
        return new String(charList.ToArray());
    }
}