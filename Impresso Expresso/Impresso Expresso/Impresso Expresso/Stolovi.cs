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
    
    public partial class Stolovi
    {
        public Stolovi()
        {
            this.Narudzbes = new HashSet<Narudzbe>();
        }
    
        public int ID { get; set; }
        public int BrojMjesta { get; set; }
    
        public virtual ICollection<Narudzbe> Narudzbes { get; set; }
    }
}
