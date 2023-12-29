using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //string res = "malayalam"; //"Hello World!";
        int num = 101;
        string result = IsPalindromeOrNot(num);
        Console.WriteLine(result);
    }
    
    public static string IsPalindromeOrNot(int number){
        int reminder, sum = 0;    
            int tempNumber;    
            tempNumber = number;   
            while (number > 0)    
            {    
                reminder = number % 10;    
                number = number / 10;    
                sum = sum * 10 + reminder;    
                if (tempNumber == sum)    
                {    
                    return "Is Palindrome";    
                }    
            }    
            return "Is Not Palindrome";  
    }
}