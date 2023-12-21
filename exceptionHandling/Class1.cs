using System;
public class A
{
    static A x = new A();
    A() {
        
        Console.WriteLine("This is Default Constuctor");
    } 
    A(int x)
    {
        Console.WriteLine(x);
        Console.WriteLine("This is parameterised Constructor");
    }
    void M1()
    {
        Console.WriteLine(x.M2(Convert.ToInt32(Console.ReadLine())));
        Console.WriteLine("This is method 1");
    }
    int M2(int a)
    {

        Console.WriteLine("This is method 2");
        Console.WriteLine(M3(Console.ReadLine()));
        return a * a;
    }
    static String M3(String a)
    {
        return a;
    }
    public static void Main(String[] args)
    {
        A x = new A();
        new A(4);
        x.M1();
    }
}