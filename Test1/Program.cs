using System;
namespace Test1;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("I LOVE C#!!");
        Console.WriteLine("Na kmetiji je lepo");
        Console.WriteLine("I-A-I-A-O");
        Console.WriteLine("Tam imamo osla dva");
        PrintMessage("I-A-I-A-O");

        Sample();
    }
  
    public static void PrintMessage(String a)
    {
        Console.WriteLine(a);
    }   

    public static void Sample() 
    {
    
        Console.WriteLine("This is a sample method.");
        Console.WriteLine("It does not do much, but it is here for demonstration.");

    }



}





