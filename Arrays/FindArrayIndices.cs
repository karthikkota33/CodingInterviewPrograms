// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// Write a method named FindArrayIndices that takes two parameters: an array of integers named nums, and an integer named target.
            // The purpose is to find the array indices of two integers that add up to the target value.
            // You can assume there is only one solution for a given target.
            // Output the resulting array indices to the console.

            // Examples:
            //         nums = [2, 4, 6, 8, 10], target = 18; answer = 3, 4     
            //        explanation: 8 and 10 add to the target 18, they are located at index 3 and and index 4 in the array
            //
            //         nums = [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2], target = 3, answer = 5, 11
            //        explanation: 1 and 2 add to the target 2, they are located at index 5 and index 11
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, 4, 6, 8, 10};
        int target = 18;
        string result = ArrayIndexes(arr1, target);
        Console.WriteLine (result);
    }
    
    public static string ArrayIndexes(int[] arr1, int target){
        int res = 0;
        string indexes ="";
        for(int i =0; i < arr1.Length-1; i++){
            for(int j = i+1; j<= arr1.Length-1; j++){
                res = arr1[i] + arr1[j];
                //Console.WriteLine(arr1[i]);
                //Console.WriteLine(arr1[j]);
                if(res == target){
                    indexes = i.ToString() + ","+ j.ToString();
                    break;
                }else{
                    continue;
                }
            }
            if(res == target) break;
            //if(arr1.Length > 3){
                //var arList = arr1.ToList();
            //arList.RemoveAt(0);
            //Console.WriteLine(arList[0]);
            //arr1 = arList.ToArray();
            //}
            
        }
        return indexes;
    }
}