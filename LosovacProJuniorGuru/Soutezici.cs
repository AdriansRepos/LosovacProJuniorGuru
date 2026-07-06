using InputHelper;

namespace LosovacProJuniorGuru
{
    class Soutezici
    {
        private string _jmeno = string.Empty;
        public string Jmeno 
        { 
            get => _jmeno; 
            private set => _jmeno = TitleCase.ToTitleCase(value); }

        public Soutezici(string jmeno)
        {
            Jmeno = jmeno;
        }

        public override string ToString()
        {
            return Jmeno;
        }
    }
}