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
    
    public partial class TBLADDMISSION
    {
        public int ID { get; set; }
        public string ADMISSION_FORM { get; set; }
        public string STUDENT_NAME { get; set; }
        public string FATHER_NAME { get; set; }
        public string STUDENT_NIC { get; set; }
        public string FATHER_NIC { get; set; }
        public string GENDER { get; set; }
        public string RELIGION { get; set; }
        public string FATHER_OCCUPATION { get; set; }
        public Nullable<System.DateTime> ADMISSION_DATE { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PLACE_BIRTH { get; set; }
        public string MONTHLY_INCOM { get; set; }
        public string CAST { get; set; }
        public string CELL_NO { get; set; }
        public string LANDLINE { get; set; }
        public string OTHER_NO { get; set; }
        public string CURRENT_ADDRESS { get; set; }
        public string PERMANENT_ADDRESS { get; set; }
        public string PREVIOUS_SCHOOL { get; set; }
        public string OBTAIN_MARKS { get; set; }
        public string TOTAL_MARKS { get; set; }
        public string BLOODGROUP { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public Nullable<bool> ADMISSION_STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public byte[] IMAGE { get; set; }
    }
}