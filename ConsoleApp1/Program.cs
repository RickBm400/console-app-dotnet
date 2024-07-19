using System;
class Base
{
    static void Main()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6];
        Person ola = new(){
            Name = "",
        };
        Console.WriteLine(ola.Name);
        Console.WriteLine(ola.GetAge());
    }
}