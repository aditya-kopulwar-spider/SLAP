//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLAP_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PCAssociate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PCAssociate()
        {
            this.Peers = new HashSet<Peer>();
        }
    
        public int PCAssociatesId { get; set; }
        public System.Guid PCUserId { get; set; }
        public System.Guid AssociateUserId { get; set; }
        public Nullable<System.DateTime> AppraisalDate { get; set; }
        public Nullable<System.DateTime> LastNotificationDate { get; set; }
        public string SelfAppraisalDocumentUrl { get; set; }
        public int AppraisalSeasonId { get; set; }
        public bool PeerListFinalized { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Peer> Peers { get; set; }
        public virtual AppraisalSeason AppraisalSeason { get; set; }
    }
}
