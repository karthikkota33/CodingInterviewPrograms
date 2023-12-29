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
        int[] arr1 = {2, 33,67,4, 6, 8, 10,55};
        string result = ReverseArray(arr1);
        Console.WriteLine (result);
    }
    
    public static string ReverseArray(int[] inputArray){
        int temp = 0;
        for(int i = 0; i < inputArray.Length -1; i++){
            for(int j = i+1; j <= inputArray.Length-1 ; j++){
                if(inputArray[i] < inputArray[j]){
                    temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        string result = "";
        foreach(int a in inputArray){
            result += a + ",";
        }
        return result;
    }
}

//O/P: 67,55,33,10,8,6,4,2,