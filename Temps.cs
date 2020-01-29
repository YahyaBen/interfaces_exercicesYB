using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_2_Interfaces_Graphiques
{
    class Temps
    {

        Int64 ms;
        Int64 sec;
        Int64 min;
        public Temps()
        {
            min = 0;
            sec = 0;
            ms = 0;
        }
        public Temps(Int64 L)
        {
            ms = L;
        }
        /*public string Convertion( long T)
        {
            ms =  T;
            sec = (long)(ms/ 500);
            min = (sec/60);
            ms = ms - (sec * 500);
            sec = sec - (min * 60);
            return min + " : " + sec + " : " + ms;

        }*/

        public string Millseconde(Int64 T)
        {
            ms = T ;
            ms = ms - (sec * 100);
            return " : " + ms;
        }
        public string seconde(Int64 T)
        {
            sec = (T / 100);
            sec = sec - (min * 60);
            return " : " + sec;
        }

        public string minute(Int64 T)
        {
            min = (T /6000);
            return "  " + min;
        }

    }
}
