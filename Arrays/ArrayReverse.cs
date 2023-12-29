// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, 4, 6, 8, 10};
        string result = ReverseArray(arr1);
        Console.WriteLine (result);
    }
    
    public static string ReverseArray(int[] inputArray){
        string res = "";
        for(int i = inputArray.Length-1; i >=0; i--){
            if(inputArray.Length-1 == i){
                res += inputArray[i] + ",";
            }
            else{
                res += inputArray[i];
            }
        }
        return res;
    }
}

//  O/P: 10,8,6,4,2,