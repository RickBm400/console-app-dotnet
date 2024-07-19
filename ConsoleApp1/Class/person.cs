using System;
using System.Dynamic;
class Person()
{
    // create a dictionary for role type
    private readonly Dictionary<int, string> KEYS = new(){
        {0, "Madre"},
        {1, "Padre"},
        {2, "Hijx"}
    };
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? Rol { get; private set; }


    // Initialize person
    public Person(string name, string lastName, int age, int rol) : this()
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Rol = KEYS[rol];
    }
    public void FullInfo()
    {
        Console.WriteLine(
         @$"
            Name: {Name},
            LastName: {LastName},
            Age: {Age},
            Rol: {Rol}
        "
        );
    }
}

