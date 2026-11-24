using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzes.model
{
    protected abstract class Kolcsonzes
    {
        protected int id;
        protected DateTime kezdet;
        protected DateTime veg;
        protected string statusz;

        protected bool kolcsonzesLezaras
protected Kolcsonzes(int id, DateTime kezdet, DateTime veg, string statusz, bool kolcsonzesLezaras)
        {
            this.id = id;
            this.kezdet = kezdet;
            this.veg = veg;
            this.statusz = statusz;
            this.kolcsonzesLezaras = kolcsonzesLezaras;
        }







    }
}
