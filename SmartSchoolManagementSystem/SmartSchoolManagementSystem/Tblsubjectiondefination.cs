//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSchoolManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tblsubjectiondefination
    {
        public int SubID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> TechId { get; set; }
        public string SubjectName { get; set; }
        public Nullable<decimal> MaxMarks { get; set; }
        public Nullable<decimal> PassingMarks { get; set; }
        public Nullable<System.TimeSpan> Lectstart { get; set; }
        public Nullable<System.TimeSpan> LectEnd { get; set; }
    }
}
