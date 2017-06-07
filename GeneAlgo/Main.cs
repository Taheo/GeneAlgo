using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneAlgo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        double RastriginFunction(double x, double y)
        {
            return -(20 + (Math.Pow(x, 2) - 20 * Math.Cos(2 * Math.PI * Math.Pow(x, 2))) + (Math.Pow(y, 2) - 20 * Math.Cos(2 * Math.PI * Math.Pow(y, 2))));
        }


        List<Person> pop = Person.BornPop();
        List<Person> newborn = new List<Person>();
    
        List<Person> CalcFunctValue()
        {
            
            foreach (var item in pop)
            {
                item.getPersonZ = RastriginFunction(item.getPersonX, item.getPersonY);
                newborn.Add(item);
            }

            return newborn;
        }

        List<Person> selectedpop = new List<Person>();
        List<Person> SelectionByAverage() //jedna metoda selekcji
        {
            var average = newborn.Average(item => item.getPersonZ);

            var MakeSelectionByAverage = from q in newborn
                                         where q.getPersonZ > average
                                         select q;

            foreach (var q in MakeSelectionByAverage)
            {
                selectedpop.Add(q);
            }
            return selectedpop;
        }

        List<Person> SelectionByBest() //druga metoda selekcji
        {


            var MakeSelectionByBest = (from q in newborn
                                       select q).Take(2);

            foreach (var q in MakeSelectionByBest)
            {
                selectedpop.Add(q);
            }
            return selectedpop;
        }
    }
}
