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
    }
}
