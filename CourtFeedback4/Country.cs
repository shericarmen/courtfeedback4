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
    
    public partial class Country
    {
        public Country()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.Courts = new HashSet<Court>();
        }
    
        public int CountryId { get; set; }
        public string Country1 { get; set; }
    
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Court> Courts { get; set; }
    }
}
