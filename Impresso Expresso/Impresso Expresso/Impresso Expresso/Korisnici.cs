//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impresso_Expresso
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnici
    {
        public Korisnici()
        {
            this.Narudzbes = new HashSet<Narudzbe>();
            this.Primkes = new HashSet<Primke>();
            this.Racunis = new HashSet<Racuni>();
        }
    
        public int ID { get; set; }
        public int UlogaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Adresa { get; set; }
        public string Posta { get; set; }
        public string Telefon { get; set; }
    
        public virtual Uloge Uloge { get; set; }
        public virtual ICollection<Narudzbe> Narudzbes { get; set; }
        public virtual ICollection<Primke> Primkes { get; set; }
        public virtual ICollection<Racuni> Racunis { get; set; }
    }
}