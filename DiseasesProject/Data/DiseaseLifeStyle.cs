//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiseasesProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiseaseLifeStyle
    {
        public int ID { get; set; }
        public Nullable<int> DiseaseID { get; set; }
        public Nullable<int> dlID { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<bool> Gender { get; set; }
    
        public virtual DietLifeStyle DietLifeStyle { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
