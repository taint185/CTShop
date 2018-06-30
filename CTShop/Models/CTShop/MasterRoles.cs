
namespace CTShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterRoles
    {
        public int Id { get; set; }
        public string MasterId { get; set; }
        public string RoleId { get; set; }
    
        public virtual Roles Roles { get; set; }
        public virtual Masters Masters { get; set; }
    }
}
