using System;
class IterationDemo
{
    static void Main(string[] args)
    {
        IterationDemo obji=new IterationDemo();
        obji.LearnForLoop();

    }
    void LearnForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Nepal is a beautiful country.");
        }
        int[] numbers = {12,23,1232,43,123};
        foreach(int x in numbers)
        {
            if(x%2==0)
            {
                Console.WriteLine($"{x} is even.");//USE OF STRING INTERPOLATION
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }

        }


    }
}