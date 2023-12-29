using System.Collections;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Karthik!");
// Console.Write("Welcome to VS Code!");

// int firstValue = 500;
// int secondValue = 600;
// Console.WriteLine(Math.Min(firstValue, secondValue));

// string name = "Bob";
// name.StartsWith("K");

string originalMessage = "Malayalam"; //"The quick brown fox jumps over the lazy dog.";
//string originalMessage = "The";


char[] message = originalMessage.ToCharArray();
Array.Reverse(message);
string newMessage = new String(message);

string revMessage = "";

for (int i = originalMessage.Length - 1; i >= 0; i--)
{
    revMessage += originalMessage[i];
}
Console.WriteLine($"Using Loop {revMessage}");

Console.WriteLine($"Using Array {newMessage}");

// int x = Console.ReadLine();

// Console.WriteLine(x);

decimal tax = .12051m;
Console.WriteLine($"Tax % is {tax:P2}");

//Reverse the words
string[] ar = originalMessage.Split(' ');
string res = "";
for(int i = ar.Length - 1; i >= 0; i--){
    res += ar[i] + " ";
}
Console.WriteLine($"words reverse is {res}");

//Palindrome or not
//First reverse the string, then compare the 2 string values
if(originalMessage.ToLower() == revMessage.ToLower()){
    Console.WriteLine($"string {originalMessage} is palindome");
}
else{
  Console.WriteLine($"string {originalMessage} is not palindome");  
}

//Prime numbers
int num = 24;
if(num % 2 == 0){
    Console.WriteLine($" Number {num} is prime");
}
else{
    Console.WriteLine($" Number {num} is not a prime");
}

//count of characters in string
string originalMessage1 = originalMessage;
while(originalMessage1.Length > 0){
    int cal = 0;
    for(int i = 0; i < originalMessage1.Length; i++){
        if(originalMessage1[0] == originalMessage1[i]){
            cal++;
        }
    }
    Console.WriteLine(originalMessage1[0] + ": " + cal);
    originalMessage1 = originalMessage1.Replace(originalMessage1[0].ToString(), "");
}
//Console.ReadLine();

//Fibonacci series

int a = 0; int b = 1;
int c = 0;
//int num = 5;
Console.WriteLine("{0} {1}", a, b);
for(int i = 2; i < 5; i++){
    c = a + b;
    Console.WriteLine("{0}", c);
    a = b;
    b= c;
}

//Duplicate in the string
//logic is right but program not running
var charList = new List<char>();
string result = "";
foreach (char item in originalMessage.ToLower())
{
    if(charList.Contains(item)){
        if(!result.Contains(item)){
            result += item;
        }
    }
    else{
        charList.Add(item); 
    }
}
Console.WriteLine("Duplicate Found : {0} ", result);

//Remove duplicates from a string
var newlist = new List<char>();
foreach(char item in originalMessage.ToLower()){
    if(!newlist.Contains(item)){
    newlist.Add(item);
    }
}
Console.WriteLine("After removing Duplication : {0}", new String(newlist.ToArray()));
