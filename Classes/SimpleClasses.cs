using Blazored.LocalStorage;

namespace TAISEN.Classes
{

    public class SEtape
    {
        public string Etape { get; set; }
        public string Objectif { get; set; }
        public IEnumerable<Atelier> Ateliers { get; set; }
    }

    public class Atelier
    {
        public string Nom { get; set; }
        public string? Prerequis { get; set; }
        public int Poids { get; set; }
        public IEnumerable<Processus> Processus { get; set; }
        public IEnumerable<Livrables> Livrables { get; set; }
    }

    public class Processus
    {
        public string Nom { get; set; }
        public bool Fin { get; set; }
    }

    public class Livrables
    {
        public string Nom { get; set; }
        public string? CR { get; set; }
    }


}
