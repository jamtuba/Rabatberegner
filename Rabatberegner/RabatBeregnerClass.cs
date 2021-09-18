using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabatberegner
{
    public class RabatBeregnerClass
    {
        public double GetPrisEfterRabat(int antalVarer, double stykPris)
        {
            double bruttoPris = antalVarer * stykPris;
            if (bruttoPris > 1000 && antalVarer > 10)
            {
                // Indkøb over 1000 kr. og flere end 10 varar giver 5% rabat
                double rabat = bruttoPris * 0.05;
                bruttoPris -= rabat;
            }
            else if (bruttoPris > 1000)
            {
                // Indkøb over 1000 kr. giver 3% rabat
                double rabat = bruttoPris * 0.03;
                bruttoPris = bruttoPris - rabat;
            }
            else if (antalVarer > 10)
            {
                // Flere end 10 varer giver 2% rabat
                double rabat = bruttoPris * 0.02;
                bruttoPris = bruttoPris - rabat;
            }

            return bruttoPris;
        }

    }
}
