using System;
using System.Threading;

Console.WriteLine("Hello, Jerry");
PrintLetters();
Thread.Sleep(500);
PrintLetters();
Thread.Sleep(500);
PrintLetters();
Thread.Sleep(500);
A();
A();

void PrintLetters()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    Console.WriteLine("Function A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Function B");
}

void C()
{
   Console.WriteLine("Function C"); 
}