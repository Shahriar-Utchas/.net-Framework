//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Charity_Donation_Mid_Exam_.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation
    {
        public int DonorID { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int CampainID { get; set; }
    
        public virtual CampainInfo CampainInfo { get; set; }
    }
}
