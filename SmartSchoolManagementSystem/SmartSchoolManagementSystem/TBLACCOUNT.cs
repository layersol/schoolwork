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
    
    public partial class TBLACCOUNT
    {
        public int SYSTEMID { get; set; }
        public Nullable<int> CLASSROLL { get; set; }
        public Nullable<int> CLASSID { get; set; }
        public Nullable<long> ADMISSIONFEE { get; set; }
        public Nullable<long> TUTIONFEE { get; set; }
        public Nullable<long> OTHERFEE { get; set; }
        public Nullable<long> DISCOUNTFEE { get; set; }
        public Nullable<long> TOTALFEE { get; set; }
        public Nullable<long> PAIDFEE { get; set; }
        public Nullable<System.DateTime> FEEDATE { get; set; }
        public string SESSION { get; set; }
    }
}
