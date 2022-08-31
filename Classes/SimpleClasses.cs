using Blazored.LocalStorage;
using System.ComponentModel.DataAnnotations;

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
        public string Description { get; set; }
        public string? Prerequis { get; set; }
        public List<string>? Interlocuteurs {get; set;}
        public int Poids { get; set; }
        public IEnumerable<Processus> Processus { get; set; }
        
    }

    public class Processus
    {
        public string Nom { get; set; }
        public Referentiel? Referentiel { get; set; }
        public IEnumerable<Livrable>? Livrables { get; set; }
        public bool Fin { get; set; }

    }

    public class Livrable
    {
        public string Nom { get; set; }
        public string? CR { get; set; }
    }

    public class Referentiel
    {
        public string Nom {get; set;}
        public string? Uri {get;set;}
    }

    public class Outil
    {
        public string Nom { get; set; }
        public string? Uri { get; set; }
    }


}
