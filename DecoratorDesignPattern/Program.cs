using System;

namespace DecoratorDesignPattern
{

    public class Car
    {
        public virtual void CarType()
        {
            Console.WriteLine("Simple Car");
        }
    }
    public class WithAC : Car
    {
        public override void CarType()
        {
            //base.CarType();  
            Console.Write("AC Car");
        }
    }
    public class WithSoundSystemAndAC : WithAC
    {
        public override void CarType()
        {
            base.CarType();
            Console.WriteLine("with Sound system");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car objCarAC = new WithAC();
            objCarAC.CarType();
            Console.WriteLine("\n");
            Car objCarAll = new WithSoundSystemAndAC();
            objCarAll.CarType();
            Console.ReadLine();
        }
    }
}

