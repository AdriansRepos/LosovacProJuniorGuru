using InputHelper;
using System.Globalization;

namespace LosovacProJuniorGuru
{
    class Soutezici
    {        
        public string Jmeno { get; private set; }

        public Soutezici(string jmeno)
        {
            Jmeno = TitleCase.ToTitleCase(jmeno);
        }

        public override string ToString()
        {
            return Jmeno;
        }
    }
}