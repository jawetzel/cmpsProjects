//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelIntegratedComputerSystems.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenanceLogs
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public int MaintenanceTypesId { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual MaintenanceTypes MaintenanceType { get; set; }
    }
}
