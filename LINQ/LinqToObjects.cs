using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class LinqToObjects : Form
    {
        private readonly object txtDisplay;

        public LinqToObjects()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
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
                AppendText(name + "\n");
            }
        }

        private void AppendText(string v)
        {
            throw new NotImplementedException();
        }
    }
}
