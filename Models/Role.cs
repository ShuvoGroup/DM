//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int User_Id { get; set; }
        public Nullable<int> Created_by { get; set; }
        public Nullable<int> Updated_by { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
    }
}
