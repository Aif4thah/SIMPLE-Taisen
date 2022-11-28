using Blazored.LocalStorage;
using System.ComponentModel.DataAnnotations;

namespace TAISEN.Classes
{
    public class SEtape
    {
        public string Etape { get; set; }
        public string Objectif { get; set; }
        public IEnumerable<Atelier> Ateliers { get; set; }

        public bool Check()
        {
            return this.Ateliers is IEnumerable<Atelier> && this.Etape is string && this.Objectif is string;
        }
    }

    public class Atelier
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public string? Prerequis { get; set; }
        public List<string>? Interlocuteurs { get; set; }
        public int Poids { get; set; }
        public IEnumerable<Processus> Processus { get; set; }

        public bool Check()
        {
            return this.Processus is IEnumerable<Processus> && this.Nom is string && this.Description is string && this.Poids is int;
        }

    }

    public class Processus
    {
        public string Nom { get; set; }
        public Referentiel? Referentiel { get; set; }
        public IEnumerable<Outil>? Outils { get; set; }
        public IEnumerable<Livrable> Livrables { get; set; }
        public bool Fin { get; set; }

        public bool Check()
        {
            return this.Livrables is IEnumerable<Livrable> Livrables && this.Nom is string && this.Fin is bool;
        }
    }

    public class Livrable
    {
        public string Nom { get; set; }
        public CompteRendu? CR { get; set; }

        public bool Check()
        {
            return this.Nom is string;
        }
    }

    public class Referentiel
    {
        public string Nom { get; set; }
        public string? Uri { get; set; }

        public bool Check()
        {
            return this.Nom is string;
        }
    }

    public class Outil
    {
        public string Nom { get; set; }
        public string? Uri { get; set; }
        public bool Check()
        {
            return this.Nom is string;
        }
    }

    public class CompteRendu
    {
        public string? Texte { get; set; }
        public List<El>? Els { get; set; }
        public List<FonctionSensible>? FonctionSensibles { get; set; }
        public List<MesureSecurite>? MesureSecurites { get; set; }
        public List<RecetteSecu>? RecetteSecus {get; set;}

    }

    public class El
    {
        public string? Texte { get; set; }
    }

    public class FonctionSensible
    {
        public string Nom { get; set; }
        public bool Spoofing { get; set; }
        public bool Tampering { get; set; }
        public bool Repudiation { get; set; }
        public bool InformationDisclosure { get; set; }
        public bool DenialOfService { get; set; }
        public bool ElevationOfPrivilege { get; set; }
    }

    public class MesureSecurite
    {
        public string? FonctionCible { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public bool SpoofingPrevention { get; set; }
        public bool TamperingPrevention { get; set; }
        public bool RepudiationPrevention { get; set; }
        public bool InformationDisclosurePrevention { get; set; }
        public bool DenialOfServicePrevention { get; set; }
        public bool ElevationOfPrivilegePrevention { get; set; }

    }

    public class RecetteSecu{

            [Required]
            public string? MesureTestee {get; set;}
            [Required]
            [Range(1, 100, ErrorMessage = "doit etre un pourcentage (0-100)")]
            public int? Efficacite {get; set;}
    }



}
