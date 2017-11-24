using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


abstract class Airplane
{

    public abstract void FlyingMethod();
    public string Flying()
    {
        return "난다";
    }
}
class Combatplane : Airplane
{

    public override void FlyingMethod()
    {
        Console.WriteLine("전투기는 빠르게 " + Flying());
    }
}
class Airliner : Airplane
{
    public override void FlyingMethod()
    {
        Console.WriteLine("여객기는 천천히 " + Flying());
    }
}


namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane ar = new Airliner();
            ar.FlyingMethod();

            Console.WriteLine();

            Airplane ar2 = new Combatplane();
            ar2.FlyingMethod();

        }
    }
}
