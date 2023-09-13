using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlanets.Control;

namespace ThePlanets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observatory observatory = new Observatory();
            observatory.Start();
        }
    }
}
