﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class smartschooldbEntities : DbContext
    {
        public smartschooldbEntities()
            : base("name=smartschooldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblacadmicSession> TblacadmicSessions { get; set; }
        public virtual DbSet<TbladdBus> TbladdBuses { get; set; }
        public virtual DbSet<TBLADDMISSION> TBLADDMISSIONs { get; set; }
        public virtual DbSet<Tbladmissionprint> Tbladmissionprints { get; set; }
        public virtual DbSet<Tblbusdestination> Tblbusdestinations { get; set; }
        public virtual DbSet<Tblclass> Tblclasses { get; set; }
        public virtual DbSet<Tblclasssection> Tblclasssections { get; set; }
        public virtual DbSet<TBLFEEMASTER> TBLFEEMASTERs { get; set; }
        public virtual DbSet<Tblschoolsetting> Tblschoolsettings { get; set; }
        public virtual DbSet<TblSection> TblSections { get; set; }
        public virtual DbSet<TBLSTUDENTENRROL> TBLSTUDENTENRROLs { get; set; }
        public virtual DbSet<TBLSTUDENTFEEDETAIL> TBLSTUDENTFEEDETAILS { get; set; }
        public virtual DbSet<TblTeacherInformation> TblTeacherInformations { get; set; }
        public virtual DbSet<TBLUSER> TBLUSERs { get; set; }
        public virtual DbSet<UserDeatil> UserDeatils { get; set; }
        public virtual DbSet<Tblbusstop> Tblbusstops { get; set; }
        public virtual DbSet<TBLTRANSMASTER> TBLTRANSMASTERs { get; set; }
        public virtual DbSet<TBLBUSSESMAPPING> TBLBUSSESMAPPINGs { get; set; }
        public virtual DbSet<tblexpensename> tblexpensenames { get; set; }
        public virtual DbSet<TBLAttendance> TBLAttendances { get; set; }
        public virtual DbSet<tblgroupname> tblgroupnames { get; set; }
        public virtual DbSet<tblmedium> tblmediums { get; set; }
        public virtual DbSet<TBLStaffAttendance> TBLStaffAttendances { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tblsubjectiondefination> Tblsubjectiondefinations { get; set; }
        public virtual DbSet<Tbladdsubject> Tbladdsubjects { get; set; }
    }
}
