//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwachhBharatAPI.Dal.DataContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Daily_Attendance
    {
        public int daID { get; set; }
        public Nullable<int> userId { get; set; }
        public string startLat { get; set; }
        public string startLong { get; set; }
        public string endLat { get; set; }
        public string endLong { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public Nullable<System.DateTime> daDate { get; set; }
        public Nullable<System.DateTime> daEndDate { get; set; }
        public string vtId { get; set; }
        public string daStartNote { get; set; }
        public string daEndNote { get; set; }
        public string vehicleNumber { get; set; }
        public string batteryStatus { get; set; }
        public Nullable<int> totalKm { get; set; }
        public string OutbatteryStatus { get; set; }
        public string EmployeeType { get; set; }
        public Nullable<int> dyid { get; set; }
        public Nullable<int> VQRId { get; set; }
        public byte[] BinaryQrCodeImage { get; set; }
    }
}
