using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosovacProJuniorGuru
{
    class Soutez
    {
        private readonly List<Soutezici> soutezici = [];
        private readonly List<Soutezici> vyherci = [];

        public Soutezici PridejSouteziciho(string jmeno)
        {
            var s = new Soutezici(jmeno);
            soutezici.Add(s);
            return s;
        }

        public Soutezici[] VratVsechny()
        {
            return [.. soutezici];
        }

        public void OdeberSouteziciho(string jmeno)
        {
            var soutezici_k_odebrani = soutezici.FirstOrDefault(s => s.Jmeno == jmeno);
            if (soutezici_k_odebrani != null)
                soutezici.Remove(soutezici_k_odebrani);
        }

        public void Losuj(int pocet)
        {
            vyherci.Clear();

            if (pocet <= 0 || pocet > soutezici.Count)
                return;

            Random r = new();
            var kopie = new List<Soutezici>(soutezici);

            for (int i = 0; i < pocet; i++)
            {
                int index = r.Next(kopie.Count);
                vyherci.Add(kopie[index]);
                kopie.RemoveAt(index);
            }
        }

        public Soutezici[] VratVyherce()
        {
            return [.. vyherci];
        }
    }
}