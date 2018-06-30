
namespace CTShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Masters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masters()
        {
            this.MasterRoles = new HashSet<MasterRoles>();
        }
    
        public string Id { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterRoles> MasterRoles { get; set; }
    }
}
