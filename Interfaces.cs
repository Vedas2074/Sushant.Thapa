using System;

interface ITestInterface1
{
    void Add(int a,int b);

}
interface ITestInterface2: ITestInterface1
{
    void Sub(int a,int b);


}
class ImplementationClass: ITestInterface2
{
    public void Add(int a,int b)
    {
        Console.WriteLine(a+b);
    }
    public void Sub(int a,int b)
    {
        Console.WriteLine(a-b);
    }

    static void Main12()
    {
        ImplementationClass obj = new ImplementationClass();
        obj.Add(199,299);
        obj.Sub(78,34);

    }
}