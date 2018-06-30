
namespace CTShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WebActions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebActions()
        {
            this.ActionRoles = new HashSet<ActionRoles>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionRoles> ActionRoles { get; set; }
    }
}
