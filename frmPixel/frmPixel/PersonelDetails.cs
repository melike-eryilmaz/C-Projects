//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frmPixel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelDetails
    {
        public byte PersonelId { get; set; }
        public Nullable<double> Salary { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> BornDate { get; set; }
        public string İnterests { get; set; }
    
        public virtual Personels Personels { get; set; }
    }
}
