//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetCabinetDentaire
{
    using System;
    using System.Collections.Generic;
    
    public partial class payement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public payement()
        {
            this.tranche = new HashSet<tranche>();
        }
    
        public int IDPay { get; set; }
        public Nullable<decimal> MontantPay { get; set; }
        public Nullable<decimal> Avance { get; set; }
        public Nullable<System.DateTime> Datepay { get; set; }
        public Nullable<int> IdPyDiag { get; set; }
    
        public virtual diagnostique diagnostique { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tranche> tranche { get; set; }
    }
}