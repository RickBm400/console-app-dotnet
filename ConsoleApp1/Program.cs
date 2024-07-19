using System;
class Base
{
    static void Main()
    {
        Person Rick = new(name: "Rick", lastName: "Bm", age: 30, rol: 2);
        Person Amber = new(name: "Amber", lastName: "Bm", age: 20, rol: 0);
        Rick.FullInfo();
        Amber.FullInfo();
    }
}