using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 5;
        FibonacciSeries(num);
        //Console.WriteLine(res);
    }
    
    public static void FibonacciSeries(int number){
        int a = 0, b= 1, result = 0;
        if(number == 0){
            Console.WriteLine(0);
            return;
        }
        if(number == 1){
            Console.WriteLine(1);
            return;
        }
        Console.WriteLine($"{0} {1}", a , b);
        for(int i = 2; i < number; i++){
            result = a + b;
            Console.WriteLine(result);
            a = b;
            b=result;
        }
        //return result;
    }
}