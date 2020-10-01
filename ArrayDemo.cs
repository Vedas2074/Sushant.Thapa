using System;


class ArrayDemo
{
    int[] num={12,345,2,35,9,56,100};
    
    string[] cars={"Buggati","Farrari","Mercedies","Lamborgani","Ford","Royal Royce"};


    static void Main3(string[] args)
    {
        ArrayDemo arr = new ArrayDemo();
        Array.Sort(arr.num);
        foreach(int i in arr.num)
        {
            Console.WriteLine(i);

        }
        foreach(string i in arr.cars)
        {
            Console.WriteLine(i);
        }
    }
}