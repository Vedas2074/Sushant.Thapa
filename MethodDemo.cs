using System;
public class MethodDemo
{
    static void Main14()
    {
        MethodDemo obj21 = new MethodDemo();
        // double sum = obj21.Sum(123.123, 23432.234);
        // Console.WriteLine($"Sum is {sum}");
        obj21.printEven();


    }
    public double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;

    }
    public int[] arrayNum={12,43,14,53,22,76};
    void printEven()
    {
        foreach(int i in arrayNum)
        {
            if(i%2==0)
            {
                Console.WriteLine($"{i} is even number");//Even Number 
            }
            else
            {
                Console.WriteLine($"{i} is odd number");//Odd Number
            }
        }
    }


}