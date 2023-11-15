using System;

class Program
{
    static void Main() //"void" used to associate with the class and not a specific instance (object) of said class
    {
        WriteMessage();
        Console.ReadLine();
    }
    static void WriteMessage() //see void comment above
    {
        Console.WriteLine("Denne metoden returnerer ingenting"); //program window displays and behaves differently depending on
        // whether you called WriteLine directly in Main or through adding and calling another method (WriteMessage)
    }
}