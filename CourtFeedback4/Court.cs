//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourtFeedback4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Court
    {
        public Court()
        {
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public int CourtId { get; set; }
        public string Court1 { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
