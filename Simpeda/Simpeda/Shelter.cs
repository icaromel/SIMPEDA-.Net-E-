//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simpeda
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shelter
    {
        public Shelter()
        {
            this.Sepeda = new HashSet<Sepeda>();
        }
    
        public int idShelter { get; set; }
        public string lokasiShelter { get; set; }
        public string deskripsiShelter { get; set; }
    
        public virtual ICollection<Sepeda> Sepeda { get; set; }
    }
}
