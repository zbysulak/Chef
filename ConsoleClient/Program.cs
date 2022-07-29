// See https://aka.ms/new-console-template for more information
using Chef;

Console.WriteLine("Hello, World!");

var k = new Kitchen();
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
    if (i == 10)
    {
        k.PrepareFries();
        //k.PrepareFood();
    }
    if (i == 11)
    {
        k.TakeFromFrier();
    }
    if (i == 30)
    {
        k.TakeFromFrier();
    }
    Thread.Sleep(100);
}