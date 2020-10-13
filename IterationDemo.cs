using System;
class IterationDemo
{
    static void Main21(string[] args)
    {
        IterationDemo obji = new IterationDemo();
        obji.LearnForLoop();
        obji.LearnWhileLoop();

    }
    void LearnForLoop()

    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Nepal is a beautiful country.");
        }
        int[] numbers = { 12, 23, 1232, 43, 123 };
        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");//USE OF STRING INTERPOLATION
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }

        }


    }

    void LearnWhileLoop()
    {
        char opinions = 'Y';
        while (opinions == 'Y')
        {

            Console.WriteLine("Nepal is landlocked country");
            Console.WriteLine("Print One more time?");
            opinions = Console.ReadKey().KeyChar;

        }

        do
        {
            Console.WriteLine("There are 77 district in Nepal");
            Console.WriteLine("Print One more Time?");
            opinions = Console.ReadKey().KeyChar;
        } while (opinions == 'Y');
    }

}