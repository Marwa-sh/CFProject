//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CfProjectAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUsersRole
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
    
        public virtual AspNetRole AspNetRole { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUsersRole AspNetUsersRoles1 { get; set; }
        public virtual AspNetUsersRole AspNetUsersRole1 { get; set; }
    }
}
