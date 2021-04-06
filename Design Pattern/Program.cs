using System;

namespace Design_Pattern
{
    public sealed class singleTon
    {
        public Int32 Data = 0;
        private static singleTon instance;
        private static object syncRoot = new Object(); //For locking mechanism  
        private singleTon() { } //Private constructor  
        public static singleTon Instance //Property  
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new singleTon();
                    }
                }
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //singletone design pattern  
            singleTon s = singleTon.Instance;
            s.Data = 100;
            Console.WriteLine("Data of S object : " + s.Data);
            singleTon s1 = singleTon.Instance;
            Console.WriteLine("Data of S1 object : " + s.Data);
            Console.ReadLine();
        }
    }
}
