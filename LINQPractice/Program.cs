using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Life is Beautiful",
                              "Arshika Agarwal",
                              "Seven Pounds",
                              "Rupali Agarwal",
                              "Pearl Solutions",
                              "Vamika Agarwal",
                              "Vidya Vrat Agarwal",
                              "C-Sharp Corner Mumbai Chapter"
                           };
            //Linq query  
            IEnumerable<string> namesOfPeople = from name in names
                                                where name.Length <= 16
                                                select name;
            foreach (var name in namesOfPeople)
            {
                txtDisplay.AppendText(name + "\n");
            }
        }
    }
}
