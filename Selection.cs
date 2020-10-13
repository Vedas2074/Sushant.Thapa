using System;

class SelectionDemo
{
    static void Main1(string[] args)
    {
        SelectionDemo obj1 = new SelectionDemo();

        obj1.LearnIfElse();
        obj1.LearnSwitch();

    }
    void LearnIfElse()
    {
        Console.WriteLine("Enter any Number:");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);


        if (x == 54)
        {
            Console.WriteLine("Great! you entred successfully!");

        }
        else
        {
            Console.WriteLine("your number doesn't matches.");
        }
    }

    void LearnSwitch()
    {
        char choose = 'b';
        switch (choose)
        {
            case 'a':
                Console.WriteLine("YOU HAVE CHOOSE A");
                break;
            case 'b':
                Console.WriteLine("YOU HAVE CHOOSE B");
                break;
            case 'c':
                Console.WriteLine("YOU HAVE CHOOSE C");
                break;
            case 'd':
                Console.WriteLine("YOU HAVE CHOOSE D");
                break;
            default:
                Console.WriteLine("YOU HAVE ENTERED WRONG OPTION");

                break;

        }
    }
}