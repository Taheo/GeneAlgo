using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneAlgo
{
    class Person
    {
        private double X;
        private double Y;

        public Person() { }

        public double getPersonX
        {
            get { return X; }
            set { X = value; }
        }

        public double getPersonY
        {
            get { return Y; }
            set { Y = value; }
        }

        public static List<Person> BornPop()
        {

            List<Person> Population = new List<Person>();
            Random rnd = new Random();

            var popsize = rnd.Next(1, 15);
            for (int i = 0; i < popsize; i++)
            {
                Person chop = new Person();
                chop.getPersonX = rnd.Next(0, 10);
                chop.getPersonY = rnd.Next(0, 10);
                Population.Add(chop);
            }

            return Population;
            
        }
    }
}
