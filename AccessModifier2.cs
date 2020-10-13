using System;
class AccessModifier2 : AccessModifier
{
    static void Main4(string[] args)
    {
        AccessModifier2 acc = new AccessModifier2();
        Console.WriteLine("Internal Access " + acc.internalString);//Internal Access Modifier Only accessable within the same project
        Console.WriteLine("Private Protected " + acc.privateprotectedbyte);//Private Protected Access MOdifier can only accessable through same class or child class
        Console.WriteLine(acc.protectedDecimal);
        Console.WriteLine(acc.protectedinternalBool);
        Console.WriteLine(acc.publicInteger);


    }
}