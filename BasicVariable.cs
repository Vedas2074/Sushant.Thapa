using System;

class BasicVariable 
{
    public int x;//it stores integer value
    float y;//it stores floating points
    double z;//64 bit 
    char a;//stores single character
    decimal b;//128-bit data type suitable for financial and monetary calculation
    string c;//inorder to store more than one character string is used 
    bool d;//bool are used for true or false statements
    byte e;//byte are 8-bit unsigned integers

    static void Main2(string[] args)
    {
        BasicVariable q = new BasicVariable();
        q.x=123;
        q.y=12.12f;
        q.z=12.12345;
        q.a='m';
        q.b=12.12341234m;
        q.c="This is an statement for string";
        q.d=true;
        q.e=12;

        Console.WriteLine("Integer value is : "+ q.x);
        Console.WriteLine("Float value is : "+ q.y);
        Console.WriteLine("Double value is : "+ q.z);
        Console.WriteLine("Char value is : "+ q.a);
        Console.WriteLine("Decimal value is : "+ q.b);
        Console.WriteLine("String value is : "+ q.c);
        Console.WriteLine("Bool value is : "+ q.d);
        Console.WriteLine("Byte value is : "+ q.e);



    }

    
    
}