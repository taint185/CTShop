
namespace CTShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionRoles
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int WebActionId { get; set; }
    
        public virtual WebActions WebActions { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
