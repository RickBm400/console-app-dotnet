using System;
using System.Dynamic;
class Person
{
    public required string Name { get; set; }
    private readonly int Age = 40;


    public string GetAge()
    {
        return $"the local age is {Age}";
    }
}

