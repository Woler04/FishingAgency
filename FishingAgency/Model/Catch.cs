//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishingAgency.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Catch
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public double Lenght { get; set; }
        public System.DateTime StartDate { get; set; }
        public int ShipId { get; set; }
    
        public virtual FishingShip FishingShip { get; set; }
    }
}