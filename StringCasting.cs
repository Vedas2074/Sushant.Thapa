using System;

class StringCasting{
    static void Main(string[] args)
    {
        int number =12;
        Console.WriteLine(number.ToString());

        bool boolean = true ;
        Console.WriteLine(boolean.ToString());

        DateTime now= DateTime.Now;
        Console.WriteLine(now.ToString());

        object me = new object();
        Console.WriteLine(me.ToString());

        byte[] binaryObject = new byte[128];
        (new Random()).NextBytes(binaryObject);
        Console.WriteLine("Binary Object as bytes:");
        for(int index=0;index<binaryObject.Length;index++)
        {
            Console.Write($"{binaryObject[index]:X}");
        }
        Console.WriteLine();

        string encoded = Convert.ToBase64String(binaryObject);
        Console.WriteLine($"Binary Object as Base64:{encoded}");

    }
}