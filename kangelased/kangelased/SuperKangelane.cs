using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelased
{
    public class SuperKangelane : Kangelane
    {
        private double _Osavus;

        public SuperKangelane(string Nimi, string Asukoht) : base(Nimi, Asukoht)
        {
            _Osavus = SingleRandom.Instance.Next(1, 51)/10.0; // arvud 1 kuni 5
        }

        public override int Päästa(int Ohustatuid)
        {
            return (int)Math.Round((95 + _Osavus) / 100 * Ohustatuid, 0);
        }
        public override string ToString()
        {
            return base.ToString()+" ja ta on selles "+_Osavus+" protsenti parem kui lihtsalt kangelased";
        }
    }
}
