using System;

struct Books
{
    private string title;
    private string subject;
    private string author;
    private int id;
    public void getvalues(string t, string a, string s, int i)
    {
        title = t;
        author = a;
        subject = s;
        id = i;

    }
    public void DisplayVal()
    {
        Console.WriteLine("Title :" + title);
        Console.WriteLine("Author :" + author);
        Console.WriteLine("Subject :" + subject);
        Console.WriteLine("Id :" + id);
    }
};

public class testStructure
{
    public static void Main8(string[] args)
    {
        Books Book1 = new Books();
        Books Book2 = new Books();


        Book1.getvalues("CSharp", "Belly Melly", "Programming", 123);
        Book2.getvalues("Compiler construction and design", "Johnny", "Computing", 343);

        Book1.DisplayVal();
        Book2.DisplayVal();

    }
}